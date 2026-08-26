using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

internal static class NativeDiscordClientLifecycleMethods
{
    private const string LibraryName = "discord_partner_sdk";

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_Init(
        ref DiscordClientNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_InitWithBases(
        ref DiscordClientNative self,
        DiscordString apiBase,
        DiscordString webBase);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_InitWithOptions(
        ref DiscordClientNative self,
        ref DiscordClientCreateOptions options);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_Drop(
        ref DiscordClientNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_ErrorToString(
        DiscordClientError type,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_Client_GetApplicationId(
        ref DiscordClientNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_GetCurrentUser(
        ref DiscordClientNative self,
        ref DiscordUserHandle returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_GetDefaultCommunicationScopes(
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_GetDefaultPresenceScopes(
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_GetVersionHash(
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int Discord_Client_GetVersionMajor(
        );

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int Discord_Client_GetVersionMinor(
        );

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int Discord_Client_GetVersionPatch(
        );

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetHttpRequestTimeout(
        ref DiscordClientNative self,
        int httpTimeoutInMilliseconds);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_StatusToString(
        DiscordClientStatus type,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_ThreadToString(
        DiscordClientThread type,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_EndCall(
        ref DiscordClientNative self,
        ulong channelId,
        DiscordClientEndCallCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_EndCalls(
        ref DiscordClientNative self,
        DiscordClientEndCallsCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Client_GetCall(
        ref DiscordClientNative self,
        ulong channelId,
        ref DiscordCall returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_GetCalls(
        ref DiscordClientNative self,
        ref DiscordCallSpan returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetAecDump(
        ref DiscordClientNative self,
        [MarshalAs(UnmanagedType.I1)] bool on);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetAutomaticGainControl(
        ref DiscordClientNative self,
        [MarshalAs(UnmanagedType.I1)] bool on);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetThreadPriority(
        ref DiscordClientNative self,
        DiscordClientThread thread,
        int priority);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Client_StartCall(
        ref DiscordClientNative self,
        ulong channelId,
        ref DiscordCall returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_CreateAuthorizationCodeVerifier(
        ref DiscordClientNative self,
        ref DiscordAuthorizationCodeVerifier returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_FetchCurrentUser(
        ref DiscordClientNative self,
        DiscordAuthorizationTokenType tokenType,
        DiscordString token,
        DiscordClientFetchCurrentUserCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetGameWindowPid(
        ref DiscordClientNative self,
        int pid);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Client_GetChannelHandle(
        ref DiscordClientNative self,
        ulong channelId,
        ref DiscordChannelHandle returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_AddLogCallback(
        ref DiscordClientNative self,
        DiscordClientLogCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData,
        DiscordLoggingSeverity minSeverity);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_Connect(
        ref DiscordClientNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_Disconnect(
        ref DiscordClientNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern DiscordClientStatus Discord_Client_GetStatus(
        ref DiscordClientNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_OpenConnectedGamesSettingsInDiscord(
        ref DiscordClientNative self,
        DiscordClientOpenConnectedGamesSettingsInDiscordCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetApplicationId(
        ref DiscordClientNative self,
        ulong applicationId);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Client_SetLogDir(
        ref DiscordClientNative self,
        DiscordString path,
        DiscordLoggingSeverity minSeverity);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetStatusChangedCallback(
        ref DiscordClientNative self,
        DiscordClientOnStatusChanged cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_GetUserGuilds(
        ref DiscordClientNative self,
        DiscordClientGetUserGuildsCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_IsDiscordAppInstalled(
        ref DiscordClientNative self,
        DiscordClientIsDiscordAppInstalledCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Client_GetCurrentUserV2(
        ref DiscordClientNative self,
        ref DiscordUserHandle returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_GetDiscordClientConnectedUser(
        ref DiscordClientNative self,
        ulong applicationId,
        DiscordClientGetDiscordClientConnectedUserCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Client_GetUser(
        ref DiscordClientNative self,
        ulong userId,
        ref DiscordUserHandle returnValue);

}
