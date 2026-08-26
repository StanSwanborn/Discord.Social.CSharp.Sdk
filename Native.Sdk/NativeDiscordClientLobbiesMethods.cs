using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

internal static class NativeDiscordClientLobbiesMethods
{
    private const string LibraryName = "discord_partner_sdk";

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_CreateOrJoinLobby(
        ref DiscordClientNative self,
        DiscordString secret,
        DiscordClientCreateOrJoinLobbyCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_CreateOrJoinLobbyWithMetadata(
        ref DiscordClientNative self,
        DiscordString secret,
        DiscordProperties lobbyMetadata,
        DiscordProperties memberMetadata,
        DiscordClientCreateOrJoinLobbyCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_GetGuildChannels(
        ref DiscordClientNative self,
        ulong guildId,
        DiscordClientGetGuildChannelsCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Client_GetLobbyHandle(
        ref DiscordClientNative self,
        ulong lobbyId,
        ref DiscordLobbyHandle returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_GetLobbyIds(
        ref DiscordClientNative self,
        ref DiscordUInt64Span returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_JoinLinkedLobbyGuild(
        ref DiscordClientNative self,
        ulong lobbyId,
        DiscordClientProvisionalUserMergeRequiredCallback provisionalUserMergeRequiredCallback,
        DiscordFreeFn provisionalUserMergeRequiredCallback__userDataFree,
        nint provisionalUserMergeRequiredCallback__userData,
        DiscordClientJoinLinkedLobbyGuildCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_LeaveLobby(
        ref DiscordClientNative self,
        ulong lobbyId,
        DiscordClientLeaveLobbyCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_LinkChannelToLobby(
        ref DiscordClientNative self,
        ulong lobbyId,
        ulong channelId,
        DiscordClientLinkOrUnlinkChannelCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetLobbyCreatedCallback(
        ref DiscordClientNative self,
        DiscordClientLobbyCreatedCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetLobbyDeletedCallback(
        ref DiscordClientNative self,
        DiscordClientLobbyDeletedCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetLobbyMemberAddedCallback(
        ref DiscordClientNative self,
        DiscordClientLobbyMemberAddedCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetLobbyMemberRemovedCallback(
        ref DiscordClientNative self,
        DiscordClientLobbyMemberRemovedCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetLobbyMemberUpdatedCallback(
        ref DiscordClientNative self,
        DiscordClientLobbyMemberUpdatedCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetLobbyUpdatedCallback(
        ref DiscordClientNative self,
        DiscordClientLobbyUpdatedCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_UnlinkChannelFromLobby(
        ref DiscordClientNative self,
        ulong lobbyId,
        DiscordClientLinkOrUnlinkChannelCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

}
