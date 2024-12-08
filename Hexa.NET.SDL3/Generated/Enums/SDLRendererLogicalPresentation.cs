// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;

namespace Hexa.NET.SDL3
{
	/// <summary>
	/// How the logical size is mapped to the output.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_RendererLogicalPresentation")]
	[Flags]
	public enum SDLRendererLogicalPresentation : int
	{
		/// <summary>
		/// There is no logical size in effect <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_LOGICAL_PRESENTATION_DISABLED")]
		[NativeName(NativeNameType.Value, "0")]
		Disabled = unchecked(0),

		/// <summary>
		/// The rendered content is stretched to the output resolution <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_LOGICAL_PRESENTATION_STRETCH")]
		[NativeName(NativeNameType.Value, "1")]
		Stretch = unchecked(1),

		/// <summary>
		/// The rendered content is fit to the largest dimension and the other dimension is letterboxed with black bars <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_LOGICAL_PRESENTATION_LETTERBOX")]
		[NativeName(NativeNameType.Value, "2")]
		Letterbox = unchecked(2),

		/// <summary>
		/// The rendered content is fit to the smallest dimension and the other dimension extends beyond the output bounds <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_LOGICAL_PRESENTATION_OVERSCAN")]
		[NativeName(NativeNameType.Value, "3")]
		Overscan = unchecked(3),

		/// <summary>
		/// The rendered content is scaled up by integer multiples to fit the output resolution <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_LOGICAL_PRESENTATION_INTEGER_SCALE")]
		[NativeName(NativeNameType.Value, "4")]
		IntegerScale = unchecked(4),
	}
}
