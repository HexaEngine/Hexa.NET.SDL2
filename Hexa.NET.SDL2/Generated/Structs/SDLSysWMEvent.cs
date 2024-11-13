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
	/// <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLSysWMEvent
	{
		/// <summary>
		/// ::SDL_SYSWMEVENT <br/>
		/// </summary>
		public uint Type;

		/// <summary>
		/// In milliseconds, populated using SDL_GetTicks() <br/>
		/// </summary>
		public uint Timestamp;

		/// <summary>
		/// driver dependent data, defined in SDL_syswm.h <br/>
		/// </summary>
		public unsafe SDLSysWMMsg* Msg;


		public unsafe SDLSysWMEvent(uint type = default, uint timestamp = default, SDLSysWMMsg* msg = default)
		{
			Type = type;
			Timestamp = timestamp;
			Msg = msg;
		}


	}

}
