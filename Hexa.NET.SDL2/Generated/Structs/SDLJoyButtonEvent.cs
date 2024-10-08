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
	[NativeName(NativeNameType.StructOrClass, "SDL_JoyButtonEvent")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLJoyButtonEvent
	{
		/// <summary>
		/// ::SDL_JOYBUTTONDOWN or ::SDL_JOYBUTTONUP <br/>
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
		/// The joystick instance id <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "which")]
		[NativeName(NativeNameType.Type, "SDL_JoystickID")]
		public int Which;

		/// <summary>
		/// The joystick button index <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "button")]
		[NativeName(NativeNameType.Type, "Uint8")]
		public byte Button;

		/// <summary>
		/// ::SDL_PRESSED or ::SDL_RELEASED <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "state")]
		[NativeName(NativeNameType.Type, "Uint8")]
		public byte State;

		[NativeName(NativeNameType.Field, "padding1")]
		[NativeName(NativeNameType.Type, "Uint8")]
		public byte Padding1;
		[NativeName(NativeNameType.Field, "padding2")]
		[NativeName(NativeNameType.Type, "Uint8")]
		public byte Padding2;

		public unsafe SDLJoyButtonEvent(uint type = default, uint timestamp = default, int which = default, byte button = default, byte state = default, byte padding1 = default, byte padding2 = default)
		{
			Type = type;
			Timestamp = timestamp;
			Which = which;
			Button = button;
			State = state;
			Padding1 = padding1;
			Padding2 = padding2;
		}


	}

}
