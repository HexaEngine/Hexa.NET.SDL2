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
	/// Window flash operation.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_FlashOperation")]
	[Flags]
	public enum SDLFlashOperation : int
	{
		/// <summary>
		/// Cancel any window flash state <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_FLASH_CANCEL")]
		[NativeName(NativeNameType.Value, "0")]
		Cancel = unchecked(0),

		/// <summary>
		/// Flash the window briefly to get attention <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_FLASH_BRIEFLY")]
		[NativeName(NativeNameType.Value, "1")]
		Briefly = unchecked(1),

		/// <summary>
		/// Flash the window until it gets focus <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_FLASH_UNTIL_FOCUSED")]
		[NativeName(NativeNameType.Value, "2")]
		UntilFocused = unchecked(2),
	}
}
