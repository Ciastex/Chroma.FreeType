using System;
using System.Runtime.InteropServices;
using FT_Pos = System.IntPtr;

namespace Chroma.FreeType.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FT_Outline_Funcs
    {
        public FT_Pos moveTo;
        public FT_Pos lineTo;
        public FT_Pos conicTo;
        public FT_Pos cubicTo;
        public int shift;
        public FT_Pos delta;
    }
}