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
	[NativeName(NativeNameType.Enum, "SDL_LogPriority")]
	[Flags]
	public enum SDLLogPriority : int
	{
		[NativeName(NativeNameType.EnumItem, "SDL_LOG_PRIORITY_VERBOSE")]
		[NativeName(NativeNameType.Value, "1")]
		Verbose = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "SDL_LOG_PRIORITY_DEBUG")]
		[NativeName(NativeNameType.Value, "2")]
		Debug = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "SDL_LOG_PRIORITY_INFO")]
		[NativeName(NativeNameType.Value, "3")]
		Info = unchecked(3),
		[NativeName(NativeNameType.EnumItem, "SDL_LOG_PRIORITY_WARN")]
		[NativeName(NativeNameType.Value, "4")]
		Warn = unchecked(4),
		[NativeName(NativeNameType.EnumItem, "SDL_LOG_PRIORITY_ERROR")]
		[NativeName(NativeNameType.Value, "5")]
		Error = unchecked(5),
		[NativeName(NativeNameType.EnumItem, "SDL_LOG_PRIORITY_CRITICAL")]
		[NativeName(NativeNameType.Value, "6")]
		Critical = unchecked(6),
		[NativeName(NativeNameType.EnumItem, "SDL_NUM_LOG_PRIORITIES")]
		[NativeName(NativeNameType.Value, "7")]
		NumLogPriorities = unchecked(7),
	}
}
