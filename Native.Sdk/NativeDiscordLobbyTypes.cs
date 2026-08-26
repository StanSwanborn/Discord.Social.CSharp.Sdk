using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordLinkedLobby
{
    internal nint Opaque0;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordLinkedChannel
{
    internal nint Opaque0;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordLobbyMemberHandle
{
    internal nint Opaque0;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordLobbyHandle
{
    internal nint Opaque0;
}
