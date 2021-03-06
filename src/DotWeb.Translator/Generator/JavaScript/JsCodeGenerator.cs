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
using System.IO;
using System.CodeDom.Compiler;
using DotWeb.Client;
using DotWeb.Translator.Properties;
using DotWeb.Decompiler.CodeModel;
using DotWeb.Decompiler;
using Mono.Cecil;
using System.Diagnostics;
using DotWeb.Utility.Cecil;

namespace DotWeb.Translator.Generator.JavaScript
{
	public class JsCodeGenerator: ICodeStatementVisitor, ICodeMemberVisitor
	{
		public JsCodeGenerator(TextWriter output, bool writeHeader) {
			this.writer = new IndentedTextWriter(output, "\t");
			if (writeHeader) {
				this.writer.WriteLine("// Generated by H8 at: {0}", DateTime.Now);
				this.writer.WriteLine();
				this.writer.WriteLine(Resources.Runtime);
			}
		}

		public void WriteEntryPoint(TypeDefinition type) {
			this.writer.WriteLine("$wnd.onload = function() {");
			this.writer.Indent++;
			this.writer.WriteLine("new {0}().$ctor();", Print(type));
			this.writer.Indent--;
			this.writer.WriteLine("}");
		}

		public void Write(CodeNamespace ns) {
			ns.Accept(this);
			this.writer.Flush();
		}

		public void Write(CodeTypeDeclaration type) {
			type.Accept(this);
			this.writer.Flush();
		}

		public void Write(CodeMethodMember method) {
			method.Accept(this);
			this.writer.Flush();
		}

		private void WriteLine() {
			this.writer.WriteLine();
		}

		private void WriteLine(object arg) {
			this.writer.WriteLine(arg);
		}

		private void WriteLine(string format, params object[] args) {
			this.writer.WriteLine(format, args);
		}

		private void Write(IEnumerable<CodeStatement> stmts) {
			foreach (var stmt in stmts) {
				stmt.Accept(this);
			}
		}

		private string Print(TypeReference type) {
			return this.printer.Print(type);
		}

		private string Print(CodeExpression expr) {
			return this.printer.Print(expr);
		}

		private string EncodeName(string name) {
			return this.printer.EncodeName(name);
		}

		#region Statements
		public void Visit(CodeSwitchStatement stmt) {
			WriteLine("switch({0}) {{", Print(stmt.Expression));
			this.writer.Indent++;
			foreach (CodeCase cc in stmt.Cases) {
				if (cc.Expressions.Count == 0) {
					WriteLine("default:");
				}
				else {
					foreach (CodeExpression exp in cc.Expressions) {
						WriteLine("case {0}:", Print(exp));
					}
				}
				this.writer.Indent++;
				Write(cc.Statements);
				WriteLine("break;");
				this.writer.Indent--;
			}
			this.writer.Indent--;
			WriteLine("}}");
		}

		public void Visit(CodeVariableDeclarationStatement stmt) {
//			WriteLine("var {1}; // {0}", Print(stmt.Type), stmt.Name);
		}

		public void Visit(CodeCommentStatement stmt) {
			WriteLine("// {0}", stmt.Comment);
		}

		public void Visit(CodeAssignStatement stmt) {
			string rhs;
			CodePrimitiveExpression cpe = stmt.Right as CodePrimitiveExpression;
			if (cpe != null) {
				var evaluator = new CodeTypeEvaluator(this.currentMethod.Definition);
				var typeRef = evaluator.Evaluate(stmt.Left);
				var reflectionType = TypeHelper.GetReflectionType(typeRef);
				object target = Convert.ChangeType(cpe.Value, reflectionType);
				rhs = this.printer.PrintLiteral(target);
			}
			else {
				rhs = Print(stmt.Right);
			}

			CodePropertyReference cpr = stmt.Left as CodePropertyReference;
			if (cpr != null && !cpr.IsFieldLike()) {
				// setter invocation
				// foo.set_X(1);
				WriteLine(string.Format("{0}({1});", Print(cpr.Method), rhs));
				return;
			}

			CodeVariableReference cvr = stmt.Left as CodeVariableReference;
			if (cvr != null) {
				if (!locals.ContainsKey(cvr.Variable.Index)) {
					locals.Add(cvr.Variable.Index, cvr);
					this.writer.Write("var ");
				}
			}
			WriteLine("{0} = {1};", Print(stmt.Left), rhs);
		}

