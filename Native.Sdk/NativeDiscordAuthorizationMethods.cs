using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

internal static class NativeDiscordAuthorizationMethods
{
    private const string LibraryName = "discord_partner_sdk";

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AuthorizationCodeChallenge_Init(
        ref DiscordAuthorizationCodeChallenge self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AuthorizationCodeChallenge_Drop(
        ref DiscordAuthorizationCodeChallenge self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AuthorizationCodeChallenge_Clone(
        ref DiscordAuthorizationCodeChallenge self,
        ref DiscordAuthorizationCodeChallenge arg0);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AuthorizationCodeChallenge_SetMethod(
        ref DiscordAuthorizationCodeChallenge self,
        DiscordAuthenticationCodeChallengeMethod value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern DiscordAuthenticationCodeChallengeMethod Discord_AuthorizationCodeChallenge_Method(
        ref DiscordAuthorizationCodeChallenge self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AuthorizationCodeChallenge_SetChallenge(
        ref DiscordAuthorizationCodeChallenge self,
        DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AuthorizationCodeChallenge_Challenge(
        ref DiscordAuthorizationCodeChallenge self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AuthorizationCodeVerifier_Drop(
        ref DiscordAuthorizationCodeVerifier self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AuthorizationCodeVerifier_Clone(
        ref DiscordAuthorizationCodeVerifier self,
        ref DiscordAuthorizationCodeVerifier arg0);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AuthorizationCodeVerifier_SetChallenge(
        ref DiscordAuthorizationCodeVerifier self,
        ref DiscordAuthorizationCodeChallenge value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AuthorizationCodeVerifier_Challenge(
        ref DiscordAuthorizationCodeVerifier self,
        ref DiscordAuthorizationCodeChallenge returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AuthorizationCodeVerifier_SetVerifier(
        ref DiscordAuthorizationCodeVerifier self,
        DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AuthorizationCodeVerifier_Verifier(
        ref DiscordAuthorizationCodeVerifier self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AuthorizationArgs_Init(
        ref DiscordAuthorizationArgs self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AuthorizationArgs_Drop(
        ref DiscordAuthorizationArgs self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AuthorizationArgs_Clone(
        ref DiscordAuthorizationArgs self,
        ref DiscordAuthorizationArgs arg0);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AuthorizationArgs_SetClientId(
        ref DiscordAuthorizationArgs self,
        ulong value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_AuthorizationArgs_ClientId(
        ref DiscordAuthorizationArgs self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AuthorizationArgs_SetScopes(
        ref DiscordAuthorizationArgs self,
        DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AuthorizationArgs_Scopes(
        ref DiscordAuthorizationArgs self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AuthorizationArgs_SetState(
        ref DiscordAuthorizationArgs self,
        ref DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_AuthorizationArgs_State(
        ref DiscordAuthorizationArgs self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AuthorizationArgs_SetNonce(
        ref DiscordAuthorizationArgs self,
        ref DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_AuthorizationArgs_Nonce(
        ref DiscordAuthorizationArgs self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AuthorizationArgs_SetCodeChallenge(
        ref DiscordAuthorizationArgs self,
        ref DiscordAuthorizationCodeChallenge value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_AuthorizationArgs_CodeChallenge(
        ref DiscordAuthorizationArgs self,
        ref DiscordAuthorizationCodeChallenge returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AuthorizationArgs_SetIntegrationType(
        ref DiscordAuthorizationArgs self,
        ref DiscordIntegrationType value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_AuthorizationArgs_IntegrationType(
        ref DiscordAuthorizationArgs self,
        ref DiscordIntegrationType returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AuthorizationArgs_SetCustomSchemeParam(
        ref DiscordAuthorizationArgs self,
        ref DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_AuthorizationArgs_CustomSchemeParam(
        ref DiscordAuthorizationArgs self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_DeviceAuthorizationArgs_Init(
        ref DiscordDeviceAuthorizationArgs self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_DeviceAuthorizationArgs_Drop(
        ref DiscordDeviceAuthorizationArgs self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_DeviceAuthorizationArgs_Clone(
        ref DiscordDeviceAuthorizationArgs self,
        ref DiscordDeviceAuthorizationArgs arg0);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_DeviceAuthorizationArgs_SetClientId(
        ref DiscordDeviceAuthorizationArgs self,
        ulong value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_DeviceAuthorizationArgs_ClientId(
        ref DiscordDeviceAuthorizationArgs self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_DeviceAuthorizationArgs_SetScopes(
        ref DiscordDeviceAuthorizationArgs self,
        DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_DeviceAuthorizationArgs_Scopes(
        ref DiscordDeviceAuthorizationArgs self,
        ref DiscordString returnValue);

}
