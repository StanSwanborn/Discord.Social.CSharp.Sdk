using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordProperties
{
    internal nuint Size;
    internal nint Keys;
    internal nint Values;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordAllocator
{
    internal nint FnMalloc;
    internal nint FnFree;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordString
{
    internal nint Ptr;
    internal nuint Size;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordActivityButtonSpan
{
    internal nint Ptr;
    internal nuint Size;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordUInt64Span
{
    internal nint Ptr;
    internal nuint Size;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordUserApplicationProfileHandleSpan
{
    internal nint Ptr;
    internal nuint Size;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordLobbyMemberHandleSpan
{
    internal nint Ptr;
    internal nuint Size;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordCallSpan
{
    internal nint Ptr;
    internal nuint Size;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordAudioDeviceSpan
{
    internal nint Ptr;
    internal nuint Size;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordMessageHandleSpan
{
    internal nint Ptr;
    internal nuint Size;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordUserMessageSummarySpan
{
    internal nint Ptr;
    internal nuint Size;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordGuildChannelSpan
{
    internal nint Ptr;
    internal nuint Size;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordGuildMinimalSpan
{
    internal nint Ptr;
    internal nuint Size;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordRelationshipHandleSpan
{
    internal nint Ptr;
    internal nuint Size;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordUserHandleSpan
{
    internal nint Ptr;
    internal nuint Size;
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate nint DiscordMallocFn(nuint size);
