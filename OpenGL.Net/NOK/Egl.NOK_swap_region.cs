
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
		/// [EGL] eglSwapBuffersRegionNOK: Binding for eglSwapBuffersRegionNOK.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="surface">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="numRects">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="rects">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_NOK_swap_region")]
		public static bool SwapBuffersRegionNOK(IntPtr dpy, IntPtr surface, int numRects, int[] rects)
		{
			bool retValue;

			unsafe {
				fixed (int* p_rects = rects)
				{
					Debug.Assert(Delegates.peglSwapBuffersRegionNOK != null, "peglSwapBuffersRegionNOK not implemented");
					retValue = Delegates.peglSwapBuffersRegionNOK(dpy, surface, numRects, p_rects);
					LogCommand("eglSwapBuffersRegionNOK", retValue, dpy, surface, numRects, rects					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_NOK_swap_region")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool eglSwapBuffersRegionNOK(IntPtr dpy, IntPtr surface, int numRects, int* rects);

			[RequiredByFeature("EGL_NOK_swap_region")]
			internal static eglSwapBuffersRegionNOK peglSwapBuffersRegionNOK;

		}
	}

}
