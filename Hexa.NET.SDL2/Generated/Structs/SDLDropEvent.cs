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
	[NativeName(NativeNameType.StructOrClass, "SDL_DropEvent")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLDropEvent
	{
		/// <summary>
		/// ::SDL_DROPBEGIN or ::SDL_DROPFILE or ::SDL_DROPTEXT or ::SDL_DROPCOMPLETE <br/>
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
		/// The file name, which should be freed with SDL_free(), is NULL on begin/complete <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "file")]
		[NativeName(NativeNameType.Type, "char*")]
		public unsafe byte* File;

		/// <summary>
		/// The window that was dropped on, if any <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "windowID")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint WindowID;


		public unsafe SDLDropEvent(uint type = default, uint timestamp = default, byte* file = default, uint windowID = default)
		{
			Type = type;
			Timestamp = timestamp;
			File = file;
			WindowID = windowID;
		}


	}

}