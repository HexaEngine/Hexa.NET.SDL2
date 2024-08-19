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
	/// The SDL thread priority.<br/>
	/// SDL will make system changes as necessary in order to apply the thread priority.<br/>
	/// Code which attempts to control thread state related to priority should be aware<br/>
	/// that calling SDL_SetThreadPriority may alter such state.<br/>
	/// SDL_HINT_THREAD_PRIORITY_POLICY can be used to control aspects of this behavior.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_ThreadPriority")]
	[Flags]
	public enum SDLThreadPriority : int
	{
		[NativeName(NativeNameType.EnumItem, "SDL_THREAD_PRIORITY_LOW")]
		[NativeName(NativeNameType.Value, "0")]
		Low = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "SDL_THREAD_PRIORITY_NORMAL")]
		[NativeName(NativeNameType.Value, "1")]
		Normal = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "SDL_THREAD_PRIORITY_HIGH")]
		[NativeName(NativeNameType.Value, "2")]
		High = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "SDL_THREAD_PRIORITY_TIME_CRITICAL")]
		[NativeName(NativeNameType.Value, "3")]
		TimeCritical = unchecked(3),
	}
}
