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
	/// <summary>
	/// Context structure for the random number generator state.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLTestRandomContext
	{
		public uint A;
		public uint X;
		public uint C;
		public uint Ah;
		public uint Al;

		public unsafe SDLTestRandomContext(uint a = default, uint x = default, uint c = default, uint ah = default, uint al = default)
		{
			A = a;
			X = x;
			C = c;
			Ah = ah;
			Al = al;
		}


	}

}
