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
	/// Standard gamepad types.<br/>
	/// This type does not necessarily map to first-party controllers from<br/>
	/// Microsoft/Sony/Nintendo; in many cases, third-party controllers can report<br/>
	/// as these, either because they were designed for a specific console, or they<br/>
	/// simply most closely match that console's controllers (does it have A/B/X/Y<br/>
	/// buttons or X/O/Square/Triangle? Does it have a touchpad? etc).<br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_GamepadType")]
	[Flags]
	public enum SDLGamepadType : int
	{
		[NativeName(NativeNameType.EnumItem, "SDL_GAMEPAD_TYPE_UNKNOWN")]
		[NativeName(NativeNameType.Value, "0")]
		Unknown = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "SDL_GAMEPAD_TYPE_STANDARD")]
		[NativeName(NativeNameType.Value, "1")]
		Standard = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "SDL_GAMEPAD_TYPE_XBOX360")]
		[NativeName(NativeNameType.Value, "2")]
		Xbox360 = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "SDL_GAMEPAD_TYPE_XBOXONE")]
		[NativeName(NativeNameType.Value, "3")]
		Xboxone = unchecked(3),
		[NativeName(NativeNameType.EnumItem, "SDL_GAMEPAD_TYPE_PS3")]
		[NativeName(NativeNameType.Value, "4")]
		Ps3 = unchecked(4),
		[NativeName(NativeNameType.EnumItem, "SDL_GAMEPAD_TYPE_PS4")]
		[NativeName(NativeNameType.Value, "5")]
		Ps4 = unchecked(5),
		[NativeName(NativeNameType.EnumItem, "SDL_GAMEPAD_TYPE_PS5")]
		[NativeName(NativeNameType.Value, "6")]
		Ps5 = unchecked(6),
		[NativeName(NativeNameType.EnumItem, "SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_PRO")]
		[NativeName(NativeNameType.Value, "7")]
		NintendoSwitchPro = unchecked(7),
		[NativeName(NativeNameType.EnumItem, "SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_JOYCON_LEFT")]
		[NativeName(NativeNameType.Value, "8")]
		NintendoSwitchJoyconLeft = unchecked(8),
		[NativeName(NativeNameType.EnumItem, "SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_JOYCON_RIGHT")]
		[NativeName(NativeNameType.Value, "9")]
		NintendoSwitchJoyconRight = unchecked(9),
		[NativeName(NativeNameType.EnumItem, "SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_JOYCON_PAIR")]
		[NativeName(NativeNameType.Value, "10")]
		NintendoSwitchJoyconPair = unchecked(10),
		[NativeName(NativeNameType.EnumItem, "SDL_GAMEPAD_TYPE_COUNT")]
		[NativeName(NativeNameType.Value, "11")]
		Count = unchecked(11),
	}
}
