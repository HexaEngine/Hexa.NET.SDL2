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
	public partial struct SDLDollarGestureEvent
	{
		/// <summary>
		/// ::SDL_DOLLARGESTURE or ::SDL_DOLLARRECORD <br/>
		/// </summary>
		public uint Type;

		/// <summary>
		/// In milliseconds, populated using SDL_GetTicks() <br/>
		/// </summary>
		public uint Timestamp;

		/// <summary>
		/// The touch device id <br/>
		/// </summary>
		public long TouchId;

		public long GestureId;
		public uint NumFingers;
		public float Error;
		/// <summary>
		/// Normalized center of gesture <br/>
		/// </summary>
		public float X;

		/// <summary>
		/// Normalized center of gesture <br/>
		/// </summary>
		public float Y;


		public unsafe SDLDollarGestureEvent(uint type = default, uint timestamp = default, long touchId = default, long gestureId = default, uint numFingers = default, float error = default, float x = default, float y = default)
		{
			Type = type;
			Timestamp = timestamp;
			TouchId = touchId;
			GestureId = gestureId;
			NumFingers = numFingers;
			Error = error;
			X = x;
			Y = y;
		}


	}

}
