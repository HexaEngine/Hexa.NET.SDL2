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
	/// The structure that describes a virtual joystick.<br/>
	/// This structure should be initialized using SDL_INIT_INTERFACE(). All<br/>
	/// elements of this structure are optional.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_VirtualJoystickDesc")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLVirtualJoystickDesc
	{
		/// <summary>
		/// the version of this interface <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "version")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint Version;

		/// <summary>
		/// `SDL_JoystickType` <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "type")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Type;

		/// <summary>
		/// unused <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "padding")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Padding;

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
		/// the number of balls on this joystick <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "nballs")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Nballs;

		/// <summary>
		/// the number of hats on this joystick <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "nhats")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Nhats;

		/// <summary>
		/// the number of touchpads on this joystick, requires `touchpads` to point at valid descriptions <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "ntouchpads")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Ntouchpads;

		/// <summary>
		/// the number of sensors on this joystick, requires `sensors` to point at valid descriptions <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "nsensors")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Nsensors;

		/// <summary>
		/// unused <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "padding2")]
		[NativeName(NativeNameType.Type, "Uint16[2]")]
		public ushort Padding2_0;
		public ushort Padding2_1;

		/// <summary>
		/// A mask of which buttons are valid for this controller<br/>
		/// e.g. (1 <br/>
		/// <<br/>
		/// <<br/>
		/// SDL_GAMEPAD_BUTTON_SOUTH) <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "button_mask")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint ButtonMask;

		/// <summary>
		/// A mask of which axes are valid for this controller<br/>
		/// e.g. (1 <br/>
		/// <<br/>
		/// <<br/>
		/// SDL_GAMEPAD_AXIS_LEFTX) <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "axis_mask")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint AxisMask;

		/// <summary>
		/// the name of the joystick <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "name")]
		[NativeName(NativeNameType.Type, "char const *")]
		public unsafe byte* Name;

		/// <summary>
		/// A pointer to an array of touchpad descriptions, required if `ntouchpads` is > 0 <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "touchpads")]
		[NativeName(NativeNameType.Type, "SDL_VirtualJoystickTouchpadDesc const *")]
		public unsafe SDLVirtualJoystickTouchpadDesc* Touchpads;

		/// <summary>
		/// A pointer to an array of sensor descriptions, required if `nsensors` is > 0 <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "sensors")]
		[NativeName(NativeNameType.Type, "SDL_VirtualJoystickSensorDesc const *")]
		public unsafe SDLVirtualJoystickSensorDesc* Sensors;

		/// <summary>
		/// User data pointer passed to callbacks <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "userdata")]
		[NativeName(NativeNameType.Type, "void *")]
		public unsafe void* Userdata;

		/// <summary>
		/// Called when the joystick state should be updated <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "Update")]
		[NativeName(NativeNameType.Type, "void (*)(void * userdata) *")]
		public unsafe void* Update;

		/// <summary>
		/// Called when the player index is set <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "SetPlayerIndex")]
		[NativeName(NativeNameType.Type, "void (*)(void * userdata, int player_index) *")]
		public unsafe void* SetPlayerIndex;

		/// <summary>
		/// Implements SDL_RumbleJoystick() <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "Rumble")]
		[NativeName(NativeNameType.Type, "bool (*)(void * userdata, Uint16 low_frequency_rumble, Uint16 high_frequency_rumble) *")]
		public unsafe void* Rumble;

		/// <summary>
		/// Implements SDL_RumbleJoystickTriggers() <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "RumbleTriggers")]
		[NativeName(NativeNameType.Type, "bool (*)(void * userdata, Uint16 left_rumble, Uint16 right_rumble) *")]
		public unsafe void* RumbleTriggers;

		/// <summary>
		/// Implements SDL_SetJoystickLED() <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "SetLED")]
		[NativeName(NativeNameType.Type, "bool (*)(void * userdata, Uint8 red, Uint8 green, Uint8 blue) *")]
		public unsafe void* SetLED;

		/// <summary>
		/// Implements SDL_SendJoystickEffect() <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "SendEffect")]
		[NativeName(NativeNameType.Type, "bool (*)(void * userdata, void const * data, int size) *")]
		public unsafe void* SendEffect;

		/// <summary>
		/// Implements SDL_SetGamepadSensorEnabled() <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "SetSensorsEnabled")]
		[NativeName(NativeNameType.Type, "bool (*)(void * userdata, bool enabled) *")]
		public unsafe void* SetSensorsEnabled;

		/// <summary>
		/// Cleans up the userdata when the joystick is detached <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "Cleanup")]
		[NativeName(NativeNameType.Type, "void (*)(void * userdata) *")]
		public unsafe void* Cleanup;


		public unsafe SDLVirtualJoystickDesc(uint version = default, ushort type = default, ushort padding = default, ushort vendorId = default, ushort productId = default, ushort naxes = default, ushort nbuttons = default, ushort nballs = default, ushort nhats = default, ushort ntouchpads = default, ushort nsensors = default, ushort* padding2 = default, uint buttonMask = default, uint axisMask = default, byte* name = default, SDLVirtualJoystickTouchpadDesc* touchpads = default, SDLVirtualJoystickSensorDesc* sensors = default, void* userdata = default, delegate*<void*, void> update = default, delegate*<void*, int, void> setPlayerIndex = default, delegate*<void*, ushort, ushort, bool> rumble = default, delegate*<void*, ushort, ushort, bool> rumbleTriggers = default, delegate*<void*, byte, byte, byte, bool> setLed = default, delegate*<void*, void*, int, bool> sendEffect = default, delegate*<void*, byte, bool> setSensorsEnabled = default, delegate*<void*, void> cleanup = default)
		{
			Version = version;
			Type = type;
			Padding = padding;
			VendorId = vendorId;
			ProductId = productId;
			Naxes = naxes;
			Nbuttons = nbuttons;
			Nballs = nballs;
			Nhats = nhats;
			Ntouchpads = ntouchpads;
			Nsensors = nsensors;
			if (padding2 != default(ushort*))
			{
				Padding2_0 = padding2[0];
				Padding2_1 = padding2[1];
			}
			ButtonMask = buttonMask;
			AxisMask = axisMask;
			Name = name;
			Touchpads = touchpads;
			Sensors = sensors;
			Userdata = userdata;
			Update = (delegate*<void*, void>*)update;
			SetPlayerIndex = (delegate*<void*, int, void>*)setPlayerIndex;
			Rumble = (delegate*<void*, ushort, ushort, bool>*)rumble;
			RumbleTriggers = (delegate*<void*, ushort, ushort, bool>*)rumbleTriggers;
			SetLED = (delegate*<void*, byte, byte, byte, bool>*)setLed;
			SendEffect = (delegate*<void*, void*, int, bool>*)sendEffect;
			SetSensorsEnabled = (delegate*<void*, byte, bool>*)setSensorsEnabled;
			Cleanup = (delegate*<void*, void>*)cleanup;
		}

		public unsafe SDLVirtualJoystickDesc(uint version = default, ushort type = default, ushort padding = default, ushort vendorId = default, ushort productId = default, ushort naxes = default, ushort nbuttons = default, ushort nballs = default, ushort nhats = default, ushort ntouchpads = default, ushort nsensors = default, Span<ushort> padding2 = default, uint buttonMask = default, uint axisMask = default, byte* name = default, SDLVirtualJoystickTouchpadDesc* touchpads = default, SDLVirtualJoystickSensorDesc* sensors = default, void* userdata = default, delegate*<void*, void> update = default, delegate*<void*, int, void> setPlayerIndex = default, delegate*<void*, ushort, ushort, bool> rumble = default, delegate*<void*, ushort, ushort, bool> rumbleTriggers = default, delegate*<void*, byte, byte, byte, bool> setLed = default, delegate*<void*, void*, int, bool> sendEffect = default, delegate*<void*, byte, bool> setSensorsEnabled = default, delegate*<void*, void> cleanup = default)
		{
			Version = version;
			Type = type;
			Padding = padding;
			VendorId = vendorId;
			ProductId = productId;
			Naxes = naxes;
			Nbuttons = nbuttons;
			Nballs = nballs;
			Nhats = nhats;
			Ntouchpads = ntouchpads;
			Nsensors = nsensors;
			if (padding2 != default(Span<ushort>))
			{
				Padding2_0 = padding2[0];
				Padding2_1 = padding2[1];
			}
			ButtonMask = buttonMask;
			AxisMask = axisMask;
			Name = name;
			Touchpads = touchpads;
			Sensors = sensors;
			Userdata = userdata;
			Update = (delegate*<void*, void>*)update;
			SetPlayerIndex = (delegate*<void*, int, void>*)setPlayerIndex;
			Rumble = (delegate*<void*, ushort, ushort, bool>*)rumble;
			RumbleTriggers = (delegate*<void*, ushort, ushort, bool>*)rumbleTriggers;
			SetLED = (delegate*<void*, byte, byte, byte, bool>*)setLed;
			SendEffect = (delegate*<void*, void*, int, bool>*)sendEffect;
			SetSensorsEnabled = (delegate*<void*, byte, bool>*)setSensorsEnabled;
			Cleanup = (delegate*<void*, void>*)cleanup;
		}


	}

}
