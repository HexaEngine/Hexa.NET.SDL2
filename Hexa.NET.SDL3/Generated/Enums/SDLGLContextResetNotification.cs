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
	/// Possible values to be set SDL_GL_CONTEXT_RESET_NOTIFICATION attribute.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_GLContextResetNotification")]
	[Flags]
	public enum SDLGLContextResetNotification : int
	{
		[NativeName(NativeNameType.EnumItem, "SDL_GL_CONTEXT_RESET_NO_NOTIFICATION")]
		[NativeName(NativeNameType.Value, "0")]
		NoNotification = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "SDL_GL_CONTEXT_RESET_LOSE_CONTEXT")]
		[NativeName(NativeNameType.Value, "1")]
		LoseContext = unchecked(1),
	}
}
