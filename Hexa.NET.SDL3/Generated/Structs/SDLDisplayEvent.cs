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
	/// Display state change event data (event.display.*)<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_DisplayEvent")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLDisplayEvent
	{
		/// <summary>
		/// SDL_DISPLAYEVENT_* <br/>
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
		/// The associated display <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "displayID")]
		[NativeName(NativeNameType.Type, "SDL_DisplayID")]
		public uint DisplayID;

		/// <summary>
		/// event dependent data <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "data1")]
		[NativeName(NativeNameType.Type, "Sint32")]
		public int Data1;

		/// <summary>
		/// event dependent data <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "data2")]
		[NativeName(NativeNameType.Type, "Sint32")]
		public int Data2;


		public unsafe SDLDisplayEvent(SDLEventType type = default, uint reserved = default, ulong timestamp = default, uint displayID = default, int data1 = default, int data2 = default)
		{
			Type = type;
			Reserved = reserved;
			Timestamp = timestamp;
			DisplayID = displayID;
			Data1 = data1;
			Data2 = data2;
		}


	}

}
