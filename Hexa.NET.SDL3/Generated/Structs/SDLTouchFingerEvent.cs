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
	/// Touch finger event structure (event.tfinger.*)<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_TouchFingerEvent")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLTouchFingerEvent
	{
		/// <summary>
		/// SDL_EVENT_FINGER_MOTION or SDL_EVENT_FINGER_DOWN or SDL_EVENT_FINGER_UP <br/>
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
		/// The touch device id <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "touchID")]
		[NativeName(NativeNameType.Type, "SDL_TouchID")]
		public long TouchID;

		[NativeName(NativeNameType.Field, "fingerID")]
		[NativeName(NativeNameType.Type, "SDL_FingerID")]
		public long FingerID;
		/// <summary>
		/// Normalized in the range 0...1 <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "x")]
		[NativeName(NativeNameType.Type, "float")]
		public float X;

		/// <summary>
		/// Normalized in the range 0...1 <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "y")]
		[NativeName(NativeNameType.Type, "float")]
		public float Y;

		/// <summary>
		/// Normalized in the range -1...1 <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "dx")]
		[NativeName(NativeNameType.Type, "float")]
		public float Dx;

		/// <summary>
		/// Normalized in the range -1...1 <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "dy")]
		[NativeName(NativeNameType.Type, "float")]
		public float Dy;

		/// <summary>
		/// Normalized in the range 0...1 <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "pressure")]
		[NativeName(NativeNameType.Type, "float")]
		public float Pressure;

		/// <summary>
		/// The window underneath the finger, if any <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "windowID")]
		[NativeName(NativeNameType.Type, "SDL_WindowID")]
		public uint WindowID;


		public unsafe SDLTouchFingerEvent(SDLEventType type = default, uint reserved = default, ulong timestamp = default, long touchID = default, long fingerID = default, float x = default, float y = default, float dx = default, float dy = default, float pressure = default, uint windowID = default)
		{
			Type = type;
			Reserved = reserved;
			Timestamp = timestamp;
			TouchID = touchID;
			FingerID = fingerID;
			X = x;
			Y = y;
			Dx = dx;
			Dy = dy;
			Pressure = pressure;
			WindowID = windowID;
		}


	}

}
