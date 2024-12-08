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
	/// Pixel type. <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_PixelType")]
	[Flags]
	public enum SDLPixelType : int
	{
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELTYPE_UNKNOWN")]
		[NativeName(NativeNameType.Value, "0")]
		Unknown = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELTYPE_INDEX1")]
		[NativeName(NativeNameType.Value, "1")]
		Index1 = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELTYPE_INDEX4")]
		[NativeName(NativeNameType.Value, "2")]
		Index4 = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELTYPE_INDEX8")]
		[NativeName(NativeNameType.Value, "3")]
		Index8 = unchecked(3),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELTYPE_PACKED8")]
		[NativeName(NativeNameType.Value, "4")]
		Packed8 = unchecked(4),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELTYPE_PACKED16")]
		[NativeName(NativeNameType.Value, "5")]
		Packed16 = unchecked(5),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELTYPE_PACKED32")]
		[NativeName(NativeNameType.Value, "6")]
		Packed32 = unchecked(6),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELTYPE_ARRAYU8")]
		[NativeName(NativeNameType.Value, "7")]
		Arrayu8 = unchecked(7),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELTYPE_ARRAYU16")]
		[NativeName(NativeNameType.Value, "8")]
		Arrayu16 = unchecked(8),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELTYPE_ARRAYU32")]
		[NativeName(NativeNameType.Value, "9")]
		Arrayu32 = unchecked(9),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELTYPE_ARRAYF16")]
		[NativeName(NativeNameType.Value, "10")]
		Arrayf16 = unchecked(10),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELTYPE_ARRAYF32")]
		[NativeName(NativeNameType.Value, "11")]
		Arrayf32 = unchecked(11),
		/// <summary>
		/// appended at the end for compatibility with sdl2-compat:  <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELTYPE_INDEX2")]
		[NativeName(NativeNameType.Value, "12")]
		Index2 = unchecked(12),
	}
}
