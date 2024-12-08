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

namespace Hexa.NET.SDL3
{
	/// <summary>
	/// A rectangle, with the origin at the upper left (using floating point<br/>
	/// values).<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_FRect")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLFRect
	{
		[NativeName(NativeNameType.Field, "x")]
		[NativeName(NativeNameType.Type, "float")]
		public float X;
		[NativeName(NativeNameType.Field, "y")]
		[NativeName(NativeNameType.Type, "float")]
		public float Y;
		[NativeName(NativeNameType.Field, "w")]
		[NativeName(NativeNameType.Type, "float")]
		public float W;
		[NativeName(NativeNameType.Field, "h")]
		[NativeName(NativeNameType.Type, "float")]
		public float H;

		public unsafe SDLFRect(float x = default, float y = default, float w = default, float h = default)
		{
			X = x;
			Y = y;
			W = w;
			H = h;
		}


	}

}
