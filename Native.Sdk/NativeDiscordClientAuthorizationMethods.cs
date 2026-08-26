using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

internal static class NativeDiscordClientAuthorizationMethods
{
    private const string LibraryName = "discord_partner_sdk";

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_AbortAuthorize(
        ref DiscordClientNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_Authorize(
        ref DiscordClientNative self,
        ref DiscordAuthorizationArgs args,
        DiscordClientAuthorizationCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_ExchangeChildToken(
        ref DiscordClientNative self,
        DiscordString parentApplicationToken,
        ulong childApplicationId,
        DiscordClientExchangeChildTokenCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    internal static void Discord_Client_GetDefaultPresenceScopes(ref DiscordString value)
    {
        throw new NotImplementedException();
    }

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_GetProvisionalToken(
        ref DiscordClientNative self,
        ulong applicationId,
        DiscordAuthenticationExternalAuthType externalAuthType,
        DiscordString externalAuthToken,
        DiscordClientTokenExchangeCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_GetToken(
        ref DiscordClientNative self,
        ulong applicationId,
        DiscordString code,
        DiscordString codeVerifier,
        DiscordString redirectUri,
        DiscordClientTokenExchangeCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_GetTokenFromProvisionalMerge(
        ref DiscordClientNative self,
        ulong applicationId,
        DiscordString code,
        DiscordString codeVerifier,
        DiscordString redirectUri,
        DiscordAuthenticationExternalAuthType externalAuthType,
        DiscordString externalAuthToken,
        DiscordClientTokenExchangeCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Client_IsAuthenticated(
        ref DiscordClientNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_ProvisionalUserMergeCompleted(
        ref DiscordClientNative self,
        [MarshalAs(UnmanagedType.I1)] bool success);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_RefreshToken(
        ref DiscordClientNative self,
        ulong applicationId,
        DiscordString refreshToken,
        DiscordClientTokenExchangeCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_RegisterAuthorizeRequestCallback(
        ref DiscordClientNative self,
        DiscordClientAuthorizeRequestCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_RemoveAuthorizeRequestCallback(
        ref DiscordClientNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_RevokeToken(
        ref DiscordClientNative self,
        ulong applicationId,
        DiscordString token,
        DiscordClientRevokeTokenCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetTokenExpirationCallback(
        ref DiscordClientNative self,
        DiscordClientTokenExpirationCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_UnmergeIntoProvisionalAccount(
        ref DiscordClientNative self,
        ulong applicationId,
        DiscordAuthenticationExternalAuthType externalAuthType,
        DiscordString externalAuthToken,
        DiscordClientUnmergeIntoProvisionalAccountCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_UpdateProvisionalAccountDisplayName(
        ref DiscordClientNative self,
        DiscordString name,
        DiscordClientUpdateProvisionalAccountDisplayNameCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_UpdateToken(
        ref DiscordClientNative self,
        DiscordAuthorizationTokenType tokenType,
        DiscordString token,
        DiscordClientUpdateTokenCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

}
