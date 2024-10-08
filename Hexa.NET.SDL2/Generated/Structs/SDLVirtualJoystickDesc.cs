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
	/// The structure that defines an extended virtual joystick description<br/>
	/// The caller must zero the structure and then initialize the version with `SDL_VIRTUAL_JOYSTICK_DESC_VERSION` before passing it to SDL_JoystickAttachVirtualEx()<br/>
	/// All other elements of this structure are optional and can be left 0.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_VirtualJoystickDesc")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLVirtualJoystickDesc
	{
		/// <summary>
		/// `SDL_VIRTUAL_JOYSTICK_DESC_VERSION` <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "version")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Version;

		/// <summary>
		/// `SDL_JoystickType` <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "type")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Type;

		/// <summary>
		/// the number of axes on this joystick <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "naxes")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Naxes;

		/// <summary>
		/// the number of buttons on this joystick <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "nbuttons")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Nbuttons;

		/// <summary>
		/// the number of hats on this joystick <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "nhats")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Nhats;

		/// <summary>
		/// the USB vendor ID of this joystick <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "vendor_id")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort VendorId;

		/// <summary>
		/// the USB product ID of this joystick <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "product_id")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort ProductId;

		/// <summary>
		/// unused <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "padding")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Padding;

		/// <summary>
		/// A mask of which buttons are valid for this controller<br/>
		/// e.g. (1 <br/>
		/// <<br/>
		/// <<br/>
		/// SDL_CONTROLLER_BUTTON_A) <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "button_mask")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint ButtonMask;

		/// <summary>
		/// A mask of which axes are valid for this controller<br/>
		/// e.g. (1 <br/>
		/// <<br/>
		/// <<br/>
		/// SDL_CONTROLLER_AXIS_LEFTX) <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "axis_mask")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint AxisMask;

		/// <summary>
		/// the name of the joystick <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "name")]
		[NativeName(NativeNameType.Type, "const char*")]
		public unsafe byte* Name;

		/// <summary>
		/// User data pointer passed to callbacks <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "userdata")]
		[NativeName(NativeNameType.Type, "void*")]
		public unsafe void* Userdata;

		/// <summary>
		/// Called when the joystick state should be updated <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "Update")]
		[NativeName(NativeNameType.Type, "void (*)(void* userdata)*")]
		public unsafe void* Update;

		/// <summary>
		/// Called when the player index is set <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "SetPlayerIndex")]
		[NativeName(NativeNameType.Type, "void (*)(void* userdata, int player_index)*")]
		public unsafe void* SetPlayerIndex;

		/// <summary>
		/// Implements SDL_JoystickRumble() <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "Rumble")]
		[NativeName(NativeNameType.Type, "int (*)(void* userdata, Uint16 low_frequency_rumble, Uint16 high_frequency_rumble)*")]
		public unsafe void* Rumble;

		/// <summary>
		/// Implements SDL_JoystickRumbleTriggers() <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "RumbleTriggers")]
		[NativeName(NativeNameType.Type, "int (*)(void* userdata, Uint16 left_rumble, Uint16 right_rumble)*")]
		public unsafe void* RumbleTriggers;

		/// <summary>
		/// Implements SDL_JoystickSetLED() <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "SetLED")]
		[NativeName(NativeNameType.Type, "int (*)(void* userdata, Uint8 red, Uint8 green, Uint8 blue)*")]
		public unsafe void* SetLED;

		/// <summary>
		/// Implements SDL_JoystickSendEffect() <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "SendEffect")]
		[NativeName(NativeNameType.Type, "int (*)(void* userdata, const void* data, int size)*")]
		public unsafe void* SendEffect;


		public unsafe SDLVirtualJoystickDesc(ushort version = default, ushort type = default, ushort naxes = default, ushort nbuttons = default, ushort nhats = default, ushort vendorId = default, ushort productId = default, ushort padding = default, uint buttonMask = default, uint axisMask = default, byte* name = default, void* userdata = default, delegate*<void*, void> update = default, delegate*<void*, int, void> setPlayerIndex = default, delegate*<void*, ushort, ushort, int> rumble = default, delegate*<void*, ushort, ushort, int> rumbleTriggers = default, delegate*<void*, byte, byte, byte, int> setLed = default, delegate*<void*, void*, int, int> sendEffect = default)
		{
			Version = version;
			Type = type;
			Naxes = naxes;
			Nbuttons = nbuttons;
			Nhats = nhats;
			VendorId = vendorId;
			ProductId = productId;
			Padding = padding;
			ButtonMask = buttonMask;
			AxisMask = axisMask;
			Name = name;
			Userdata = userdata;
			Update = (void*)update;
			SetPlayerIndex = (void*)setPlayerIndex;
			Rumble = (void*)rumble;
			RumbleTriggers = (void*)rumbleTriggers;
			SetLED = (void*)setLed;
			SendEffect = (void*)sendEffect;
		}


	}

}
