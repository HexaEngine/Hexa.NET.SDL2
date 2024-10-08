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
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDLTest_TextWindow")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLTestTextWindow
	{
		[NativeName(NativeNameType.Field, "rect")]
		[NativeName(NativeNameType.Type, "SDL_Rect")]
		public SDLRect Rect;
		[NativeName(NativeNameType.Field, "current")]
		[NativeName(NativeNameType.Type, "int")]
		public int Current;
		[NativeName(NativeNameType.Field, "numlines")]
		[NativeName(NativeNameType.Type, "int")]
		public int Numlines;
		[NativeName(NativeNameType.Field, "lines")]
		[NativeName(NativeNameType.Type, "char**")]
		public unsafe byte** Lines;

		public unsafe SDLTestTextWindow(SDLRect rect = default, int current = default, int numlines = default, byte** lines = default)
		{
			Rect = rect;
			Current = current;
			Numlines = numlines;
			Lines = lines;
		}


	}

}
