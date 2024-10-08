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
	[NativeName(NativeNameType.StructOrClass, "SDL_AudioDeviceEvent")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLAudioDeviceEvent
	{
		/// <summary>
		/// ::SDL_AUDIODEVICEADDED, or ::SDL_AUDIODEVICEREMOVED <br/>
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
		/// The audio device index for the ADDED event (valid until next SDL_GetNumAudioDevices() call), SDL_AudioDeviceID for the REMOVED event <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "which")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint Which;

		/// <summary>
		/// zero if an output device, non-zero if a capture device. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "iscapture")]
		[NativeName(NativeNameType.Type, "Uint8")]
		public byte Iscapture;

		[NativeName(NativeNameType.Field, "padding1")]
		[NativeName(NativeNameType.Type, "Uint8")]
		public byte Padding1;
		[NativeName(NativeNameType.Field, "padding2")]
		[NativeName(NativeNameType.Type, "Uint8")]
		public byte Padding2;
		[NativeName(NativeNameType.Field, "padding3")]
		[NativeName(NativeNameType.Type, "Uint8")]
		public byte Padding3;

		public unsafe SDLAudioDeviceEvent(uint type = default, uint timestamp = default, uint which = default, byte iscapture = default, byte padding1 = default, byte padding2 = default, byte padding3 = default)
		{
			Type = type;
			Timestamp = timestamp;
			Which = which;
			Iscapture = iscapture;
			Padding1 = padding1;
			Padding2 = padding2;
			Padding3 = padding3;
		}


	}

}
