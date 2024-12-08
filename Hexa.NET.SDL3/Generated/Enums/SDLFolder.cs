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
	/// The type of the OS-provided default folder for a specific purpose.<br/>
	/// Note that the Trash folder isn't included here, because trashing files<br/>
	/// usually involves extra OS-specific functionality to remember the file's<br/>
	/// original location.<br/>
	/// The folders supported per platform are:<br/>
	/// |             | Windows | WinRT/UWP |macOS/iOS | tvOS | Unix (XDG) | Haiku | Emscripten |<br/>
	/// | ----------- | ------- | --------- |--------- | ---- | ---------- | ----- | ---------- |<br/>
	/// | HOME        | X       | X         | X        |      | X          | X     | X          |<br/>
	/// | DESKTOP     | X       | X         | X        |      | X          | X     |            |<br/>
	/// | DOCUMENTS   | X       | X         | X        |      | X          |       |            |<br/>
	/// | DOWNLOADS   | Vista+  | X         | X        |      | X          |       |            |<br/>
	/// | MUSIC       | X       | X         | X        |      | X          |       |            |<br/>
	/// | PICTURES    | X       | X         | X        |      | X          |       |            |<br/>
	/// | PUBLICSHARE |         |           | X        |      | X          |       |            |<br/>
	/// | SAVEDGAMES  | Vista+  |           |          |      |            |       |            |<br/>
	/// | SCREENSHOTS | Vista+  | X         |          |      |            |       |            |<br/>
	/// | TEMPLATES   | X       | X         | X        |      | X          |       |            |<br/>
	/// | VIDEOS      | X       | X         | X*       |      | X          |       |            |<br/>
	/// Note that on macOS/iOS, the Videos folder is called "Movies".<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_Folder")]
	[Flags]
	public enum SDLFolder : int
	{
		/// <summary>
		/// The folder which contains all of the current user's data, preferences,<br/>
		/// and documents. It usually contains most of the other folders. If a<br/>
		/// requested folder does not exist, the home folder can be considered a safe<br/>
		/// fallback to store a user's documents. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_FOLDER_HOME")]
		[NativeName(NativeNameType.Value, "0")]
		Home = unchecked(0),

		/// <summary>
		/// The folder of files that are displayed on the desktop. Note that the<br/>
		/// existence of a desktop folder does not guarantee that the system does<br/>
		/// show icons on its desktop; certain GNU/Linux distros with a graphical<br/>
		/// environment may not have desktop icons. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_FOLDER_DESKTOP")]
		[NativeName(NativeNameType.Value, "1")]
		Desktop = unchecked(1),

		/// <summary>
		/// User document files, possibly application-specific. This is a good<br/>
		/// place to save a user's projects. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_FOLDER_DOCUMENTS")]
		[NativeName(NativeNameType.Value, "2")]
		Documents = unchecked(2),

		/// <summary>
		/// Standard folder for user files downloaded from the internet. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_FOLDER_DOWNLOADS")]
		[NativeName(NativeNameType.Value, "3")]
		Downloads = unchecked(3),

		/// <summary>
		/// Music files that can be played using a standard music player (mp3,<br/>
		/// ogg...). <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_FOLDER_MUSIC")]
		[NativeName(NativeNameType.Value, "4")]
		Music = unchecked(4),

		/// <summary>
		/// Image files that can be displayed using a standard viewer (png,<br/>
		/// jpg...). <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_FOLDER_PICTURES")]
		[NativeName(NativeNameType.Value, "5")]
		Pictures = unchecked(5),

		/// <summary>
		/// Files that are meant to be shared with other users on the same<br/>
		/// computer. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_FOLDER_PUBLICSHARE")]
		[NativeName(NativeNameType.Value, "6")]
		Publicshare = unchecked(6),

		/// <summary>
		/// Save files for games. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_FOLDER_SAVEDGAMES")]
		[NativeName(NativeNameType.Value, "7")]
		Savedgames = unchecked(7),

		/// <summary>
		/// Application screenshots. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_FOLDER_SCREENSHOTS")]
		[NativeName(NativeNameType.Value, "8")]
		Screenshots = unchecked(8),

		/// <summary>
		/// Template files to be used when the user requests the desktop environment<br/>
		/// to create a new file in a certain folder, such as "New Text File.txt".<br/>
		/// Any file in the Templates folder can be used as a starting point for a<br/>
		/// new file. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_FOLDER_TEMPLATES")]
		[NativeName(NativeNameType.Value, "9")]
		Templates = unchecked(9),

		/// <summary>
		/// Video files that can be played using a standard video player (mp4,<br/>
		/// webm...). <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_FOLDER_VIDEOS")]
		[NativeName(NativeNameType.Value, "10")]
		Videos = unchecked(10),

		/// <summary>
		/// total number of types in this enum, not a folder type by itself. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_FOLDER_TOTAL")]
		[NativeName(NativeNameType.Value, "11")]
		Total = unchecked(11),
	}
}