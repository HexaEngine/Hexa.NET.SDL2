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
	/// Packed component order, high bit -> low bit.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_PackedOrder")]
	[Flags]
	public enum SDLPackedOrder : int
	{
		[NativeName(NativeNameType.EnumItem, "SDL_PACKEDORDER_NONE")]
		[NativeName(NativeNameType.Value, "0")]
		None = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "SDL_PACKEDORDER_XRGB")]
		[NativeName(NativeNameType.Value, "1")]
		Xrgb = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "SDL_PACKEDORDER_RGBX")]
		[NativeName(NativeNameType.Value, "2")]
		Rgbx = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "SDL_PACKEDORDER_ARGB")]
		[NativeName(NativeNameType.Value, "3")]
		Argb = unchecked(3),
		[NativeName(NativeNameType.EnumItem, "SDL_PACKEDORDER_RGBA")]
		[NativeName(NativeNameType.Value, "4")]
		Rgba = unchecked(4),
		[NativeName(NativeNameType.EnumItem, "SDL_PACKEDORDER_XBGR")]
		[NativeName(NativeNameType.Value, "5")]
		Xbgr = unchecked(5),
		[NativeName(NativeNameType.EnumItem, "SDL_PACKEDORDER_BGRX")]
		[NativeName(NativeNameType.Value, "6")]
		Bgrx = unchecked(6),
		[NativeName(NativeNameType.EnumItem, "SDL_PACKEDORDER_ABGR")]
		[NativeName(NativeNameType.Value, "7")]
		Abgr = unchecked(7),
		[NativeName(NativeNameType.EnumItem, "SDL_PACKEDORDER_BGRA")]
		[NativeName(NativeNameType.Value, "8")]
		Bgra = unchecked(8),
	}
}
