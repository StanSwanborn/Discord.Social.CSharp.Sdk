using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordAdditionalContent
{
    internal nint Opaque0;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordMessageHandle
{
    internal nint Opaque0;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordUserMessageSummary
{
    internal nint Opaque0;
}
