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
	/// Holds information about a test suite (multiple test cases).<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLTestTestSuiteReference
	{
		/// <summary>
		/// !<br/>
		/// <<br/>
		/// "PlatformSuite" <br/>
		/// </summary>
		public unsafe byte* Name;

		/// <summary>
		/// !<br/>
		/// <<br/>
		/// The function that is run before each test. NULL skips. <br/>
		/// </summary>
		public unsafe void* TestSetUp;
		/// <summary>
		/// !<br/>
		/// <<br/>
		/// The test cases that are run as part of the suite. Last item should be NULL. <br/>
		/// </summary>
		public unsafe SDLTestTestCaseReference** TestCases;

		/// <summary>
		/// !<br/>
		/// <<br/>
		/// The function that is run after each test. NULL skips. <br/>
		/// </summary>
		public unsafe void* TestTearDown;

		public unsafe SDLTestTestSuiteReference(byte* name = default, SDLTestTestCaseSetUpFp testSetUp = default, SDLTestTestCaseReference** testCases = default, SDLTestTestCaseTearDownFp testTearDown = default)
		{
			Name = name;
			TestSetUp = (delegate*<void*, void>)Marshal.GetFunctionPointerForDelegate(testSetUp);
			TestCases = testCases;
			TestTearDown = (delegate*<void*, void>)Marshal.GetFunctionPointerForDelegate(testTearDown);
		}


	}

}
