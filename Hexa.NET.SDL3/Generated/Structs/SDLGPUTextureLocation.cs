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
	/// A structure specifying a location in a texture.<br/>
	/// Used when copying data from one texture to another.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_GPUTextureLocation")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLGPUTextureLocation
	{
		/// <summary>
		/// The texture used in the copy operation. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "texture")]
		[NativeName(NativeNameType.Type, "SDL_GPUTexture *")]
		public unsafe SDLGPUTexture* Texture;

		/// <summary>
		/// The mip level index of the location. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mip_level")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint MipLevel;

		/// <summary>
		/// The layer index of the location. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "layer")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint Layer;

		/// <summary>
		/// The left offset of the location. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "x")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint X;

		/// <summary>
		/// The top offset of the location. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "y")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint Y;

		/// <summary>
		/// The front offset of the location. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "z")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint Z;


		public unsafe SDLGPUTextureLocation(SDLGPUTexture* texture = default, uint mipLevel = default, uint layer = default, uint x = default, uint y = default, uint z = default)
		{
			Texture = texture;
			MipLevel = mipLevel;
			Layer = layer;
			X = x;
			Y = y;
			Z = z;
		}


	}

}
