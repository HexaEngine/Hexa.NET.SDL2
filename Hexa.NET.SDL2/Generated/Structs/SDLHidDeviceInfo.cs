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
	/// hidapi info structure <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_hid_device_info")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLHidDeviceInfo
	{
		/// <summary>
		/// Platform-specific device path <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "path")]
		[NativeName(NativeNameType.Type, "char*")]
		public unsafe byte* Path;

		/// <summary>
		/// Device Vendor ID <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "vendor_id")]
		[NativeName(NativeNameType.Type, "unsigned short")]
		public ushort VendorId;

		/// <summary>
		/// Device Product ID <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "product_id")]
		[NativeName(NativeNameType.Type, "unsigned short")]
		public ushort ProductId;

		/// <summary>
		/// Serial Number <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "serial_number")]
		[NativeName(NativeNameType.Type, "wchar*")]
		public unsafe char* SerialNumber;

		/// <summary>
		/// Device Release Number in binary-coded decimal,<br/>
		/// also known as Device Version Number <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "release_number")]
		[NativeName(NativeNameType.Type, "unsigned short")]
		public ushort ReleaseNumber;

		/// <summary>
		/// Manufacturer String <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "manufacturer_string")]
		[NativeName(NativeNameType.Type, "wchar*")]
		public unsafe char* ManufacturerString;

		/// <summary>
		/// Product string <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "product_string")]
		[NativeName(NativeNameType.Type, "wchar*")]
		public unsafe char* ProductString;

		/// <summary>
		/// Usage Page for this Device/Interface<br/>
		/// (Windows/Mac only). <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "usage_page")]
		[NativeName(NativeNameType.Type, "unsigned short")]
		public ushort UsagePage;

		/// <summary>
		/// Usage for this Device/Interface<br/>
		/// (Windows/Mac only).<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "usage")]
		[NativeName(NativeNameType.Type, "unsigned short")]
		public ushort Usage;

		/// <summary>
		/// The USB interface which this logical device<br/>
		/// represents.<br/>
		/// Valid on both Linux implementations in all cases.<br/>
		/// Valid on the Windows implementation only if the device<br/>
		/// contains more than one interface. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "interface_number")]
		[NativeName(NativeNameType.Type, "int")]
		public int InterfaceNumber;

		/// <summary>
		/// Additional information about the USB interface.<br/>
		/// Valid on libusb and Android implementations. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "interface_class")]
		[NativeName(NativeNameType.Type, "int")]
		public int InterfaceClass;

		[NativeName(NativeNameType.Field, "interface_subclass")]
		[NativeName(NativeNameType.Type, "int")]
		public int InterfaceSubclass;
		[NativeName(NativeNameType.Field, "interface_protocol")]
		[NativeName(NativeNameType.Type, "int")]
		public int InterfaceProtocol;
		/// <summary>
		/// Pointer to the next device <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "next")]
		[NativeName(NativeNameType.Type, "SDL_hid_device_info*")]
		public unsafe SDLHidDeviceInfo* Next;


		public unsafe SDLHidDeviceInfo(byte* path = default, ushort vendorId = default, ushort productId = default, char* serialNumber = default, ushort releaseNumber = default, char* manufacturerString = default, char* productString = default, ushort usagePage = default, ushort usage = default, int interfaceNumber = default, int interfaceClass = default, int interfaceSubclass = default, int interfaceProtocol = default, SDLHidDeviceInfo* next = default)
		{
			Path = path;
			VendorId = vendorId;
			ProductId = productId;
			SerialNumber = serialNumber;
			ReleaseNumber = releaseNumber;
			ManufacturerString = manufacturerString;
			ProductString = productString;
			UsagePage = usagePage;
			Usage = usage;
			InterfaceNumber = interfaceNumber;
			InterfaceClass = interfaceClass;
			InterfaceSubclass = interfaceSubclass;
			InterfaceProtocol = interfaceProtocol;
			Next = next;
		}


	}

}
