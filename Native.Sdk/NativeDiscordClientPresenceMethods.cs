using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

internal static class NativeDiscordClientPresenceMethods
{
    private const string LibraryName = "discord_partner_sdk";

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_AcceptActivityInvite(
        ref DiscordClientNative self,
        ref DiscordActivityInvite invite,
        DiscordClientAcceptActivityInviteCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_ClearRichPresence(
        ref DiscordClientNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Client_RegisterLaunchCommand(
        ref DiscordClientNative self,
        ulong applicationId,
        DiscordString command);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Client_RegisterLaunchSteamApplication(
        ref DiscordClientNative self,
        ulong applicationId,
        uint steamAppId);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SendActivityInvite(
        ref DiscordClientNative self,
        ulong userId,
        DiscordString content,
        DiscordClientSendActivityInviteCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SendActivityJoinRequest(
        ref DiscordClientNative self,
        ulong userId,
        DiscordClientSendActivityInviteCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SendActivityJoinRequestReply(
        ref DiscordClientNative self,
        ref DiscordActivityInvite invite,
        DiscordClientSendActivityInviteCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetActivityInviteCreatedCallback(
        ref DiscordClientNative self,
        DiscordClientActivityInviteCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetActivityInviteUpdatedCallback(
        ref DiscordClientNative self,
        DiscordClientActivityInviteCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetActivityJoinCallback(
        ref DiscordClientNative self,
        DiscordClientActivityJoinCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetActivityJoinWithApplicationCallback(
        ref DiscordClientNative self,
        DiscordClientActivityJoinWithApplicationCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetOnlineStatus(
        ref DiscordClientNative self,
        DiscordStatusType status,
        DiscordClientUpdateStatusCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_UpdateRichPresence(
        ref DiscordClientNative self,
        ref DiscordActivityNative activity,
        DiscordClientUpdateRichPresenceCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

}
