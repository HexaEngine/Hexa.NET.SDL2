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
	[NativeName(NativeNameType.Enum, "SDL_DisplayEventID")]
	[Flags]
	public enum SDLDisplayEventID : int
	{
		/// <summary>
		/// Never used <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_DISPLAYEVENT_NONE")]
		[NativeName(NativeNameType.Value, "0")]
		None = unchecked(0),

		/// <summary>
		/// Display orientation has changed to data1 <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_DISPLAYEVENT_ORIENTATION")]
		[NativeName(NativeNameType.Value, "1")]
		Orientation = unchecked(1),

		/// <summary>
		/// Display has been added to the system <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_DISPLAYEVENT_CONNECTED")]
		[NativeName(NativeNameType.Value, "2")]
		Connected = unchecked(2),

		/// <summary>
		/// Display has been removed from the system <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_DISPLAYEVENT_DISCONNECTED")]
		[NativeName(NativeNameType.Value, "3")]
		Disconnected = unchecked(3),

		/// <summary>
		/// Display has changed position <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_DISPLAYEVENT_MOVED")]
		[NativeName(NativeNameType.Value, "4")]
		Moved = unchecked(4),
	}
}
