﻿// Copyright 2009, Frank Laub
//
// This file is part of DotWeb.
//
// DotWeb is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// DotWeb is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with DotWeb.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotWeb.Utility;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace DotWeb.Decompiler.Core
{
	class ControlFlowGraph
	{
		private int intervalIdGenerator = 1;
		private readonly Dictionary<int, BasicBlock> blocks = new Dictionary<int, BasicBlock>();
		private readonly CodeModelVirtualMachine context = new CodeModelVirtualMachine();

		public MethodDefinition Method { get; private set; } 
		public BasicBlock Root { get; private set; }
		public List<IntervalGraph> Graphs { get; private set; }
		public BasicBlock[] DfsList { get; private set; }
		public bool HasCases { get; private set; }
		public HashSet<MethodReference> ExternalMethods { get; private set; }
		public List<Instruction> Instructions { get; private set; }

		public ControlFlowGraph(MethodDefinition method) {
			this.Method = method;

			this.Instructions = new List<Instruction>();
			this.HasCases = false;

			//foreach (ILInstruction item in reader.Instructions) {
			//    Console.WriteLine(item);
			//}
			
			CreateBlocks();
			ResolveBranches();
			Merge(this.Root);

			BasicBlock[] blocks = new BasicBlock[this.blocks.Values.Count];
			this.blocks.Values.CopyTo(blocks, 0);
			foreach (BasicBlock bb in blocks) {
				bb.InEdgeCount = 0;
				if (bb.DfsTraversed != DfsTraversal.Merge) {
					this.blocks.Remove(bb.BeginOffset);
				}
			}

			DfsNumbering();
			DeriveSequences();
			this.Root.GenerateCodeModel(this.context);
			this.ExternalMethods = this.context.ExternalMethods;
		}

		private void CreateBlocks() {
			int id = 1;
			this.Root = new BasicBlock(Method, id++);
			BasicBlock block = this.Root;
			foreach (Instruction cil in Method.Body.Instructions) {
				this.Instructions.Add(cil);
				if (cil.OpCode.OperandType == OperandType.InlineSwitch)
					this.HasCases = true;

				block.Instructions.Add(cil);
				block = AddBlock(id++, block);
			}
		}

		private void Merge(BasicBlock bb) {
			while (bb.FlowControl != FlowControl.Cond_Branch &&
				bb.FlowControl != FlowControl.Return &&
				bb.FlowControl != FlowControl.Throw) {
				BasicBlock next = (BasicBlock)bb.OutEdges.First();
				if (next.InEdgeCount != 1)
					break;

				bb.OutEdges.Clear();
				bb.OutEdges.AddRange(next.OutEdges);
				bb.Instructions.AddRange(next.Instructions);

				blocks.Remove(next.BeginOffset);
			}
			bb.DfsTraversed = DfsTraversal.Merge;

			foreach (BasicBlock next in bb.OutEdges) {
				if (next.DfsTraversed != DfsTraversal.Merge) {
					Merge(next);
				}
			}
		}

		/// <summary>
		/// resolve branches into in/out edges
		/// </summary>
		private void ResolveBranches() {
			var branchBlocks = blocks.Values.Where(x => x.LastInstruction.IsBranch());
			foreach (BasicBlock bb in branchBlocks) {
				if (bb.LastInstruction.OpCode.OperandType == OperandType.InlineSwitch) {
					var targets = (Instruction[])bb.LastInstruction.Operand;
					foreach (var target in targets) {
						ResolveBranchTarget(bb, target.Offset);
					}
				}
				else {
					var target = (Instruction)bb.LastInstruction.Operand;
					ResolveBranchTarget(bb, target.Offset);
				}
			}
		}

		private void ResolveBranchTarget(BasicBlock bb, int targetOffset) {
			BasicBlock target = blocks[targetOffset];
			if (bb.OutEdges.AddUnique(target)) {
				target.InEdgeCount++;
			}
		}

		private BasicBlock AddBlock(int id, BasicBlock block) {
			blocks.Add(block.BeginOffset, block);
			BasicBlock ret = new BasicBlock(Method, id);
			if (block.FlowControl != FlowControl.Return &&
				block.FlowControl != FlowControl.Branch && 
				block.FlowControl != FlowControl.Throw) {
				block.OutEdges.Add(ret);
				ret.InEdgeCount++;
			}
			return ret;
		}

		private void DfsNumbering() {
			int first = 0;
			int last = blocks.Count - 1;
			this.DfsList = new BasicBlock[blocks.Count];
			this.Root.DfsNumbering(this.DfsList, ref first, ref last);
		}

		private void DeriveSequences() {
			this.Graphs = new List<IntervalGraph>();
			Node root = this.Root;

			IntervalGraph intervals;
			int graphId = 1;
			do {
				intervals = FindIntervals(graphId++, root);
				this.Graphs.Add(intervals);
				root = intervals.First();
			}
			while (intervals.Count > 1);
		}

		/// <summary>
		/// Finds the intervals of graph derivedGi->Gi and places them in the list 
		/// of intervals derivedGi->Ii.
		/// Algorithm by M.S.Hecht.
		/// </summary>
		/// <returns></returns>
		private IntervalGraph FindIntervals(int graphId, Node root) {
			IntervalGraph intervals = new IntervalGraph(graphId);
			List<Node> headers = new List<Node>();

			headers.Enqueue(root);
			root.BeenOnHeaders = true;
			root.ReachingInterval = new Node(-1);

			/* Process header nodes list H */
			while (headers.Any()) {
				Node header = headers.Dequeue();

				Interval interval = new Interval(intervalIdGenerator++);
				interval.Process(headers, header);

				intervals.Add(interval);
			}

			ResolveLinks(intervals);
			return intervals;
		}

		private void ResolveLinks(IntervalGraph intervals) {
			foreach (Interval interval in intervals.Where(x => x.ExternalEdgeCount > 0)) {
				foreach (Node node in interval.Nodes) {
					foreach (Node succ in node.OutEdges) {
						if (succ.Interval != node.Interval) {
							interval.OutEdges.Add(succ.Interval);
							succ.Interval.AddInEdge(interval);
						}
					}
				}
			}
		}

		public override string ToString() {
			StringBuilder sb = new StringBuilder();
			if (Graphs != null) {
				foreach (BasicBlock block in blocks.Values) {
					sb.AppendLine(block.ToString());
				}
			}
			else {
				int i = 0;
				foreach (IntervalGraph list in Graphs) {
					sb.AppendFormat("Level: {0}\n", i++);
					foreach (Interval interval in list) {
						sb.AppendLine(interval.ToString());
					}
				}
			}
			return sb.ToString();
		}
	}
}
