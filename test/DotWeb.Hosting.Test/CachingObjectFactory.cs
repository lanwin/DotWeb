// Copyright 2009, Frank Laub
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
using System;
using System.Collections.Generic;
using DotWeb.Hosting.Bridge;
using Castle.DynamicProxy;
using DotWeb.Client;

namespace DotWeb.Hosting.Test
{
	internal class CachingObjectFactory : IObjectFactory
	{
		private readonly Dictionary<Type, object> cache = new Dictionary<Type, object>();
		private ProxyGenerator proxyGenerator = new ProxyGenerator();
		private ProxyInterceptor interceptor = new ProxyInterceptor();

		#region IObjectFactory Members

		public object CreateInstance(Type type) {
			object ret;
			if (type.IsInterface) {
				ret = CreateInstanceForInterface(type);
			}
			else {
				ret = Activator.CreateInstance(type);
			}

			cache.Add(ret.GetType(), ret);
			return ret;
		}

		#endregion

		public object Get(Type type) { return cache[type]; }

		private object CreateInstanceForInterface(Type type) {
			//var options = new ProxyGenerationOptions {
			//};
			var options = ProxyGenerationOptions.Default;
			var ret = this.proxyGenerator.CreateClassProxy(typeof(JsObject), new Type[] { type }, options, interceptor);
			return ret;
		}
	}
}