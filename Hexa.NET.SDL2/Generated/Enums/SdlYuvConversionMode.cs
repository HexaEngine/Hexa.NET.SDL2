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

namespace Hexa.NET.SDL2
{
	/// <summary>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_YUV_CONVERSION_MODE")]
	[Flags]
	public enum SdlYuvConversionMode : int
	{
		/// <summary>
		/// Full range JPEG <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_YUV_CONVERSION_JPEG")]
		[NativeName(NativeNameType.Value, "0")]
		Jpeg = unchecked(0),

		/// <summary>
		/// BT.601 (the default) <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_YUV_CONVERSION_BT601")]
		[NativeName(NativeNameType.Value, "1")]
		Bt601 = unchecked(1),

		/// <summary>
		/// BT.709 <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_YUV_CONVERSION_BT709")]
		[NativeName(NativeNameType.Value, "2")]
		Bt709 = unchecked(2),

		/// <summary>
		/// BT.601 for SD content, BT.709 for HD content <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_YUV_CONVERSION_AUTOMATIC")]
		[NativeName(NativeNameType.Value, "3")]
		Automatic = unchecked(3),
	}
}
