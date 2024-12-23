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
	/// Keyboard text input event structure (event.text.*)<br/>
	/// This event will never be delivered unless text input is enabled by calling<br/>
	/// SDL_StartTextInput(). Text input is disabled by default!<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_TextInputEvent")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLTextInputEvent
	{
		/// <summary>
		/// SDL_EVENT_TEXT_INPUT <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "type")]
		[NativeName(NativeNameType.Type, "SDL_EventType")]
		public SDLEventType Type;

		[NativeName(NativeNameType.Field, "reserved")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint Reserved;
		/// <summary>
		/// In nanoseconds, populated using SDL_GetTicksNS() <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "timestamp")]
		[NativeName(NativeNameType.Type, "Uint64")]
		public ulong Timestamp;

		/// <summary>
		/// The window with keyboard focus, if any <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "windowID")]
		[NativeName(NativeNameType.Type, "SDL_WindowID")]
		public uint WindowID;

		/// <summary>
		/// The input text, UTF-8 encoded <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "text")]
		[NativeName(NativeNameType.Type, "char const *")]
		public unsafe byte* Text;


		public unsafe SDLTextInputEvent(SDLEventType type = default, uint reserved = default, ulong timestamp = default, uint windowID = default, byte* text = default)
		{
			Type = type;
			Reserved = reserved;
			Timestamp = timestamp;
			WindowID = windowID;
			Text = text;
		}


	}

}
