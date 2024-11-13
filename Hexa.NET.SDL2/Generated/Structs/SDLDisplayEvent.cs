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
	public partial struct SDLDisplayEvent
	{
		/// <summary>
		/// ::SDL_DISPLAYEVENT <br/>
		/// </summary>
		public uint Type;

		/// <summary>
		/// In milliseconds, populated using SDL_GetTicks() <br/>
		/// </summary>
		public uint Timestamp;

		/// <summary>
		/// The associated display index <br/>
		/// </summary>
		public uint Display;

		/// <summary>
		/// ::SDL_DisplayEventID <br/>
		/// </summary>
		public byte Event;

		public byte Padding1;
		public byte Padding2;
		public byte Padding3;
		/// <summary>
		/// event dependent data <br/>
		/// </summary>
		public int Data1;


		public unsafe SDLDisplayEvent(uint type = default, uint timestamp = default, uint display = default, byte evnt = default, byte padding1 = default, byte padding2 = default, byte padding3 = default, int data1 = default)
		{
			Type = type;
			Timestamp = timestamp;
			Display = display;
			Event = evnt;
			Padding1 = padding1;
			Padding2 = padding2;
			Padding3 = padding3;
			Data1 = data1;
		}


	}

}