		public void Visit(CodeExpressionStatement stmt) {
			string code = Print(stmt.Expression);
			if(!string.IsNullOrEmpty(code))
				WriteLine("{0};", code);
		}

		public void Visit(CodeReturnStatement stmt) {
			if (stmt.Expression != null)
				WriteLine("return {0};", Print(stmt.Expression));
			else {
				// Optimize for return statements from a void method that is
				// at the end of a function; no code follows this point
				if (currentMethod != null && currentMethod.Statements.Last() == stmt) {
					return;
				}
				WriteLine("return;");
			}
		}

		public void Visit(CodeWhileStatement stmt) {
			WriteLine("while({0}) {{", Print(stmt.TestExpression));
			this.writer.Indent++;
			Write(stmt.Statements);
			this.writer.Indent--;
			WriteLine("}}");
		}

		public void Visit(CodeRepeatStatement stmt) {
			WriteLine("do {{");
			this.writer.Indent++;
			Write(stmt.Statements);
			this.writer.Indent--;
			WriteLine("}} while({0});", Print(stmt.TestExpression));
		}

		public void Visit(CodeIfStatement stmt) {
			WriteLine("if ({0}) {{", Print(stmt.Condition));
			this.writer.Indent++;
			Write(stmt.TrueStatements);
			this.writer.Indent--;
			WriteLine("}}");
			if (stmt.FalseStatements.Count > 0) {
				WriteLine("else {{");
				this.writer.Indent++;
				Write(stmt.FalseStatements);
				this.writer.Indent--;
				WriteLine("}}");
			}
		}

		public void Visit(CodeThrowStatement stmt) {
			WriteLine("throw {0}", Print(stmt.Expression));
		}

		#endregion

		public void WriteTypeConstructor(TypeDefinition type) {
			if(AttributeHelper.IsAnonymous(type))
				return;

			string typeName = Print(type);
			
			//bool isNative = false;// FIXME: type.IsSubclassOf(typeof(JsNativeBase));
			//if (isNative) {
			//    WriteLine("if(typeof({0}) == 'undefined') {{", typeName);
			//    this.writer.Indent++;
			//}

			WriteLine("{0} = function() {{", typeName);
			bool hasBase = type.HasBase();
			this.writer.Indent++;
			if (hasBase) {
				WriteLine("this.$super.constructor();");
			}
			// field initializers go here
			this.writer.Indent--;
			WriteLine("}};");

			if (hasBase) {
				WriteLine("{0}.$extend({1});", typeName, Print(type.BaseType));
			}

			//if (isNative) {
			//    this.writer.Indent--;
			//    WriteLine("}}");
			//}

			WriteLine();
		}

		#region Members
		public void Visit(CodeTypeDeclaration type) {
			try {
				WriteTypeConstructor(type.Type);

				type.Methods.ForEach(x => x.Accept(this));
				WriteLine();

//				type.Properties.ForEach(x => x.Accept(this));
//				WriteLine();
			}
			finally {
				this.writer.Flush();
			}
		}

