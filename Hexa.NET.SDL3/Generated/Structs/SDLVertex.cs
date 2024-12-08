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
	/// Vertex structure.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_Vertex")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLVertex
	{
		/// <summary>
		/// Vertex position, in SDL_Renderer coordinates  <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "position")]
		[NativeName(NativeNameType.Type, "SDL_FPoint")]
		public SDLFPoint Position;

		/// <summary>
		/// Vertex color <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "color")]
		[NativeName(NativeNameType.Type, "SDL_FColor")]
		public SDLFColor Color;

		/// <summary>
		/// Normalized texture coordinates, if needed <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "tex_coord")]
		[NativeName(NativeNameType.Type, "SDL_FPoint")]
		public SDLFPoint TexCoord;


		public unsafe SDLVertex(SDLFPoint position = default, SDLFColor color = default, SDLFPoint texCoord = default)
		{
			Position = position;
			Color = color;
			TexCoord = texCoord;
		}


	}

}
