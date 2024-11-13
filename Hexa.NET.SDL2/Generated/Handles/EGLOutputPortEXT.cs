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
	public readonly partial struct EGLOutputPortEXT : IEquatable<EGLOutputPortEXT>
	{
		public EGLOutputPortEXT(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static EGLOutputPortEXT Null => new EGLOutputPortEXT(0);
		public static implicit operator EGLOutputPortEXT(nint handle) => new EGLOutputPortEXT(handle);
		public static bool operator ==(EGLOutputPortEXT left, EGLOutputPortEXT right) => left.Handle == right.Handle;
		public static bool operator !=(EGLOutputPortEXT left, EGLOutputPortEXT right) => left.Handle != right.Handle;
		public static bool operator ==(EGLOutputPortEXT left, nint right) => left.Handle == right;
		public static bool operator !=(EGLOutputPortEXT left, nint right) => left.Handle != right;
		public bool Equals(EGLOutputPortEXT other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is EGLOutputPortEXT handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("EGLOutputPortEXT [0x{0}]", Handle.ToString("X"));
		#endif
	}
}
