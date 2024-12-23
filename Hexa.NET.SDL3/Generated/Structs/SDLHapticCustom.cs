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
	/// A structure containing a template for the SDL_HAPTIC_CUSTOM effect.<br/>
	/// This struct is exclusively for the SDL_HAPTIC_CUSTOM effect.<br/>
	/// A custom force feedback effect is much like a periodic effect, where the<br/>
	/// application can define its exact shape. You will have to allocate the data<br/>
	/// yourself. Data should consist of channels * samples Uint16 samples.<br/>
	/// If channels is one, the effect is rotated using the defined direction.<br/>
	/// Otherwise it uses the samples in data for the different axes.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_HapticCustom")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLHapticCustom
	{
		/// <summary>
		/// SDL_HAPTIC_CUSTOM <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "type")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Type;

		/// <summary>
		/// Direction of the effect. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "direction")]
		[NativeName(NativeNameType.Type, "SDL_HapticDirection")]
		public SDLHapticDirection Direction;

		/// <summary>
		/// Duration of the effect. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "length")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint Length;

		/// <summary>
		/// Delay before starting the effect. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "delay")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Delay;

		/// <summary>
		/// Button that triggers the effect. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "button")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Button;

		/// <summary>
		/// How soon it can be triggered again after button. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "interval")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Interval;

		/// <summary>
		/// Axes to use, minimum of one. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "channels")]
		[NativeName(NativeNameType.Type, "Uint8")]
		public byte Channels;

		/// <summary>
		/// Sample periods. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "period")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Period;

		/// <summary>
		/// Amount of samples. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "samples")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Samples;

		/// <summary>
		/// Should contain channels*samples items. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "data")]
		[NativeName(NativeNameType.Type, "Uint16 *")]
		public unsafe ushort* Data;

		/// <summary>
		/// Duration of the attack. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "attack_length")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort AttackLength;

		/// <summary>
		/// Level at the start of the attack. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "attack_level")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort AttackLevel;

		/// <summary>
		/// Duration of the fade. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "fade_length")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort FadeLength;

		/// <summary>
		/// Level at the end of the fade. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "fade_level")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort FadeLevel;


		public unsafe SDLHapticCustom(ushort type = default, SDLHapticDirection direction = default, uint length = default, ushort delay = default, ushort button = default, ushort interval = default, byte channels = default, ushort period = default, ushort samples = default, ushort* data = default, ushort attackLength = default, ushort attackLevel = default, ushort fadeLength = default, ushort fadeLevel = default)
		{
			Type = type;
			Direction = direction;
			Length = length;
			Delay = delay;
			Button = button;
			Interval = interval;
			Channels = channels;
			Period = period;
			Samples = samples;
			Data = data;
			AttackLength = attackLength;
			AttackLevel = attackLevel;
			FadeLength = fadeLength;
			FadeLevel = fadeLevel;
		}


	}

}
