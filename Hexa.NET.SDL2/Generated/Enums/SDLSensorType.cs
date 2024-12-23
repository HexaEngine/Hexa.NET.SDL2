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

namespace Hexa.NET.SDL2
{
	/// <summary>
	/// The different sensors defined by SDL<br/>
	/// Additional sensors may be available, using platform dependent semantics.<br/>
	/// Hare are the additional Android sensors:<br/>
	/// https://developer.android.com/reference/android/hardware/SensorEvent.html#values<br/>
	/// </summary>
	[Flags]
	public enum SDLSensorType : int
	{
		/// <summary>
		/// Returned for an invalid sensor <br/>
		/// </summary>
		Invalid = unchecked(-1),

		/// <summary>
		/// Unknown sensor type <br/>
		/// </summary>
		Unknown = unchecked(0),

		/// <summary>
		/// Accelerometer <br/>
		/// </summary>
		Accel = unchecked(1),

		/// <summary>
		/// Gyroscope <br/>
		/// </summary>
		Gyro = unchecked(2),

		/// <summary>
		/// Accelerometer for left Joy-Con controller and Wii nunchuk <br/>
		/// </summary>
		AccelL = unchecked(3),

		/// <summary>
		/// Gyroscope for left Joy-Con controller <br/>
		/// </summary>
		GyroL = unchecked(4),

		/// <summary>
		/// Accelerometer for right Joy-Con controller <br/>
		/// </summary>
		AccelR = unchecked(5),

		/// <summary>
		/// Gyroscope for right Joy-Con controller <br/>
		/// </summary>
		GyroR = unchecked(6),
	}
}
