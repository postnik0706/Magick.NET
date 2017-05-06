//=================================================================================================
// Copyright 2013-2017 Dirk Lemstra <https://magick.codeplex.com/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================
// <auto-generated/>

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#if Q8
using QuantumType = System.Byte;
#elif Q16
using QuantumType = System.UInt16;
#elif Q16HDRI
using QuantumType = System.Single;
#else
#error Not implemented!
#endif

namespace ImageMagick
{
  public partial class PerceptualHash
  {
    private static class NativeMethods
    {
      #if WIN64 || ANYCPU
      public static class X64
      {
        #if ANYCPU
        [SuppressMessage("Microsoft.Performance", "CA1810: InitializeReferenceTypeStaticFieldsInline", Scope = "member", Target = "ImageMagick.PerceptualHash+NativeMethods.X64#.cctor()")]
        static X64() { NativeLibraryLoader.Load(); }
        #endif
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PerceptualHash_DisposeList(IntPtr list);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr PerceptualHash_GetInstance(IntPtr image, IntPtr list, UIntPtr channel);
      }
      #endif
      #if !WIN64 || ANYCPU
      public static class X86
      {
        #if ANYCPU
        [SuppressMessage("Microsoft.Performance", "CA1810: InitializeReferenceTypeStaticFieldsInline", Scope = "member", Target = "ImageMagick.PerceptualHash+NativeMethods.X86#.cctor()")]
        static X86() { NativeLibraryLoader.Load(); }
        #endif
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PerceptualHash_DisposeList(IntPtr list);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr PerceptualHash_GetInstance(IntPtr image, IntPtr list, UIntPtr channel);
      }
      #endif
    }
    private static class NativePerceptualHash
    {
      public static void DisposeList(IntPtr list)
      {
        #if ANYCPU
        if (NativeLibrary.Is64Bit)
        #endif
        #if WIN64 || ANYCPU
        NativeMethods.X64.PerceptualHash_DisposeList(list);
        #endif
        #if ANYCPU
        else
        #endif
        #if !WIN64 || ANYCPU
        NativeMethods.X86.PerceptualHash_DisposeList(list);
        #endif
      }
      public static IntPtr GetInstance(IMagickImage image, IntPtr list, PixelChannel channel)
      {
        #if ANYCPU
        if (NativeLibrary.Is64Bit)
        #endif
        #if WIN64 || ANYCPU
        return NativeMethods.X64.PerceptualHash_GetInstance(image.GetInstance(), list, (UIntPtr)channel);
        #endif
        #if ANYCPU
        else
        #endif
        #if !WIN64 || ANYCPU
        return NativeMethods.X86.PerceptualHash_GetInstance(image.GetInstance(), list, (UIntPtr)channel);
        #endif
      }
    }
  }
}
