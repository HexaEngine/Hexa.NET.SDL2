// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;

namespace Hexa.NET.SDL2
{
	[NativeName(NativeNameType.StructOrClass, "HWND__")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Hwnd
	{
		[NativeName(NativeNameType.Field, "unused")]
		[NativeName(NativeNameType.Type, "int")]
		public int Unused;

		public unsafe Hwnd(int unused = default)
		{
			Unused = unused;
		}


	}

}