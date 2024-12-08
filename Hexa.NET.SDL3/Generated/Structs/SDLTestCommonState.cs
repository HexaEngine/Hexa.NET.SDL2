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
	[NativeName(NativeNameType.StructOrClass, "SDLTest_CommonState")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLTestCommonState
	{
		/// <summary>
		/// SDL init flags <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "argv")]
		[NativeName(NativeNameType.Type, "char * *")]
		public unsafe byte** Argv;

		[NativeName(NativeNameType.Field, "flags")]
		[NativeName(NativeNameType.Type, "SDL_InitFlags")]
		public SDLInitFlags Flags;
		[NativeName(NativeNameType.Field, "verbose")]
		[NativeName(NativeNameType.Type, "SDLTest_VerboseFlags")]
		public SDLTestVerboseFlags Verbose;
		/// <summary>
		/// Video info <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "videodriver")]
		[NativeName(NativeNameType.Type, "char const *")]
		public unsafe byte* Videodriver;

		[NativeName(NativeNameType.Field, "display_index")]
		[NativeName(NativeNameType.Type, "int")]
		public int DisplayIndex;
		[NativeName(NativeNameType.Field, "displayID")]
		[NativeName(NativeNameType.Type, "SDL_DisplayID")]
		public uint DisplayID;
		[NativeName(NativeNameType.Field, "window_title")]
		[NativeName(NativeNameType.Type, "char const *")]
		public unsafe byte* WindowTitle;
		[NativeName(NativeNameType.Field, "window_icon")]
		[NativeName(NativeNameType.Type, "char const *")]
		public unsafe byte* WindowIcon;
		[NativeName(NativeNameType.Field, "window_flags")]
		[NativeName(NativeNameType.Type, "SDL_WindowFlags")]
		public SDLWindowFlags WindowFlags;
		[NativeName(NativeNameType.Field, "flash_on_focus_loss")]
		[NativeName(NativeNameType.Type, "SDL_bool")]
		public int FlashOnFocusLoss;
		[NativeName(NativeNameType.Field, "window_x")]
		[NativeName(NativeNameType.Type, "int")]
		public int WindowX;
		[NativeName(NativeNameType.Field, "window_y")]
		[NativeName(NativeNameType.Type, "int")]
		public int WindowY;
		[NativeName(NativeNameType.Field, "window_w")]
		[NativeName(NativeNameType.Type, "int")]
		public int WindowW;
		[NativeName(NativeNameType.Field, "window_h")]
		[NativeName(NativeNameType.Type, "int")]
		public int WindowH;
		[NativeName(NativeNameType.Field, "window_minW")]
		[NativeName(NativeNameType.Type, "int")]
		public int WindowMinW;
		[NativeName(NativeNameType.Field, "window_minH")]
		[NativeName(NativeNameType.Type, "int")]
		public int WindowMinH;
		[NativeName(NativeNameType.Field, "window_maxW")]
		[NativeName(NativeNameType.Type, "int")]
		public int WindowMaxW;
		[NativeName(NativeNameType.Field, "window_maxH")]
		[NativeName(NativeNameType.Type, "int")]
		public int WindowMaxH;
		[NativeName(NativeNameType.Field, "window_min_aspect")]
		[NativeName(NativeNameType.Type, "float")]
		public float WindowMinAspect;
		[NativeName(NativeNameType.Field, "window_max_aspect")]
		[NativeName(NativeNameType.Type, "float")]
		public float WindowMaxAspect;
		[NativeName(NativeNameType.Field, "logical_w")]
		[NativeName(NativeNameType.Type, "int")]
		public int LogicalW;
		[NativeName(NativeNameType.Field, "logical_h")]
		[NativeName(NativeNameType.Type, "int")]
		public int LogicalH;
		[NativeName(NativeNameType.Field, "auto_scale_content")]
		[NativeName(NativeNameType.Type, "SDL_bool")]
		public int AutoScaleContent;
		[NativeName(NativeNameType.Field, "logical_presentation")]
		[NativeName(NativeNameType.Type, "SDL_RendererLogicalPresentation")]
		public SDLRendererLogicalPresentation LogicalPresentation;
		[NativeName(NativeNameType.Field, "logical_scale_mode")]
		[NativeName(NativeNameType.Type, "SDL_ScaleMode")]
		public SDLScaleMode LogicalScaleMode;
		[NativeName(NativeNameType.Field, "scale")]
		[NativeName(NativeNameType.Type, "float")]
		public float Scale;
		[NativeName(NativeNameType.Field, "depth")]
		[NativeName(NativeNameType.Type, "int")]
		public int Depth;
		[NativeName(NativeNameType.Field, "refresh_rate")]
		[NativeName(NativeNameType.Type, "float")]
		public float RefreshRate;
		[NativeName(NativeNameType.Field, "fill_usable_bounds")]
		[NativeName(NativeNameType.Type, "SDL_bool")]
		public int FillUsableBounds;
		[NativeName(NativeNameType.Field, "fullscreen_exclusive")]
		[NativeName(NativeNameType.Type, "SDL_bool")]
		public int FullscreenExclusive;
		[NativeName(NativeNameType.Field, "fullscreen_mode")]
		[NativeName(NativeNameType.Type, "SDL_DisplayMode")]
		public SDLDisplayMode FullscreenMode;
		[NativeName(NativeNameType.Field, "num_windows")]
		[NativeName(NativeNameType.Type, "int")]
		public int NumWindows;
		[NativeName(NativeNameType.Field, "windows")]
		[NativeName(NativeNameType.Type, "SDL_Window * *")]
		public unsafe SDLWindow** Windows;
		/// <summary>
		/// Renderer info <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "renderdriver")]
		[NativeName(NativeNameType.Type, "char const *")]
		public unsafe byte* Renderdriver;

		[NativeName(NativeNameType.Field, "render_vsync")]
		[NativeName(NativeNameType.Type, "int")]
		public int RenderVsync;
		[NativeName(NativeNameType.Field, "skip_renderer")]
		[NativeName(NativeNameType.Type, "SDL_bool")]
		public int SkipRenderer;
		[NativeName(NativeNameType.Field, "renderers")]
		[NativeName(NativeNameType.Type, "SDL_Renderer * *")]
		public unsafe SDLRenderer** Renderers;
		[NativeName(NativeNameType.Field, "targets")]
		[NativeName(NativeNameType.Type, "SDL_Texture * *")]
		public unsafe SDLTexture** Targets;
		/// <summary>
		/// Audio info <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "audiodriver")]
		[NativeName(NativeNameType.Type, "char const *")]
		public unsafe byte* Audiodriver;

		[NativeName(NativeNameType.Field, "audio_format")]
		[NativeName(NativeNameType.Type, "SDL_AudioFormat")]
		public SDLAudioFormat AudioFormat;
		[NativeName(NativeNameType.Field, "audio_channels")]
		[NativeName(NativeNameType.Type, "int")]
		public int AudioChannels;
		[NativeName(NativeNameType.Field, "audio_freq")]
		[NativeName(NativeNameType.Type, "int")]
		public int AudioFreq;
		[NativeName(NativeNameType.Field, "audio_id")]
		[NativeName(NativeNameType.Type, "SDL_AudioDeviceID")]
		public uint AudioId;
		/// <summary>
		/// GL settings <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "gl_red_size")]
		[NativeName(NativeNameType.Type, "int")]
		public int GlRedSize;

		[NativeName(NativeNameType.Field, "gl_green_size")]
		[NativeName(NativeNameType.Type, "int")]
		public int GlGreenSize;
		[NativeName(NativeNameType.Field, "gl_blue_size")]
		[NativeName(NativeNameType.Type, "int")]
		public int GlBlueSize;
		[NativeName(NativeNameType.Field, "gl_alpha_size")]
		[NativeName(NativeNameType.Type, "int")]
		public int GlAlphaSize;
		[NativeName(NativeNameType.Field, "gl_buffer_size")]
		[NativeName(NativeNameType.Type, "int")]
		public int GlBufferSize;
		[NativeName(NativeNameType.Field, "gl_depth_size")]
		[NativeName(NativeNameType.Type, "int")]
		public int GlDepthSize;
		[NativeName(NativeNameType.Field, "gl_stencil_size")]
		[NativeName(NativeNameType.Type, "int")]
		public int GlStencilSize;
		[NativeName(NativeNameType.Field, "gl_double_buffer")]
		[NativeName(NativeNameType.Type, "int")]
		public int GlDoubleBuffer;
		[NativeName(NativeNameType.Field, "gl_accum_red_size")]
		[NativeName(NativeNameType.Type, "int")]
		public int GlAccumRedSize;
		[NativeName(NativeNameType.Field, "gl_accum_green_size")]
		[NativeName(NativeNameType.Type, "int")]
		public int GlAccumGreenSize;
		[NativeName(NativeNameType.Field, "gl_accum_blue_size")]
		[NativeName(NativeNameType.Type, "int")]
		public int GlAccumBlueSize;
		[NativeName(NativeNameType.Field, "gl_accum_alpha_size")]
		[NativeName(NativeNameType.Type, "int")]
		public int GlAccumAlphaSize;
		[NativeName(NativeNameType.Field, "gl_stereo")]
		[NativeName(NativeNameType.Type, "int")]
		public int GlStereo;
		[NativeName(NativeNameType.Field, "gl_multisamplebuffers")]
		[NativeName(NativeNameType.Type, "int")]
		public int GlMultisamplebuffers;
		[NativeName(NativeNameType.Field, "gl_multisamplesamples")]
		[NativeName(NativeNameType.Type, "int")]
		public int GlMultisamplesamples;
		[NativeName(NativeNameType.Field, "gl_retained_backing")]
		[NativeName(NativeNameType.Type, "int")]
		public int GlRetainedBacking;
		[NativeName(NativeNameType.Field, "gl_accelerated")]
		[NativeName(NativeNameType.Type, "int")]
		public int GlAccelerated;
		[NativeName(NativeNameType.Field, "gl_major_version")]
		[NativeName(NativeNameType.Type, "int")]
		public int GlMajorVersion;
		[NativeName(NativeNameType.Field, "gl_minor_version")]
		[NativeName(NativeNameType.Type, "int")]
		public int GlMinorVersion;
		[NativeName(NativeNameType.Field, "gl_debug")]
		[NativeName(NativeNameType.Type, "int")]
		public int GlDebug;
		[NativeName(NativeNameType.Field, "gl_profile_mask")]
		[NativeName(NativeNameType.Type, "int")]
		public int GlProfileMask;
		/// <summary>
		/// Mouse info <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "confine")]
		[NativeName(NativeNameType.Type, "SDL_Rect")]
		public SDLRect Confine;

		[NativeName(NativeNameType.Field, "hide_cursor")]
		[NativeName(NativeNameType.Type, "SDL_bool")]
		public int HideCursor;

		public unsafe SDLTestCommonState(byte** argv = default, SDLInitFlags flags = default, SDLTestVerboseFlags verbose = default, byte* videodriver = default, int displayIndex = default, uint displayID = default, byte* windowTitle = default, byte* windowIcon = default, SDLWindowFlags windowFlags = default, int flashOnFocusLoss = default, int windowX = default, int windowY = default, int windowW = default, int windowH = default, int windowMinw = default, int windowMinh = default, int windowMaxw = default, int windowMaxh = default, float windowMinAspect = default, float windowMaxAspect = default, int logicalW = default, int logicalH = default, int autoScaleContent = default, SDLRendererLogicalPresentation logicalPresentation = default, SDLScaleMode logicalScaleMode = default, float scale = default, int depth = default, float refreshRate = default, int fillUsableBounds = default, int fullscreenExclusive = default, SDLDisplayMode fullscreenMode = default, int numWindows = default, SDLWindow** windows = default, byte* renderdriver = default, int renderVsync = default, int skipRenderer = default, SDLRenderer** renderers = default, SDLTexture** targets = default, byte* audiodriver = default, SDLAudioFormat audioFormat = default, int audioChannels = default, int audioFreq = default, uint audioId = default, int glRedSize = default, int glGreenSize = default, int glBlueSize = default, int glAlphaSize = default, int glBufferSize = default, int glDepthSize = default, int glStencilSize = default, int glDoubleBuffer = default, int glAccumRedSize = default, int glAccumGreenSize = default, int glAccumBlueSize = default, int glAccumAlphaSize = default, int glStereo = default, int glMultisamplebuffers = default, int glMultisamplesamples = default, int glRetainedBacking = default, int glAccelerated = default, int glMajorVersion = default, int glMinorVersion = default, int glDebug = default, int glProfileMask = default, SDLRect confine = default, int hideCursor = default)
		{
			Argv = argv;
			Flags = flags;
			Verbose = verbose;
			Videodriver = videodriver;
			DisplayIndex = displayIndex;
			DisplayID = displayID;
			WindowTitle = windowTitle;
			WindowIcon = windowIcon;
			WindowFlags = windowFlags;
			FlashOnFocusLoss = flashOnFocusLoss;
			WindowX = windowX;
			WindowY = windowY;
			WindowW = windowW;
			WindowH = windowH;
			WindowMinW = windowMinw;
			WindowMinH = windowMinh;
			WindowMaxW = windowMaxw;
			WindowMaxH = windowMaxh;
			WindowMinAspect = windowMinAspect;
			WindowMaxAspect = windowMaxAspect;
			LogicalW = logicalW;
			LogicalH = logicalH;
			AutoScaleContent = autoScaleContent;
			LogicalPresentation = logicalPresentation;
			LogicalScaleMode = logicalScaleMode;
			Scale = scale;
			Depth = depth;
			RefreshRate = refreshRate;
			FillUsableBounds = fillUsableBounds;
			FullscreenExclusive = fullscreenExclusive;
			FullscreenMode = fullscreenMode;
			NumWindows = numWindows;
			Windows = windows;
			Renderdriver = renderdriver;
			RenderVsync = renderVsync;
			SkipRenderer = skipRenderer;
			Renderers = renderers;
			Targets = targets;
			Audiodriver = audiodriver;
			AudioFormat = audioFormat;
			AudioChannels = audioChannels;
			AudioFreq = audioFreq;
			AudioId = audioId;
			GlRedSize = glRedSize;
			GlGreenSize = glGreenSize;
			GlBlueSize = glBlueSize;
			GlAlphaSize = glAlphaSize;
			GlBufferSize = glBufferSize;
			GlDepthSize = glDepthSize;
			GlStencilSize = glStencilSize;
			GlDoubleBuffer = glDoubleBuffer;
			GlAccumRedSize = glAccumRedSize;
			GlAccumGreenSize = glAccumGreenSize;
			GlAccumBlueSize = glAccumBlueSize;
			GlAccumAlphaSize = glAccumAlphaSize;
			GlStereo = glStereo;
			GlMultisamplebuffers = glMultisamplebuffers;
			GlMultisamplesamples = glMultisamplesamples;
			GlRetainedBacking = glRetainedBacking;
			GlAccelerated = glAccelerated;
			GlMajorVersion = glMajorVersion;
			GlMinorVersion = glMinorVersion;
			GlDebug = glDebug;
			GlProfileMask = glProfileMask;
			Confine = confine;
			HideCursor = hideCursor;
		}


	}

}
