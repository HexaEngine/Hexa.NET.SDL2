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
	public partial struct SDLJoyHatEvent
	{
		/// <summary>
		/// ::SDL_JOYHATMOTION <br/>
		/// </summary>
		public uint Type;

		/// <summary>
		/// In milliseconds, populated using SDL_GetTicks() <br/>
		/// </summary>
		public uint Timestamp;

		/// <summary>
		/// The joystick instance id <br/>
		/// </summary>
		public int Which;

		/// <summary>
		/// The joystick hat index <br/>
		/// </summary>
		public byte Hat;

		/// <summary>
		/// The hat position value.<br/>
		/// <br/>
		/// Note that zero means the POV is centered.<br/>
		/// </summary>
		public byte Value;

		public byte Padding1;
		public byte Padding2;

		public unsafe SDLJoyHatEvent(uint type = default, uint timestamp = default, int which = default, byte hat = default, byte value = default, byte padding1 = default, byte padding2 = default)
		{
			Type = type;
			Timestamp = timestamp;
			Which = which;
			Hat = hat;
			Value = value;
			Padding1 = padding1;
			Padding2 = padding2;
		}


	}

}
