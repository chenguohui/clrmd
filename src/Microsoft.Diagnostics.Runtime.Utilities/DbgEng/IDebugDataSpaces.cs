﻿namespace Microsoft.Diagnostics.Runtime.Utilities.DbgEng
{
    public interface IDebugDataSpaces
    {
        bool ReadVirtual(ulong address, Span<byte> buffer, out int read);
        bool Search(ulong offset, ulong length, Span<byte> pattern, int granularity, out ulong offsetFound);
    }
}
