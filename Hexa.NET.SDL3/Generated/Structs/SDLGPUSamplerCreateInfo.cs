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
	/// A structure specifying the parameters of a sampler.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_GPUSamplerCreateInfo")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLGPUSamplerCreateInfo
	{
		/// <summary>
		/// The minification filter to apply to lookups. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "min_filter")]
		[NativeName(NativeNameType.Type, "SDL_GPUFilter")]
		public SDLGPUFilter MinFilter;

		/// <summary>
		/// The magnification filter to apply to lookups. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mag_filter")]
		[NativeName(NativeNameType.Type, "SDL_GPUFilter")]
		public SDLGPUFilter MagFilter;

		/// <summary>
		/// The mipmap filter to apply to lookups. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mipmap_mode")]
		[NativeName(NativeNameType.Type, "SDL_GPUSamplerMipmapMode")]
		public SDLGPUSamplerMipmapMode MipmapMode;

		/// <summary>
		/// The addressing mode for U coordinates outside [0, 1). <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "address_mode_u")]
		[NativeName(NativeNameType.Type, "SDL_GPUSamplerAddressMode")]
		public SDLGPUSamplerAddressMode AddressModeU;

		/// <summary>
		/// The addressing mode for V coordinates outside [0, 1). <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "address_mode_v")]
		[NativeName(NativeNameType.Type, "SDL_GPUSamplerAddressMode")]
		public SDLGPUSamplerAddressMode AddressModeV;

		/// <summary>
		/// The addressing mode for W coordinates outside [0, 1). <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "address_mode_w")]
		[NativeName(NativeNameType.Type, "SDL_GPUSamplerAddressMode")]
		public SDLGPUSamplerAddressMode AddressModeW;

		/// <summary>
		/// The bias to be added to mipmap LOD calculation. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mip_lod_bias")]
		[NativeName(NativeNameType.Type, "float")]
		public float MipLodBias;

		/// <summary>
		/// The anisotropy value clamp used by the sampler. If enable_anisotropy is false, this is ignored. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "max_anisotropy")]
		[NativeName(NativeNameType.Type, "float")]
		public float MaxAnisotropy;

		/// <summary>
		/// The comparison operator to apply to fetched data before filtering. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "compare_op")]
		[NativeName(NativeNameType.Type, "SDL_GPUCompareOp")]
		public SDLGPUCompareOp CompareOp;

		/// <summary>
		/// Clamps the minimum of the computed LOD value. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "min_lod")]
		[NativeName(NativeNameType.Type, "float")]
		public float MinLod;

		/// <summary>
		/// Clamps the maximum of the computed LOD value. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "max_lod")]
		[NativeName(NativeNameType.Type, "float")]
		public float MaxLod;

		/// <summary>
		/// true to enable anisotropic filtering. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "enable_anisotropy")]
		[NativeName(NativeNameType.Type, "bool")]
		public byte EnableAnisotropy;

		/// <summary>
		/// true to enable comparison against a reference value during lookups. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "enable_compare")]
		[NativeName(NativeNameType.Type, "bool")]
		public byte EnableCompare;

		[NativeName(NativeNameType.Field, "padding1")]
		[NativeName(NativeNameType.Type, "Uint8")]
		public byte Padding1;
		[NativeName(NativeNameType.Field, "padding2")]
		[NativeName(NativeNameType.Type, "Uint8")]
		public byte Padding2;
		/// <summary>
		/// A properties ID for extensions. Should be 0 if no extensions are needed. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "props")]
		[NativeName(NativeNameType.Type, "SDL_PropertiesID")]
		public uint Props;


		public unsafe SDLGPUSamplerCreateInfo(SDLGPUFilter minFilter = default, SDLGPUFilter magFilter = default, SDLGPUSamplerMipmapMode mipmapMode = default, SDLGPUSamplerAddressMode addressModeU = default, SDLGPUSamplerAddressMode addressModeV = default, SDLGPUSamplerAddressMode addressModeW = default, float mipLodBias = default, float maxAnisotropy = default, SDLGPUCompareOp compareOp = default, float minLod = default, float maxLod = default, bool enableAnisotropy = default, bool enableCompare = default, byte padding1 = default, byte padding2 = default, uint props = default)
		{
			MinFilter = minFilter;
			MagFilter = magFilter;
			MipmapMode = mipmapMode;
			AddressModeU = addressModeU;
			AddressModeV = addressModeV;
			AddressModeW = addressModeW;
			MipLodBias = mipLodBias;
			MaxAnisotropy = maxAnisotropy;
			CompareOp = compareOp;
			MinLod = minLod;
			MaxLod = maxLod;
			EnableAnisotropy = enableAnisotropy ? (byte)1 : (byte)0;
			EnableCompare = enableCompare ? (byte)1 : (byte)0;
			Padding1 = padding1;
			Padding2 = padding2;
			Props = props;
		}


	}

}