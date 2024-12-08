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
	/// The structure that describes a virtual joystick touchpad.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_VirtualJoystickTouchpadDesc")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLVirtualJoystickTouchpadDesc
	{
		/// <summary>
		/// the number of simultaneous fingers on this touchpad <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "nfingers")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Nfingers;

		[NativeName(NativeNameType.Field, "padding")]
		[NativeName(NativeNameType.Type, "Uint16[3]")]
		public ushort Padding_0;
		public ushort Padding_1;
		public ushort Padding_2;

		public unsafe SDLVirtualJoystickTouchpadDesc(ushort nfingers = default, ushort* padding = default)
		{
			Nfingers = nfingers;
			if (padding != default(ushort*))
			{
				Padding_0 = padding[0];
				Padding_1 = padding[1];
				Padding_2 = padding[2];
			}
		}

		public unsafe SDLVirtualJoystickTouchpadDesc(ushort nfingers = default, Span<ushort> padding = default)
		{
			Nfingers = nfingers;
			if (padding != default(Span<ushort>))
			{
				Padding_0 = padding[0];
				Padding_1 = padding[1];
				Padding_2 = padding[2];
			}
		}


	}

}