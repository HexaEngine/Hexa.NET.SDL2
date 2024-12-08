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
	/// A structure specifying the parameters of an indirect draw command.<br/>
	/// Note that the `first_vertex` and `first_instance` parameters are NOT<br/>
	/// compatible with built-in vertex/instance ID variables in shaders (for<br/>
	/// example, SV_VertexID). If your shader depends on these variables, the<br/>
	/// correlating draw call parameter MUST be 0.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_GPUIndirectDrawCommand")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLGPUIndirectDrawCommand
	{
		/// <summary>
		/// The number of vertices to draw. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "num_vertices")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint NumVertices;

		/// <summary>
		/// The number of instances to draw. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "num_instances")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint NumInstances;

		/// <summary>
		/// The index of the first vertex to draw. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "first_vertex")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint FirstVertex;

		/// <summary>
		/// The ID of the first instance to draw. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "first_instance")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint FirstInstance;


		public unsafe SDLGPUIndirectDrawCommand(uint numVertices = default, uint numInstances = default, uint firstVertex = default, uint firstInstance = default)
		{
			NumVertices = numVertices;
			NumInstances = numInstances;
			FirstVertex = firstVertex;
			FirstInstance = firstInstance;
		}


	}

}
