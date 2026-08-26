using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordVoiceStateHandle
{
    internal nint Opaque0;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordVADThresholdSettings
{
    internal nint Opaque0;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordCall
{
    internal nint Opaque0;
    internal nint Opaque1;
    internal nint Opaque2;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordCallInfoHandle
{
    internal nint Opaque0;
}
