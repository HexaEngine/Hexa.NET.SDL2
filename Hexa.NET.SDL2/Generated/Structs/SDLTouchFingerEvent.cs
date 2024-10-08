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
	[NativeName(NativeNameType.StructOrClass, "SDL_TouchFingerEvent")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLTouchFingerEvent
	{
		/// <summary>
		/// ::SDL_FINGERMOTION or ::SDL_FINGERDOWN or ::SDL_FINGERUP <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "type")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint Type;

		/// <summary>
		/// In milliseconds, populated using SDL_GetTicks() <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "timestamp")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint Timestamp;

		/// <summary>
		/// The touch device id <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "touchId")]
		[NativeName(NativeNameType.Type, "SDL_TouchID")]
		public long TouchId;

		[NativeName(NativeNameType.Field, "fingerId")]
		[NativeName(NativeNameType.Type, "SDL_FingerID")]
		public long FingerId;
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
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint WindowID;


		public unsafe SDLTouchFingerEvent(uint type = default, uint timestamp = default, long touchId = default, long fingerId = default, float x = default, float y = default, float dx = default, float dy = default, float pressure = default, uint windowID = default)
		{
			Type = type;
			Timestamp = timestamp;
			TouchId = touchId;
			FingerId = fingerId;
			X = x;
			Y = y;
			Dx = dx;
			Dy = dy;
			Pressure = pressure;
			WindowID = windowID;
		}


	}

}
