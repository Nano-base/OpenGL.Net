
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
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_PIXEL_TRANSFORM_2D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public const int PIXEL_TRANSFORM_2D_EXT = 0x8330;

		/// <summary>
		/// [GL] Value of GL_PIXEL_MAG_FILTER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public const int PIXEL_MAG_FILTER_EXT = 0x8331;

		/// <summary>
		/// [GL] Value of GL_PIXEL_MIN_FILTER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public const int PIXEL_MIN_FILTER_EXT = 0x8332;

		/// <summary>
		/// [GL] Value of GL_PIXEL_CUBIC_WEIGHT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public const int PIXEL_CUBIC_WEIGHT_EXT = 0x8333;

		/// <summary>
		/// [GL] Value of GL_CUBIC_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public const int CUBIC_EXT = 0x8334;

		/// <summary>
		/// [GL] Value of GL_AVERAGE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public const int AVERAGE_EXT = 0x8335;

		/// <summary>
		/// [GL] Value of GL_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public const int PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8336;

		/// <summary>
		/// [GL] Value of GL_MAX_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public const int MAX_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8337;

		/// <summary>
		/// [GL] Value of GL_PIXEL_TRANSFORM_2D_MATRIX_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public const int PIXEL_TRANSFORM_2D_MATRIX_EXT = 0x8338;

		/// <summary>
		/// [GL] glPixelTransformParameteriEXT: Binding for glPixelTransformParameteriEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public static void PixelTransformParameterEXT(int target, int pname, int param)
		{
			Debug.Assert(Delegates.pglPixelTransformParameteriEXT != null, "pglPixelTransformParameteriEXT not implemented");
			Delegates.pglPixelTransformParameteriEXT(target, pname, param);
			LogCommand("glPixelTransformParameteriEXT", null, target, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glPixelTransformParameterfEXT: Binding for glPixelTransformParameterfEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public static void PixelTransformParameterEXT(int target, int pname, float param)
		{
			Debug.Assert(Delegates.pglPixelTransformParameterfEXT != null, "pglPixelTransformParameterfEXT not implemented");
			Delegates.pglPixelTransformParameterfEXT(target, pname, param);
			LogCommand("glPixelTransformParameterfEXT", null, target, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glPixelTransformParameterivEXT: Binding for glPixelTransformParameterivEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public static void PixelTransformParameterEXT(int target, int pname, int[] @params)
		{
			Debug.Assert(@params.Length >= 1);
			unsafe {
				fixed (int* p_params = @params)
				{
					Debug.Assert(Delegates.pglPixelTransformParameterivEXT != null, "pglPixelTransformParameterivEXT not implemented");
					Delegates.pglPixelTransformParameterivEXT(target, pname, p_params);
					LogCommand("glPixelTransformParameterivEXT", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glPixelTransformParameterfvEXT: Binding for glPixelTransformParameterfvEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public static void PixelTransformParameterEXT(int target, int pname, float[] @params)
		{
			Debug.Assert(@params.Length >= 1);
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglPixelTransformParameterfvEXT != null, "pglPixelTransformParameterfvEXT not implemented");
					Delegates.pglPixelTransformParameterfvEXT(target, pname, p_params);
					LogCommand("glPixelTransformParameterfvEXT", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetPixelTransformParameterivEXT: Binding for glGetPixelTransformParameterivEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public static void GetPixelTransformParameterEXT(int target, int pname, [Out] int[] @params)
		{
			unsafe {
				fixed (int* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetPixelTransformParameterivEXT != null, "pglGetPixelTransformParameterivEXT not implemented");
					Delegates.pglGetPixelTransformParameterivEXT(target, pname, p_params);
					LogCommand("glGetPixelTransformParameterivEXT", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetPixelTransformParameterfvEXT: Binding for glGetPixelTransformParameterfvEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public static void GetPixelTransformParameterEXT(int target, int pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetPixelTransformParameterfvEXT != null, "pglGetPixelTransformParameterfvEXT not implemented");
					Delegates.pglGetPixelTransformParameterfvEXT(target, pname, p_params);
					LogCommand("glGetPixelTransformParameterfvEXT", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_pixel_transform")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelTransformParameteriEXT(int target, int pname, int param);

			[RequiredByFeature("GL_EXT_pixel_transform")]
			[ThreadStatic]
			internal static glPixelTransformParameteriEXT pglPixelTransformParameteriEXT;

			[RequiredByFeature("GL_EXT_pixel_transform")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelTransformParameterfEXT(int target, int pname, float param);

			[RequiredByFeature("GL_EXT_pixel_transform")]
			[ThreadStatic]
			internal static glPixelTransformParameterfEXT pglPixelTransformParameterfEXT;

			[RequiredByFeature("GL_EXT_pixel_transform")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelTransformParameterivEXT(int target, int pname, int* @params);

			[RequiredByFeature("GL_EXT_pixel_transform")]
			[ThreadStatic]
			internal static glPixelTransformParameterivEXT pglPixelTransformParameterivEXT;

			[RequiredByFeature("GL_EXT_pixel_transform")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelTransformParameterfvEXT(int target, int pname, float* @params);

			[RequiredByFeature("GL_EXT_pixel_transform")]
			[ThreadStatic]
			internal static glPixelTransformParameterfvEXT pglPixelTransformParameterfvEXT;

			[RequiredByFeature("GL_EXT_pixel_transform")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGetPixelTransformParameterivEXT(int target, int pname, int* @params);

			[RequiredByFeature("GL_EXT_pixel_transform")]
			[ThreadStatic]
			internal static glGetPixelTransformParameterivEXT pglGetPixelTransformParameterivEXT;

			[RequiredByFeature("GL_EXT_pixel_transform")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGetPixelTransformParameterfvEXT(int target, int pname, float* @params);

			[RequiredByFeature("GL_EXT_pixel_transform")]
			[ThreadStatic]
			internal static glGetPixelTransformParameterfvEXT pglGetPixelTransformParameterfvEXT;

		}
	}

}
