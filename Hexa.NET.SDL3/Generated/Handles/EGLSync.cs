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
	[NativeName(NativeNameType.Typedef, "EGLSync")]
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct EGLSync : IEquatable<EGLSync>
	{
		public EGLSync(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static EGLSync Null => new EGLSync(0);
		public static implicit operator EGLSync(nint handle) => new EGLSync(handle);
		public static bool operator ==(EGLSync left, EGLSync right) => left.Handle == right.Handle;
		public static bool operator !=(EGLSync left, EGLSync right) => left.Handle != right.Handle;
		public static bool operator ==(EGLSync left, nint right) => left.Handle == right;
		public static bool operator !=(EGLSync left, nint right) => left.Handle != right;
		public bool Equals(EGLSync other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is EGLSync handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("EGLSync [0x{0}]", Handle.ToString("X"));
		#endif
	}
}
