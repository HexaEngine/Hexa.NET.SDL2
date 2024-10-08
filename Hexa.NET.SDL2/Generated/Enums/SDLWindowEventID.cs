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
	[NativeName(NativeNameType.Enum, "SDL_WindowEventID")]
	[Flags]
	public enum SDLWindowEventID : int
	{
		/// <summary>
		/// Never used <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_WINDOWEVENT_NONE")]
		[NativeName(NativeNameType.Value, "0")]
		None = unchecked(0),

		/// <summary>
		/// Window has been shown <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_WINDOWEVENT_SHOWN")]
		[NativeName(NativeNameType.Value, "1")]
		Shown = unchecked(1),

		/// <summary>
		/// Window has been hidden <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_WINDOWEVENT_HIDDEN")]
		[NativeName(NativeNameType.Value, "2")]
		Hidden = unchecked(2),

		/// <summary>
		/// Window has been exposed and should be<br/>
		/// redrawn <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_WINDOWEVENT_EXPOSED")]
		[NativeName(NativeNameType.Value, "3")]
		Exposed = unchecked(3),

		/// <summary>
		/// Window has been moved to data1, data2<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_WINDOWEVENT_MOVED")]
		[NativeName(NativeNameType.Value, "4")]
		Moved = unchecked(4),

		/// <summary>
		/// Window has been resized to data1xdata2 <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_WINDOWEVENT_RESIZED")]
		[NativeName(NativeNameType.Value, "5")]
		Resized = unchecked(5),

		/// <summary>
		/// The window size has changed, either as<br/>
		/// a result of an API call or through the<br/>
		/// system or user changing the window size. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_WINDOWEVENT_SIZE_CHANGED")]
		[NativeName(NativeNameType.Value, "6")]
		SizeChanged = unchecked(6),

		/// <summary>
		/// Window has been minimized <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_WINDOWEVENT_MINIMIZED")]
		[NativeName(NativeNameType.Value, "7")]
		Minimized = unchecked(7),

		/// <summary>
		/// Window has been maximized <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_WINDOWEVENT_MAXIMIZED")]
		[NativeName(NativeNameType.Value, "8")]
		Maximized = unchecked(8),

		/// <summary>
		/// Window has been restored to normal size<br/>
		/// and position <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_WINDOWEVENT_RESTORED")]
		[NativeName(NativeNameType.Value, "9")]
		Restored = unchecked(9),

		/// <summary>
		/// Window has gained mouse focus <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_WINDOWEVENT_ENTER")]
		[NativeName(NativeNameType.Value, "10")]
		Enter = unchecked(10),

		/// <summary>
		/// Window has lost mouse focus <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_WINDOWEVENT_LEAVE")]
		[NativeName(NativeNameType.Value, "11")]
		Leave = unchecked(11),

		/// <summary>
		/// Window has gained keyboard focus <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_WINDOWEVENT_FOCUS_GAINED")]
		[NativeName(NativeNameType.Value, "12")]
		FocusGained = unchecked(12),

		/// <summary>
		/// Window has lost keyboard focus <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_WINDOWEVENT_FOCUS_LOST")]
		[NativeName(NativeNameType.Value, "13")]
		FocusLost = unchecked(13),

		/// <summary>
		/// The window manager requests that the window be closed <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_WINDOWEVENT_CLOSE")]
		[NativeName(NativeNameType.Value, "14")]
		Close = unchecked(14),

		/// <summary>
		/// Window is being offered a focus (should SetWindowInputFocus() on itself or a subwindow, or ignore) <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_WINDOWEVENT_TAKE_FOCUS")]
		[NativeName(NativeNameType.Value, "15")]
		TakeFocus = unchecked(15),

		/// <summary>
		/// Window had a hit test that wasn't SDL_HITTEST_NORMAL. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_WINDOWEVENT_HIT_TEST")]
		[NativeName(NativeNameType.Value, "16")]
		HitTest = unchecked(16),

		/// <summary>
		/// The ICC profile of the window's display has changed. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_WINDOWEVENT_ICCPROF_CHANGED")]
		[NativeName(NativeNameType.Value, "17")]
		IccprofChanged = unchecked(17),

		/// <summary>
		/// Window has been moved to display data1. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_WINDOWEVENT_DISPLAY_CHANGED")]
		[NativeName(NativeNameType.Value, "18")]
		DisplayChanged = unchecked(18),
	}
}
