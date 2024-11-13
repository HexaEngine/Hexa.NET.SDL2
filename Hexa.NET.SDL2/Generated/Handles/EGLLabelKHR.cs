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

namespace Hexa.NET.SDL2
{
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct EGLLabelKHR : IEquatable<EGLLabelKHR>
	{
		public EGLLabelKHR(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static EGLLabelKHR Null => new EGLLabelKHR(0);
		public static implicit operator EGLLabelKHR(nint handle) => new EGLLabelKHR(handle);
		public static bool operator ==(EGLLabelKHR left, EGLLabelKHR right) => left.Handle == right.Handle;
		public static bool operator !=(EGLLabelKHR left, EGLLabelKHR right) => left.Handle != right.Handle;
		public static bool operator ==(EGLLabelKHR left, nint right) => left.Handle == right;
		public static bool operator !=(EGLLabelKHR left, nint right) => left.Handle != right;
		public bool Equals(EGLLabelKHR other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is EGLLabelKHR handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("EGLLabelKHR [0x{0}]", Handle.ToString("X"));
		#endif
	}
}
