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
	/// The list of axes available from a controller<br/>
	/// Thumbstick axis values range from SDL_JOYSTICK_AXIS_MIN to SDL_JOYSTICK_AXIS_MAX,<br/>
	/// and are centered within ~8000 of zero, though advanced UI will allow users to set<br/>
	/// or autodetect the dead zone, which varies between controllers.<br/>
	/// Trigger axis values range from 0 (released) to SDL_JOYSTICK_AXIS_MAX<br/>
	/// (fully pressed) when reported by SDL_GameControllerGetAxis(). Note that this is not the<br/>
	/// same range that will be reported by the lower-level SDL_GetJoystickAxis().<br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_GameControllerAxis")]
	[Flags]
	public enum SDLGameControllerAxis : int
	{
		[NativeName(NativeNameType.EnumItem, "SDL_CONTROLLER_AXIS_INVALID")]
		[NativeName(NativeNameType.Value, "-1")]
		Invalid = unchecked(-1),
		[NativeName(NativeNameType.EnumItem, "SDL_CONTROLLER_AXIS_LEFTX")]
		[NativeName(NativeNameType.Value, "0")]
		Leftx = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "SDL_CONTROLLER_AXIS_LEFTY")]
		[NativeName(NativeNameType.Value, "1")]
		Lefty = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "SDL_CONTROLLER_AXIS_RIGHTX")]
		[NativeName(NativeNameType.Value, "2")]
		Rightx = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "SDL_CONTROLLER_AXIS_RIGHTY")]
		[NativeName(NativeNameType.Value, "3")]
		Righty = unchecked(3),
		[NativeName(NativeNameType.EnumItem, "SDL_CONTROLLER_AXIS_TRIGGERLEFT")]
		[NativeName(NativeNameType.Value, "4")]
		Triggerleft = unchecked(4),
		[NativeName(NativeNameType.EnumItem, "SDL_CONTROLLER_AXIS_TRIGGERRIGHT")]
		[NativeName(NativeNameType.Value, "5")]
		Triggerright = unchecked(5),
		[NativeName(NativeNameType.EnumItem, "SDL_CONTROLLER_AXIS_MAX")]
		[NativeName(NativeNameType.Value, "6")]
		Max = unchecked(6),
	}
}
