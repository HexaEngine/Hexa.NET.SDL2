// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;

namespace Hexa.NET.SDL3
{
	/// <summary>
	/// Abstract filesystem interface <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_PathType")]
	[Flags]
	public enum SDLPathType : int
	{
		/// <summary>
		/// path does not exist <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_PATHTYPE_NONE")]
		[NativeName(NativeNameType.Value, "0")]
		None = unchecked(0),

		/// <summary>
		/// a normal file <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_PATHTYPE_FILE")]
		[NativeName(NativeNameType.Value, "1")]
		File = unchecked(1),

		/// <summary>
		/// a directory <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_PATHTYPE_DIRECTORY")]
		[NativeName(NativeNameType.Value, "2")]
		Directory = unchecked(2),

		/// <summary>
		/// something completely different like a device node (not a symlink, those are always followed) <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_PATHTYPE_OTHER")]
		[NativeName(NativeNameType.Value, "3")]
		Other = unchecked(3),
	}
}