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
// 
using System.Web.Mvc;

namespace DotWeb.Sample.MVC.Controllers
{
	[HandleError]
	public class TestController : BaseController
	{
		public ActionResult Sanity() {
			ViewData["Title"] = "Sanity Test";
			return View();
		}

		public ActionResult EventHandler() {
			ViewData["Title"] = "Event Handler Test";
			return View();
		}

		public ActionResult NativeCallback() {
			ViewData["Title"] = "Native Callback Test";
			return View();
		}

		public ActionResult Expando() {
			ViewData["Title"] = "Expando Test";
			return View();
		}
	}
}