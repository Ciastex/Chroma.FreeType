using System;
using System.Runtime.InteropServices;

namespace Chroma.FreeType.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FT_Matrix
    {
        public IntPtr xx, xy;
        public IntPtr yx, yy;
    }
}
