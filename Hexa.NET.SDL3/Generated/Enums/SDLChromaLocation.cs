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
	/// Colorspace chroma sample location.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_ChromaLocation")]
	[Flags]
	public enum SDLChromaLocation : int
	{
		/// <summary>
		/// RGB, no chroma sampling <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_CHROMA_LOCATION_NONE")]
		[NativeName(NativeNameType.Value, "0")]
		None = unchecked(0),

		/// <summary>
		/// In MPEG-2, MPEG-4, and AVC, Cb and Cr are taken on midpoint of the left-edge of the 2x2 square. In other words, they have the same horizontal location as the top-left pixel, but is shifted one-half pixel down vertically. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_CHROMA_LOCATION_LEFT")]
		[NativeName(NativeNameType.Value, "1")]
		Left = unchecked(1),

		/// <summary>
		/// In JPEG/JFIF, H.261, and MPEG-1, Cb and Cr are taken at the center of the 2x2 square. In other words, they are offset one-half pixel to the right and one-half pixel down compared to the top-left pixel. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_CHROMA_LOCATION_CENTER")]
		[NativeName(NativeNameType.Value, "2")]
		Center = unchecked(2),

		/// <summary>
		/// In HEVC for BT.2020 and BT.2100 content (in particular on Blu-rays), Cb and Cr are sampled at the same location as the group's top-left Y pixel ("co-sited", "co-located"). <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_CHROMA_LOCATION_TOPLEFT")]
		[NativeName(NativeNameType.Value, "3")]
		Topleft = unchecked(3),
	}
}