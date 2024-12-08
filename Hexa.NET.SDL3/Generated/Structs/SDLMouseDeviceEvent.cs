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
	/// Mouse device event structure (event.mdevice.*)<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_MouseDeviceEvent")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLMouseDeviceEvent
	{
		/// <summary>
		/// SDL_EVENT_MOUSE_ADDED or SDL_EVENT_MOUSE_REMOVED <br/>
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
		/// The mouse instance id <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "which")]
		[NativeName(NativeNameType.Type, "SDL_MouseID")]
		public uint Which;


		public unsafe SDLMouseDeviceEvent(SDLEventType type = default, uint reserved = default, ulong timestamp = default, uint which = default)
		{
			Type = type;
			Reserved = reserved;
			Timestamp = timestamp;
			Which = which;
		}


	}

}
