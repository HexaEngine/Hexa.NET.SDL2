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
	/// Get the SDL joystick layer binding for this controller button/axis mapping<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_GameControllerButtonBind")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLGameControllerButtonBind
	{
		[NativeName(NativeNameType.StructOrClass, "SDL_GameControllerButtonBind::")]
		[StructLayout(LayoutKind.Explicit)]
		public partial struct ValueUnion
		{
			[NativeName(NativeNameType.StructOrClass, "SDL_GameControllerButtonBind::::")]
			[StructLayout(LayoutKind.Sequential)]
			public partial struct HatUnion
			{
				[NativeName(NativeNameType.Field, "hat")]
				[NativeName(NativeNameType.Type, "int")]
				public int Hat;
				[NativeName(NativeNameType.Field, "hat_mask")]
				[NativeName(NativeNameType.Type, "int")]
				public int HatMask;

				public unsafe HatUnion(int hat = default, int hatMask = default)
				{
					Hat = hat;
					HatMask = hatMask;
				}


			}

			[NativeName(NativeNameType.Field, "button")]
			[NativeName(NativeNameType.Type, "int")]
			[FieldOffset(0)]
			public int Button;
			[NativeName(NativeNameType.Field, "axis")]
			[NativeName(NativeNameType.Type, "int")]
			[FieldOffset(0)]
			public int Axis;
			[NativeName(NativeNameType.Field, "hat")]
			[NativeName(NativeNameType.Type, "")]
			[FieldOffset(0)]
			public HatUnion Hat;

			public unsafe ValueUnion(int button = default, int axis = default, HatUnion hat = default)
			{
				Button = button;
				Axis = axis;
				Hat = hat;
			}


		}

		[NativeName(NativeNameType.Field, "bindType")]
		[NativeName(NativeNameType.Type, "SDL_GameControllerBindType")]
		public SDLGameControllerBindType BindType;
		[NativeName(NativeNameType.Field, "value")]
		[NativeName(NativeNameType.Type, "")]
		public ValueUnion Union;

		public unsafe SDLGameControllerButtonBind(SDLGameControllerBindType bindType = default, ValueUnion union = default)
		{
			BindType = bindType;
			Union = union;
		}


	}

}