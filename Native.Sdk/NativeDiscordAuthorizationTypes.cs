using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordAuthorizationCodeChallenge
{
    internal nint Opaque0;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordAuthorizationCodeVerifier
{
    internal nint Opaque0;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordAuthorizationArgs
{
    internal nint Opaque0;
}

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordDeviceAuthorizationArgs
{
    internal nint Opaque0;
}
