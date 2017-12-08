
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
		/// [GL] Value of GL_FOVEATION_ENABLE_BIT_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_framebuffer_foveated", Api = "gles2")]
		[Log(BitmaskName = "GL")]
		public const uint FOVEATION_ENABLE_BIT_QCOM = 0x00000001;

		/// <summary>
		/// [GL] Value of GL_FOVEATION_SCALED_BIN_METHOD_BIT_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_framebuffer_foveated", Api = "gles2")]
		[Log(BitmaskName = "GL")]
		public const uint FOVEATION_SCALED_BIN_METHOD_BIT_QCOM = 0x00000002;

		/// <summary>
		/// [GL] glFramebufferFoveationConfigQCOM: Binding for glFramebufferFoveationConfigQCOM.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="numLayers">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="focalPointsPerLayer">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="requestedFeatures">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="providedFeatures">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_framebuffer_foveated", Api = "gles2")]
		public static void FramebufferFoveationQCOM(uint framebuffer, uint numLayers, uint focalPointsPerLayer, uint requestedFeatures, uint[] providedFeatures)
		{
			Debug.Assert(providedFeatures.Length >= 1);
			unsafe {
				fixed (uint* p_providedFeatures = providedFeatures)
				{
					Debug.Assert(Delegates.pglFramebufferFoveationConfigQCOM != null, "pglFramebufferFoveationConfigQCOM not implemented");
					Delegates.pglFramebufferFoveationConfigQCOM(framebuffer, numLayers, focalPointsPerLayer, requestedFeatures, p_providedFeatures);
					LogCommand("glFramebufferFoveationConfigQCOM", null, framebuffer, numLayers, focalPointsPerLayer, requestedFeatures, providedFeatures					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glFramebufferFoveationParametersQCOM: Binding for glFramebufferFoveationParametersQCOM.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="layer">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="focalPoint">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="focalX">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="focalY">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="gainX">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="gainY">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="foveaArea">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_framebuffer_foveated", Api = "gles2")]
		public static void FramebufferFoveationParametersQCOM(uint framebuffer, uint layer, uint focalPoint, float focalX, float focalY, float gainX, float gainY, float foveaArea)
		{
			Debug.Assert(Delegates.pglFramebufferFoveationParametersQCOM != null, "pglFramebufferFoveationParametersQCOM not implemented");
			Delegates.pglFramebufferFoveationParametersQCOM(framebuffer, layer, focalPoint, focalX, focalY, gainX, gainY, foveaArea);
			LogCommand("glFramebufferFoveationParametersQCOM", null, framebuffer, layer, focalPoint, focalX, focalY, gainX, gainY, foveaArea			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_QCOM_framebuffer_foveated", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferFoveationConfigQCOM(uint framebuffer, uint numLayers, uint focalPointsPerLayer, uint requestedFeatures, uint* providedFeatures);

			[RequiredByFeature("GL_QCOM_framebuffer_foveated", Api = "gles2")]
			[ThreadStatic]
			internal static glFramebufferFoveationConfigQCOM pglFramebufferFoveationConfigQCOM;

			[RequiredByFeature("GL_QCOM_framebuffer_foveated", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferFoveationParametersQCOM(uint framebuffer, uint layer, uint focalPoint, float focalX, float focalY, float gainX, float gainY, float foveaArea);

			[RequiredByFeature("GL_QCOM_framebuffer_foveated", Api = "gles2")]
			[ThreadStatic]
			internal static glFramebufferFoveationParametersQCOM pglFramebufferFoveationParametersQCOM;

		}
	}

}
