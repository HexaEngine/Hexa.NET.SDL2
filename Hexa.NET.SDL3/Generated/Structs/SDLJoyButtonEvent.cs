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
	/// Joystick button event structure (event.jbutton.*)<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_JoyButtonEvent")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLJoyButtonEvent
	{
		/// <summary>
		/// SDL_EVENT_JOYSTICK_BUTTON_DOWN or SDL_EVENT_JOYSTICK_BUTTON_UP <br/>
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
		/// true if the button is pressed <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "down")]
		[NativeName(NativeNameType.Type, "bool")]
		public byte Down;

		[NativeName(NativeNameType.Field, "padding1")]
		[NativeName(NativeNameType.Type, "Uint8")]
		public byte Padding1;
		[NativeName(NativeNameType.Field, "padding2")]
		[NativeName(NativeNameType.Type, "Uint8")]
		public byte Padding2;

		public unsafe SDLJoyButtonEvent(SDLEventType type = default, uint reserved = default, ulong timestamp = default, int which = default, byte button = default, bool down = default, byte padding1 = default, byte padding2 = default)
		{
			Type = type;
			Reserved = reserved;
			Timestamp = timestamp;
			Which = which;
			Button = button;
			Down = down ? (byte)1 : (byte)0;
			Padding1 = padding1;
			Padding2 = padding2;
		}


	}

}
