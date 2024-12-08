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
	/// A structure containing a template for a Left/Right effect.<br/>
	/// This struct is exclusively for the SDL_HAPTIC_LEFTRIGHT effect.<br/>
	/// The Left/Right effect is used to explicitly control the large and small<br/>
	/// motors, commonly found in modern game controllers. The small (right) motor<br/>
	/// is high frequency, and the large (left) motor is low frequency.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_HapticLeftRight")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLHapticLeftRight
	{
		/// <summary>
		/// SDL_HAPTIC_LEFTRIGHT <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "type")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Type;

		/// <summary>
		/// Duration of the effect in milliseconds. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "length")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint Length;

		/// <summary>
		/// Control of the large controller motor. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "large_magnitude")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort LargeMagnitude;

		/// <summary>
		/// Control of the small controller motor. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "small_magnitude")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort SmallMagnitude;


		public unsafe SDLHapticLeftRight(ushort type = default, uint length = default, ushort largeMagnitude = default, ushort smallMagnitude = default)
		{
			Type = type;
			Length = length;
			LargeMagnitude = largeMagnitude;
			SmallMagnitude = smallMagnitude;
		}


	}

}
