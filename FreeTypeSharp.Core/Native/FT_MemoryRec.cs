using System;
using System.Runtime.InteropServices;
using Chroma.FreeType;

namespace Chroma.FreeType.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FT_MemoryRec
    {
        public IntPtr user;
        public FT_Alloc_Func alloc;
        public FT_Free_Func free;
        public FT_Realloc_Func realloc;
    }
}