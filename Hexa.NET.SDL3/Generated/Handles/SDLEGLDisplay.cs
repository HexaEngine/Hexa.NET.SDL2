// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using HexaGen.Runtime;

namespace Hexa.NET.SDL3
{
	/// <summary>
	/// Opaque EGL types.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Typedef, "SDL_EGLDisplay")]
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct SDLEGLDisplay : IEquatable<SDLEGLDisplay>
	{
		public SDLEGLDisplay(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static SDLEGLDisplay Null => new SDLEGLDisplay(0);
		public static implicit operator SDLEGLDisplay(nint handle) => new SDLEGLDisplay(handle);
		public static bool operator ==(SDLEGLDisplay left, SDLEGLDisplay right) => left.Handle == right.Handle;
		public static bool operator !=(SDLEGLDisplay left, SDLEGLDisplay right) => left.Handle != right.Handle;
		public static bool operator ==(SDLEGLDisplay left, nint right) => left.Handle == right;
		public static bool operator !=(SDLEGLDisplay left, nint right) => left.Handle != right;
		public bool Equals(SDLEGLDisplay other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is SDLEGLDisplay handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("SDLEGLDisplay [0x{0}]", Handle.ToString("X"));
		#endif
	}
}