
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
	public partial class Egl
	{
		/// <summary>
		/// [EGL] eglGetPlatformDisplayEXT: Binding for eglGetPlatformDisplayEXT.
		/// </summary>
		/// <param name="platform">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="native_display">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_platform_base")]
		public static IntPtr GetPlatformDisplayEXT(uint platform, IntPtr native_display, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglGetPlatformDisplayEXT != null, "peglGetPlatformDisplayEXT not implemented");
					retValue = Delegates.peglGetPlatformDisplayEXT(platform, native_display, p_attrib_list);
					LogCommand("eglGetPlatformDisplayEXT", retValue, platform, native_display, attrib_list					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglCreatePlatformWindowSurfaceEXT: Binding for eglCreatePlatformWindowSurfaceEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="native_window">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_platform_base")]
		public static IntPtr CreatePlatformWindowSurfaceEXT(IntPtr dpy, IntPtr config, IntPtr native_window, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreatePlatformWindowSurfaceEXT != null, "peglCreatePlatformWindowSurfaceEXT not implemented");
					retValue = Delegates.peglCreatePlatformWindowSurfaceEXT(dpy, config, native_window, p_attrib_list);
					LogCommand("eglCreatePlatformWindowSurfaceEXT", retValue, dpy, config, native_window, attrib_list					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglCreatePlatformPixmapSurfaceEXT: Binding for eglCreatePlatformPixmapSurfaceEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="native_pixmap">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_platform_base")]
		public static IntPtr CreatePlatformPixmapSurfaceEXT(IntPtr dpy, IntPtr config, IntPtr native_pixmap, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreatePlatformPixmapSurfaceEXT != null, "peglCreatePlatformPixmapSurfaceEXT not implemented");
					retValue = Delegates.peglCreatePlatformPixmapSurfaceEXT(dpy, config, native_pixmap, p_attrib_list);
					LogCommand("eglCreatePlatformPixmapSurfaceEXT", retValue, dpy, config, native_pixmap, attrib_list					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_EXT_platform_base")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr eglGetPlatformDisplayEXT(uint platform, IntPtr native_display, int* attrib_list);

			[RequiredByFeature("EGL_EXT_platform_base")]
			internal static eglGetPlatformDisplayEXT peglGetPlatformDisplayEXT;

			[RequiredByFeature("EGL_EXT_platform_base")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr eglCreatePlatformWindowSurfaceEXT(IntPtr dpy, IntPtr config, IntPtr native_window, int* attrib_list);

			[RequiredByFeature("EGL_EXT_platform_base")]
			internal static eglCreatePlatformWindowSurfaceEXT peglCreatePlatformWindowSurfaceEXT;

			[RequiredByFeature("EGL_EXT_platform_base")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr eglCreatePlatformPixmapSurfaceEXT(IntPtr dpy, IntPtr config, IntPtr native_pixmap, int* attrib_list);

			[RequiredByFeature("EGL_EXT_platform_base")]
			internal static eglCreatePlatformPixmapSurfaceEXT peglCreatePlatformPixmapSurfaceEXT;

		}
	}

}
