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
	/// Possible `whence` values for SDL_IOStream seeking.<br/>
	/// These map to the same "whence" concept that `fseek` or `lseek` use in the<br/>
	/// standard C runtime.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_IOWhence")]
	[Flags]
	public enum SDLIOWhence : int
	{
		/// <summary>
		/// Seek from the beginning of data <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_IO_SEEK_SET")]
		[NativeName(NativeNameType.Value, "0")]
		SeekSet = unchecked(0),

		/// <summary>
		/// Seek relative to current read point <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_IO_SEEK_CUR")]
		[NativeName(NativeNameType.Value, "1")]
		SeekCur = unchecked(1),

		/// <summary>
		/// Seek relative to the end of data <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_IO_SEEK_END")]
		[NativeName(NativeNameType.Value, "2")]
		SeekEnd = unchecked(2),
	}
}
