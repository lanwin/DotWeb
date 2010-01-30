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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mono.Cecil;
using System.Reflection.Emit;
using SR = System.Reflection;

namespace DotWeb.Hosting.Weaver
{
	class GenericProcessorBase
	{
		private IResolver resolver;
		private Dictionary<string, GenericTypeParameterBuilder> byName = new Dictionary<string, GenericTypeParameterBuilder>();

		protected GenericProcessorBase(IResolver resolver) {
			this.resolver = resolver;
		}

		private GenericTypeParameterBuilder GetParameterByName(string name) {
			GenericTypeParameterBuilder ret = null;
			this.byName.TryGetValue(name, out ret);
			return ret;
		}

		public Type GetGenericParameter(TypeReference typeRef) {
			// need to deal with T[]
			if (typeRef is ArrayType) {
				var arrayType = (ArrayType)typeRef;
				var builder = GetParameterByName(arrayType.ElementType.Name);
				if (builder == null)
					return null;
				return builder.MakeArrayType(arrayType.Rank);
			}
			return GetParameterByName(typeRef.Name);
		}

		protected void ProcessParameter(GenericParameter genericParameter, GenericTypeParameterBuilder genericBuilder) {
			genericBuilder.SetGenericParameterAttributes((SR.GenericParameterAttributes)genericParameter.Attributes);

			if (genericParameter.HasConstraints) {
				var interfaces = new List<Type>();
				Type baseTypeConstraint = null;

				foreach (TypeReference item in genericParameter.Constraints) {
					var constraint = item.Resolve();
					var type = resolver.ResolveTypeReference(constraint).Type;
					if (constraint.IsInterface) {
						interfaces.Add(type);
					}
					else {
						baseTypeConstraint = type;
					}
				}

				if (baseTypeConstraint != null) {
					genericBuilder.SetBaseTypeConstraint(baseTypeConstraint);
				}

				if (interfaces.Any()) {
					genericBuilder.SetInterfaceConstraints(interfaces.ToArray());
				}
			}
		}

		protected void ProcessGenericParameters(GenericParameterCollection args, GenericTypeParameterBuilder[] builders) {
			foreach (var builder in builders) {
				byName.Add(builder.Name, builder);
			}

			foreach (GenericParameter arg in args) {
				var builder = byName[arg.Name];
				ProcessParameter(arg, builder);
			}
		}

	}

	class GenericProcessor : GenericProcessorBase
	{
		public GenericProcessor(IResolver resolver)
			: base(resolver) {
		}

		public void ProcessType(TypeDefinition typeDef, TypeBuilder typeBuilder) {
			var names = typeDef.GenericParameters.Cast<GenericParameter>().Select(x => x.Name);
			var builders = typeBuilder.DefineGenericParameters(names.ToArray());
			ProcessGenericParameters(typeDef.GenericParameters, builders);
		}

		public void ProcessMethod(MethodDefinition methodDef, MethodBuilder methodBuilder) {
			var names = methodDef.GenericParameters.Cast<GenericParameter>().Select(x => x.Name);
			var builders = methodBuilder.DefineGenericParameters(names.ToArray());
			ProcessGenericParameters(methodDef.GenericParameters, builders);
		}
	}
}