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
	/// Pressure-sensitive pen pressure / angle event structure (event.paxis.*)<br/>
	/// You might get some of these events even if the pen isn't touching the<br/>
	/// tablet.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_PenAxisEvent")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLPenAxisEvent
	{
		/// <summary>
		/// SDL_EVENT_PEN_AXIS <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "type")]
		[NativeName(NativeNameType.Type, "SDL_EventType")]
		public SDLEventType Type;

		[NativeName(NativeNameType.Field, "reserved")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint Reserved;
		/// <summary>
		/// In nanoseconds, populated using SDL_GetTicksNS() <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "timestamp")]
		[NativeName(NativeNameType.Type, "Uint64")]
		public ulong Timestamp;

		/// <summary>
		/// The window with pen focus, if any <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "windowID")]
		[NativeName(NativeNameType.Type, "SDL_WindowID")]
		public uint WindowID;

		/// <summary>
		/// The pen instance id <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "which")]
		[NativeName(NativeNameType.Type, "SDL_PenID")]
		public uint Which;

		/// <summary>
		/// Complete pen input state at time of event <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "pen_state")]
		[NativeName(NativeNameType.Type, "SDL_PenInputFlags")]
		public SDLPenInputFlags PenState;

		/// <summary>
		/// X coordinate, relative to window <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "x")]
		[NativeName(NativeNameType.Type, "float")]
		public float X;

		/// <summary>
		/// Y coordinate, relative to window <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "y")]
		[NativeName(NativeNameType.Type, "float")]
		public float Y;

		/// <summary>
		/// Axis that has changed <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "axis")]
		[NativeName(NativeNameType.Type, "SDL_PenAxis")]
		public SDLPenAxis Axis;

		/// <summary>
		/// New value of axis <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "value")]
		[NativeName(NativeNameType.Type, "float")]
		public float Value;


		public unsafe SDLPenAxisEvent(SDLEventType type = default, uint reserved = default, ulong timestamp = default, uint windowID = default, uint which = default, SDLPenInputFlags penState = default, float x = default, float y = default, SDLPenAxis axis = default, float value = default)
		{
			Type = type;
			Reserved = reserved;
			Timestamp = timestamp;
			WindowID = windowID;
			Which = which;
			PenState = penState;
			X = x;
			Y = y;
			Axis = axis;
			Value = value;
		}


	}

}
