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

namespace Hexa.NET.SDL2
{
	/// <summary>
	/// The calculated values in this structure are calculated by SDL_OpenAudio().<br/>
	/// For multi-channel audio, the default SDL channel mapping is:<br/>
	/// 2:  FL  FR                          (stereo)<br/>
	/// 3:  FL  FR LFE                      (2.1 surround)<br/>
	/// 4:  FL  FR  BL  BR                  (quad)<br/>
	/// 5:  FL  FR LFE  BL  BR              (4.1 surround)<br/>
	/// 6:  FL  FR  FC LFE  SL  SR          (5.1 surround - last two can also be BL BR)<br/>
	/// 7:  FL  FR  FC LFE  BC  SL  SR      (6.1 surround)<br/>
	/// 8:  FL  FR  FC LFE  BL  BR  SL  SR  (7.1 surround)<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_AudioSpec")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLAudioSpec
	{
		/// <summary>
		/// DSP frequency -- samples per second <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "freq")]
		[NativeName(NativeNameType.Type, "int")]
		public int Freq;

		/// <summary>
		/// Audio data format <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "format")]
		[NativeName(NativeNameType.Type, "SDL_AudioFormat")]
		public ushort Format;

		/// <summary>
		/// Number of channels: 1 mono, 2 stereo <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "channels")]
		[NativeName(NativeNameType.Type, "Uint8")]
		public byte Channels;

		/// <summary>
		/// Audio buffer silence value (calculated) <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "silence")]
		[NativeName(NativeNameType.Type, "Uint8")]
		public byte Silence;

		/// <summary>
		/// Audio buffer size in sample FRAMES (total samples divided by channel count) <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "samples")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Samples;

		/// <summary>
		/// Necessary for some compile environments <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "padding")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Padding;

		/// <summary>
		/// Audio buffer size in bytes (calculated) <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "size")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint Size;

		/// <summary>
		/// Callback that feeds the audio device (NULL to use SDL_QueueAudio()). <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "callback")]
		[NativeName(NativeNameType.Type, "SDL_AudioCallback")]
		public unsafe void* Callback;
		/// <summary>
		/// Userdata passed to callback (ignored for NULL callbacks). <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "userdata")]
		[NativeName(NativeNameType.Type, "void*")]
		public unsafe void* Userdata;


		public unsafe SDLAudioSpec(int freq = default, ushort format = default, byte channels = default, byte silence = default, ushort samples = default, ushort padding = default, uint size = default, SDLAudioCallback callback = default, void* userdata = default)
		{
			Freq = freq;
			Format = format;
			Channels = channels;
			Silence = silence;
			Samples = samples;
			Padding = padding;
			Size = size;
			Callback = (void*)Marshal.GetFunctionPointerForDelegate(callback);
			Userdata = userdata;
		}


	}

}
