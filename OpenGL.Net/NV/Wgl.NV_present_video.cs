
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using Khronos;

namespace OpenGL
{
	public partial class Wgl
	{
		/// <summary>
		/// [WGL] Value of WGL_NUM_VIDEO_SLOTS_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_present_video")]
		public const int NUM_VIDEO_SLOTS_NV = 0x20F0;

		/// <summary>
		/// [WGL] wglEnumerateVideoDevicesNV: Binding for wglEnumerateVideoDevicesNV.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="phDeviceList">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_present_video")]
		public static int EnumerateVideoDevicesNV(IntPtr hDC, IntPtr[] phDeviceList)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_phDeviceList = phDeviceList)
				{
					Debug.Assert(Delegates.pwglEnumerateVideoDevicesNV != null, "pwglEnumerateVideoDevicesNV not implemented");
					retValue = Delegates.pwglEnumerateVideoDevicesNV(hDC, p_phDeviceList);
					LogCommand("wglEnumerateVideoDevicesNV", retValue, hDC, phDeviceList					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglBindVideoDeviceNV: Binding for wglBindVideoDeviceNV.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="uVideoSlot">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="hVideoDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="piAttribList">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_present_video")]
		public static bool BindVideoDeviceNV(IntPtr hDC, uint uVideoSlot, IntPtr hVideoDevice, int[] piAttribList)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piAttribList = piAttribList)
				{
					Debug.Assert(Delegates.pwglBindVideoDeviceNV != null, "pwglBindVideoDeviceNV not implemented");
					retValue = Delegates.pwglBindVideoDeviceNV(hDC, uVideoSlot, hVideoDevice, p_piAttribList);
					LogCommand("wglBindVideoDeviceNV", retValue, hDC, uVideoSlot, hVideoDevice, piAttribList					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglQueryCurrentContextNV: Binding for wglQueryCurrentContextNV.
		/// </summary>
		/// <param name="iAttribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="piValue">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_present_video")]
		public static bool QueryCurrentContextNV(int iAttribute, int[] piValue)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piValue = piValue)
				{
					Debug.Assert(Delegates.pwglQueryCurrentContextNV != null, "pwglQueryCurrentContextNV not implemented");
					retValue = Delegates.pwglQueryCurrentContextNV(iAttribute, p_piValue);
					LogCommand("wglQueryCurrentContextNV", retValue, iAttribute, piValue					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_NV_present_video")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate int wglEnumerateVideoDevicesNV(IntPtr hDC, IntPtr* phDeviceList);

			[RequiredByFeature("WGL_NV_present_video")]
			internal static wglEnumerateVideoDevicesNV pwglEnumerateVideoDevicesNV;

			[RequiredByFeature("WGL_NV_present_video")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool wglBindVideoDeviceNV(IntPtr hDC, uint uVideoSlot, IntPtr hVideoDevice, int* piAttribList);

			[RequiredByFeature("WGL_NV_present_video")]
			internal static wglBindVideoDeviceNV pwglBindVideoDeviceNV;

			[RequiredByFeature("WGL_NV_present_video")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool wglQueryCurrentContextNV(int iAttribute, int* piValue);

			[RequiredByFeature("WGL_NV_present_video")]
			internal static wglQueryCurrentContextNV pwglQueryCurrentContextNV;

		}
	}

}
