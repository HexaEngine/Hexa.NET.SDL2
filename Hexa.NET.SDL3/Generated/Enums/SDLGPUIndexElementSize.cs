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
	/// Specifies the size of elements in an index buffer.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_GPUIndexElementSize")]
	[Flags]
	public enum SDLGPUIndexElementSize : int
	{
		/// <summary>
		/// The index elements are 16-bit. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_GPU_INDEXELEMENTSIZE_16BIT")]
		[NativeName(NativeNameType.Value, "0")]
		Indexelementsize16 = unchecked(0),

		/// <summary>
		/// The index elements are 32-bit. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_GPU_INDEXELEMENTSIZE_32BIT")]
		[NativeName(NativeNameType.Value, "1")]
		Indexelementsize32 = unchecked(1),
	}
}
