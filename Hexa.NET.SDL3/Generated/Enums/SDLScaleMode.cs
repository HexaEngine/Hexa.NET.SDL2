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
	/// The scaling mode.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_ScaleMode")]
	[Flags]
	public enum SDLScaleMode : int
	{
		/// <summary>
		/// nearest pixel sampling <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_SCALEMODE_NEAREST")]
		[NativeName(NativeNameType.Value, "0")]
		Nearest = unchecked(0),

		/// <summary>
		/// linear filtering <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_SCALEMODE_LINEAR")]
		[NativeName(NativeNameType.Value, "1")]
		Linear = unchecked(1),

		/// <summary>
		/// anisotropic filtering <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_SCALEMODE_BEST")]
		[NativeName(NativeNameType.Value, "2")]
		Best = unchecked(2),
	}
}
