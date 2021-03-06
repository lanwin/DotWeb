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
using System.Reflection;
using System.IO;
using DotWeb.Translator.Generator.JavaScript;
using DotWeb.Decompiler;
using NUnit.Framework;
using Mono.Cecil;
using System.Linq;

namespace DotWeb.Translator.Test
{
	public abstract class TranslationTestHelper<TDerived> where TDerived : TranslationTestHelper<TDerived>
	{
		protected TranslationTestHelper(string asmName, string src) {
			var compiler = new CSharpCompiler();
			var asm = Assembly.Load(asmName);
			var result = compiler.CompileSource(src, asm);
			this.CompiledAssembly = AssemblyFactory.GetAssembly(result.PathToAssembly);
			var pdb = Path.Combine(Path.GetDirectoryName(result.PathToAssembly), Path.GetFileNameWithoutExtension(result.PathToAssembly) + ".pdb");
			this.CompiledAssembly.MainModule.LoadSymbols();
			File.Delete(result.PathToAssembly);
			File.Delete(pdb);
		}

		protected void TestMethod(string typeName, string methodName, string expected) {
			var type = this.CompiledAssembly.MainModule.Types[typeName];
			TestMethod(type, methodName, expected);
		}

		protected void TestMethod(TypeDefinition type, string methodName, string expected) {
			TestMethod(type, methodName, expected, false);
		}

		protected void TestMethod(string typeName, string methodName, string expected, bool followDependencies) {
			var type = this.CompiledAssembly.MainModule.Types[typeName];
			TestMethod(type, methodName, expected, followDependencies);
		}

		protected void TestMethod(TypeDefinition type, string methodName, string expected, bool followDependencies) {
			string result = GenerateMethod(type, methodName, followDependencies);
			string lhs = expected.Trim();
			string rhs = result.Trim();

			Console.WriteLine("Expected:");
			Console.WriteLine(lhs);

			Console.WriteLine("Actual:");
			Console.WriteLine(rhs);

			Assert.AreEqual(lhs, rhs);
		}

		protected string GenerateMethod(TypeDefinition type, string methodName, bool followDependencies) {
			var method = type.Methods.GetMethod(methodName).First();
			TextWriter writer = new StringWriter();
			var generator = new JsCodeGenerator(writer, false);
			var context = new TranslationContext(generator);
			context.GenerateMethod(method, followDependencies);
			return writer.ToString();
		}

		protected AssemblyDefinition CompiledAssembly;
	}
}
