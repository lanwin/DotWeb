﻿using System.DotWeb;

#if HOSTED_MODE
namespace DotWeb.System
#else
namespace System
#endif
{
	public static class Math
	{
		public const double E = 2.71828;
		public const double PI = 3.14159;

		[JsCode("return Math.cos(a);")]
		public static extern double Cos(double a);

		[JsCode("return Math.sin(a);")]
		public static extern double Sin(double a);
	}
}
