﻿#if HOSTED_MODE
namespace DotWeb.System
#else
namespace System
#endif
{
	public struct Boolean
	{
	}

	public struct Byte
	{
	}

	public struct SByte
	{
	}

	public struct Char
	{
		public static bool IsDigit(char ch) {
			return false;
		}
	}

	public struct Int16
	{
	}

	public struct UInt16
	{
	}

	public struct Int32
	{
	}

	public struct UInt32
	{
	}

	public struct Int64
	{
	}

	public struct UInt64
	{
	}

	public struct Single
	{
	}

	public struct Double
	{
	}

	public struct Void
	{
	}

	public struct IntPtr
	{
	}

	public struct UIntPtr
	{
	}
}