
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
		/// [GL] Value of GL_MAX_FRAGMENT_PROGRAM_LOCAL_PARAMETERS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_fragment_program")]
		public const int MAX_FRAGMENT_PROGRAM_LOCAL_PARAMETERS_NV = 0x8868;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_PROGRAM_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_fragment_program")]
		public const int FRAGMENT_PROGRAM_NV = 0x8870;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_PROGRAM_BINDING_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_fragment_program")]
		public const int FRAGMENT_PROGRAM_BINDING_NV = 0x8873;

		/// <summary>
		/// [GL] glProgramNamedParameter4fNV: Binding for glProgramNamedParameter4fNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="len">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fragment_program")]
		public static void ProgramNamedParameter4NV(uint id, int len, byte[] name, float x, float y, float z, float w)
		{
			Debug.Assert(name.Length >= 1);
			unsafe {
				fixed (byte* p_name = name)
				{
					Debug.Assert(Delegates.pglProgramNamedParameter4fNV != null, "pglProgramNamedParameter4fNV not implemented");
					Delegates.pglProgramNamedParameter4fNV(id, len, p_name, x, y, z, w);
					LogCommand("glProgramNamedParameter4fNV", null, id, len, name, x, y, z, w					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glProgramNamedParameter4fvNV: Binding for glProgramNamedParameter4fvNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="len">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fragment_program")]
		public static void ProgramNamedParameter4NV(uint id, int len, byte[] name, float[] v)
		{
			Debug.Assert(name.Length >= 1);
			Debug.Assert(v.Length >= 4);
			unsafe {
				fixed (byte* p_name = name)
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglProgramNamedParameter4fvNV != null, "pglProgramNamedParameter4fvNV not implemented");
					Delegates.pglProgramNamedParameter4fvNV(id, len, p_name, p_v);
					LogCommand("glProgramNamedParameter4fvNV", null, id, len, name, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glProgramNamedParameter4dNV: Binding for glProgramNamedParameter4dNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="len">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fragment_program")]
		public static void ProgramNamedParameter4NV(uint id, int len, byte[] name, double x, double y, double z, double w)
		{
			Debug.Assert(name.Length >= 1);
			unsafe {
				fixed (byte* p_name = name)
				{
					Debug.Assert(Delegates.pglProgramNamedParameter4dNV != null, "pglProgramNamedParameter4dNV not implemented");
					Delegates.pglProgramNamedParameter4dNV(id, len, p_name, x, y, z, w);
					LogCommand("glProgramNamedParameter4dNV", null, id, len, name, x, y, z, w					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glProgramNamedParameter4dvNV: Binding for glProgramNamedParameter4dvNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="len">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fragment_program")]
		public static void ProgramNamedParameter4NV(uint id, int len, byte[] name, double[] v)
		{
			Debug.Assert(name.Length >= 1);
			Debug.Assert(v.Length >= 4);
			unsafe {
				fixed (byte* p_name = name)
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglProgramNamedParameter4dvNV != null, "pglProgramNamedParameter4dvNV not implemented");
					Delegates.pglProgramNamedParameter4dvNV(id, len, p_name, p_v);
					LogCommand("glProgramNamedParameter4dvNV", null, id, len, name, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetProgramNamedParameterfvNV: Binding for glGetProgramNamedParameterfvNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="len">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fragment_program")]
		public static void GetProgramNamedParameterNV(uint id, int len, byte[] name, [Out] float[] @params)
		{
			Debug.Assert(name.Length >= 1);
			Debug.Assert(@params.Length >= 4);
			unsafe {
				fixed (byte* p_name = name)
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramNamedParameterfvNV != null, "pglGetProgramNamedParameterfvNV not implemented");
					Delegates.pglGetProgramNamedParameterfvNV(id, len, p_name, p_params);
					LogCommand("glGetProgramNamedParameterfvNV", null, id, len, name, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetProgramNamedParameterdvNV: Binding for glGetProgramNamedParameterdvNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="len">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fragment_program")]
		public static void GetProgramNamedParameterNV(uint id, int len, byte[] name, [Out] double[] @params)
		{
			Debug.Assert(name.Length >= 1);
			Debug.Assert(@params.Length >= 4);
			unsafe {
				fixed (byte* p_name = name)
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramNamedParameterdvNV != null, "pglGetProgramNamedParameterdvNV not implemented");
					Delegates.pglGetProgramNamedParameterdvNV(id, len, p_name, p_params);
					LogCommand("glGetProgramNamedParameterdvNV", null, id, len, name, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_fragment_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramNamedParameter4fNV(uint id, int len, byte* name, float x, float y, float z, float w);

			[RequiredByFeature("GL_NV_fragment_program")]
			[ThreadStatic]
			internal static glProgramNamedParameter4fNV pglProgramNamedParameter4fNV;

			[RequiredByFeature("GL_NV_fragment_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramNamedParameter4fvNV(uint id, int len, byte* name, float* v);

			[RequiredByFeature("GL_NV_fragment_program")]
			[ThreadStatic]
			internal static glProgramNamedParameter4fvNV pglProgramNamedParameter4fvNV;

			[RequiredByFeature("GL_NV_fragment_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramNamedParameter4dNV(uint id, int len, byte* name, double x, double y, double z, double w);

			[RequiredByFeature("GL_NV_fragment_program")]
			[ThreadStatic]
			internal static glProgramNamedParameter4dNV pglProgramNamedParameter4dNV;

			[RequiredByFeature("GL_NV_fragment_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramNamedParameter4dvNV(uint id, int len, byte* name, double* v);

			[RequiredByFeature("GL_NV_fragment_program")]
			[ThreadStatic]
			internal static glProgramNamedParameter4dvNV pglProgramNamedParameter4dvNV;

			[RequiredByFeature("GL_NV_fragment_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGetProgramNamedParameterfvNV(uint id, int len, byte* name, float* @params);

			[RequiredByFeature("GL_NV_fragment_program")]
			[ThreadStatic]
			internal static glGetProgramNamedParameterfvNV pglGetProgramNamedParameterfvNV;

			[RequiredByFeature("GL_NV_fragment_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGetProgramNamedParameterdvNV(uint id, int len, byte* name, double* @params);

			[RequiredByFeature("GL_NV_fragment_program")]
			[ThreadStatic]
			internal static glGetProgramNamedParameterdvNV pglGetProgramNamedParameterdvNV;

		}
	}

}
