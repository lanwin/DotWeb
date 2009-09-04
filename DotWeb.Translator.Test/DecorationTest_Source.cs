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
using DotWeb.Client;

namespace H8
{
	[JsAnonymous]
	class AnonymousClass
	{
		public int X { get; set; }
		public int y;
	}

	// Anonymous classes can only have auto-properties
	[JsAnonymous]
	class InvalidAnonymousClass1
	{
		public int X {
			get { return 1; }
		}
	}

	// Anonymous classes cannot have methods
	[JsAnonymous]
	class InvalidAnonymousClass2
	{
		public int X { get; set; }

		public void Invalid() {
		}
	}

	class IntrinsicClass
	{
		[JsIntrinsic]
		public int Value { get; set; }
	}

	// Only auto-properties are allowed
	class InvalidIntrinsicClass
	{
		[JsIntrinsic]
		public int Value { get { return 1; } }
	}

	class DecorationTests
	{
		[JsCode("alert(arg);")]
		public void TestJsCode(string arg) {
		}

		public void TestJsAnonymous() {
			var item = new AnonymousClass {
				X = 1,
				y = 2
			};

			item.X = item.y;
			item.y = item.X;

			var array = new AnonymousClass[] {
				new AnonymousClass { X = 0, y = 0 },
				new AnonymousClass { X = 1, y = 1 },
			};

			var first = array[0];
			Console.WriteLine(first);
		}

		public void InvalidAnonymousClass1() {
			var item = new InvalidAnonymousClass1();
		}

		public void InvalidAnonymousClass2() {
			var item = new InvalidAnonymousClass2();
		}

		public void TestJsIntrinsic() {
			var item = new IntrinsicClass {
				Value = 1
			};
			Console.Write(item.Value);
		}

		public void InvalidIntrinsicClass() {
			var item = new InvalidIntrinsicClass();
		}
	}
}
