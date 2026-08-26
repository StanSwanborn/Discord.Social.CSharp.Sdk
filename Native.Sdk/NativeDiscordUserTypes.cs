using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordUserApplicationProfileHandle
{
    internal nint Opaque0;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordUserHandle
{
    internal nint Opaque0;
}
