﻿using System;
using System.Runtime.InteropServices;
using LibHac.Common;

namespace LibHac.Fs.Impl;

[StructLayout(LayoutKind.Sequential, Size = 0x20)]
public struct InitialDataAad
{
    public byte this[int i]
    {
        readonly get => BytesRo[i];
        set => Bytes[i] = value;
    }

    public Span<byte> Bytes => SpanHelpers.AsByteSpan(ref this);
    public readonly ReadOnlySpan<byte> BytesRo => SpanHelpers.AsReadOnlyByteSpan(in this);
}

[StructLayout(LayoutKind.Sequential, Size = 0x10)]
public struct KeySeed
{
    public byte this[int i]
    {
        readonly get => BytesRo[i];
        set => Bytes[i] = value;
    }

    public Span<byte> Bytes => SpanHelpers.AsByteSpan(ref this);
    public readonly ReadOnlySpan<byte> BytesRo => SpanHelpers.AsReadOnlyByteSpan(in this);
}

[StructLayout(LayoutKind.Sequential, Size = 0x10)]
public struct InitialDataMac
{
    public byte this[int i]
    {
        readonly get => BytesRo[i];
        set => Bytes[i] = value;
    }

    public Span<byte> Bytes => SpanHelpers.AsByteSpan(ref this);
    public readonly ReadOnlySpan<byte> BytesRo => SpanHelpers.AsReadOnlyByteSpan(in this);
}

[StructLayout(LayoutKind.Sequential, Size = 0x20)]
public struct ImportReportInfo
{
    public byte DiffChunkCount;
    public byte DoubleDivisionDiffChunkCount;
    public byte HalfDivisionDiffChunkCount;
    public byte CompressionRate;
}