		public void Visit(CodeMethodMember method) {
			this.printer.CurrentMethod = method.Definition;
			this.currentMethod = method;
			this.locals.Clear();

			//if (method.Instructions != null) {
			//    WriteLine("/*");
			//    foreach (var il in method.Instructions) {
			//        this.WriteLine(il);
			//    }
			//    WriteLine(" */");
			//}

			string[] args = method.Parameters.Select(x => Print(x)).ToArray();
			string name = method.Name;
			if (method.Definition.IsConstructor) {
				WriteLine("{0}.prototype.{1} = function({2}) {{",
					Print(method.Definition.DeclaringType),
					JsPrinter.CtorMethodName,
					string.Join(", ", args)
				);
			}
			else if (method.Definition.IsStatic) {
				if (name == ".cctor")
					name = JsPrinter.CtorMethodName;

				WriteLine("{0}.{1} = function({2}) {{",
					Print(method.Definition.DeclaringType),
					EncodeName(name),
					string.Join(", ", args)
				);
			}
			else {
				WriteLine("{0}.prototype.{1} = function({2}) {{",
					Print(method.Definition.DeclaringType),
					EncodeName(name),
					string.Join(", ", args)
				);
			}

			this.writer.Indent++;
			if (string.IsNullOrEmpty(method.NativeCode)) {
				Write(method.Statements);
				if (method.Definition.IsConstructor) {
					WriteLine("return this;");
				}
			}
			else {
				this.writer.WriteLine(method.NativeCode);
			}
			this.writer.Indent--;
			WriteLine("}};");
			WriteLine();
		}

		public void Visit(CodePropertyGetterMember method) {
			if (AttributeHelper.IsIntrinsic(method.Property)) {
				// FIXME: how to throw exceptions?
				//if (!method.IsAutoImplemented())
				//	throw new InvalidIntrinsicUsageException(method.PropertyInfo.DeclaringType.ToString(), method.PropertyInfo.ToString());
				return;
			}
			// This is to look and optimize for properties that have automatic implementations
			//if (method.IsAutoImplemented())
			//	return;

			Visit((CodeMethodMember)method);
		}

		public void Visit(CodePropertySetterMember method) {
			if (AttributeHelper.IsIntrinsic(method.Property)) {
				// FIXME: how to throw exceptions?
				//if (!method.IsAutoImplemented())
				//	throw new InvalidIntrinsicUsageException(method.PropertyInfo);
				return;
			}
			// This is to look and optimize for properties that have automatic implementations
			//if (method.IsAutoImplemented())
			//	return;
			Visit((CodeMethodMember)method);
		}

		public void Visit(CodeFieldMember field) {
			WriteLine("{0}: {1} // field: {2}",
				EncodeName(field.Name), 
				"{}", 
				Print(field.Definition.FieldType)
			);
		}

		public void Visit(CodeEventMember evt) {
			WriteLine("{0}: {1} // event: {2}",
				EncodeName(evt.Name), 
				"[]", 
				Print(evt.Definition.EventType));
		}

		public void Visit(CodePropertyMember property) {
			//string name = EncodeName(property.Name);
			//if (property.Info.GetAccessors().Any(x => x.IsStatic)) {
			//    WriteLine("{0}.prototype.{1} = function() {{",
			//        Print(property.Info.DeclaringType),
			//        name
			//    );
			//}
			//else {
			//    WriteLine("{0}.{1} = function() {{",
			//        Print(property.Info.DeclaringType),
			//        name
			//    );
			//}

			//this.writer.Indent++;
			//this.writer.WriteLine("return this.get_{0}();", name);
			//this.writer.Indent--;
			//WriteLine("}};");
			//WriteLine();

			//WriteLine("{0}: '' // property: {1}",
			//    EncodeName(property.Name),
			//    Print(property.Info.PropertyType));
		}

		public void WriteNamespaceDecl(CodeNamespace ns) {
			if (!string.IsNullOrEmpty(ns.Name)) {
//				WriteLine("if(typeof({0}) == 'undefined') {0} = {{}};", ns.Name);
				WriteLine("$Namespace('{0}');", ns.Name);
				WriteLine();
			}
		}

		public void Visit(CodeNamespace ns) {
			WriteNamespaceDecl(ns);

			foreach (CodeTypeDeclaration type in ns.Types) {
				Write(type);
			}
		}
		#endregion

		private readonly Dictionary<int, CodeVariableReference> locals = new Dictionary<int, CodeVariableReference>();
		private readonly JsPrinter printer = new JsPrinter();
		private readonly IndentedTextWriter writer;
		private CodeMethodMember currentMethod;
	}
}
