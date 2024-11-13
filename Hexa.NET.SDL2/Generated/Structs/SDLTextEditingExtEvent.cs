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
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLTextEditingExtEvent
	{
		/// <summary>
		/// ::SDL_TEXTEDITING_EXT <br/>
		/// </summary>
		public uint Type;

		/// <summary>
		/// In milliseconds, populated using SDL_GetTicks() <br/>
		/// </summary>
		public uint Timestamp;

		/// <summary>
		/// The window with keyboard focus, if any <br/>
		/// </summary>
		public uint WindowID;

		/// <summary>
		/// The editing text, which should be freed with SDL_free(), and will not be NULL <br/>
		/// </summary>
		public unsafe byte* Text;

		/// <summary>
		/// The start cursor of selected editing text <br/>
		/// </summary>
		public int Start;

		/// <summary>
		/// The length of selected editing text <br/>
		/// </summary>
		public int Length;


		public unsafe SDLTextEditingExtEvent(uint type = default, uint timestamp = default, uint windowID = default, byte* text = default, int start = default, int length = default)
		{
			Type = type;
			Timestamp = timestamp;
			WindowID = windowID;
			Text = text;
			Start = start;
			Length = length;
		}


	}

}
