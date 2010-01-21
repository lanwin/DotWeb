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
using System.Linq;
using DotWeb.Client;
using System.DotWeb;
using System.Collections.Generic;

namespace H8
{
	public class SystemTests
	{
		class Base
		{
			public virtual void Foo() {
			}
		}

		class Derived : Base
		{
			public override void Foo() {
				base.Foo();
				this.Foo();
			}
		}

		public void TestBase() {
			Base x = new Base();
			x.Foo();
		}

		public void TestDerived() {
			Derived x = new Derived();
			x.Foo();
		}

		public void TestDerivedThruBase() {
			Base x = new Derived();
			x.Foo();
		}

		public void TestDerivedThruBaseIndirect() {
			Derived x = new Derived();
			UseBase(x);
		}

		private void UseBase(Base x) {
			x.Foo();
		}

		public void TestList() {
			var list = new List<string>();
			list.Add("one");
		}
	}
}