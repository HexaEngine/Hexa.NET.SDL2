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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;

namespace Hexa.NET.SDL3
{
	/// <summary>
	/// A structure specifying parameters in a buffer binding call.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_GPUBufferBinding")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLGPUBufferBinding
	{
		/// <summary>
		/// The buffer to bind. Must have been created with SDL_GPU_BUFFERUSAGE_VERTEX for SDL_BindGPUVertexBuffers, or SDL_GPU_BUFFERUSAGE_INDEX for SDL_BindGPUIndexBuffers. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "buffer")]
		[NativeName(NativeNameType.Type, "SDL_GPUBuffer *")]
		public unsafe SDLGPUBuffer* Buffer;

		/// <summary>
		/// The starting byte of the data to bind in the buffer. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "offset")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint Offset;


		public unsafe SDLGPUBufferBinding(SDLGPUBuffer* buffer = default, uint offset = default)
		{
			Buffer = buffer;
			Offset = offset;
		}


	}

}
