using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

internal static class NativeDiscordClientRelationshipsMethods
{
    private const string LibraryName = "discord_partner_sdk";

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_AcceptDiscordFriendRequest(
        ref DiscordClientNative self,
        ulong userId,
        DiscordClientUpdateRelationshipCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_AcceptGameFriendRequest(
        ref DiscordClientNative self,
        ulong userId,
        DiscordClientUpdateRelationshipCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_BlockUser(
        ref DiscordClientNative self,
        ulong userId,
        DiscordClientUpdateRelationshipCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_CancelDiscordFriendRequest(
        ref DiscordClientNative self,
        ulong userId,
        DiscordClientUpdateRelationshipCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_CancelGameFriendRequest(
        ref DiscordClientNative self,
        ulong userId,
        DiscordClientUpdateRelationshipCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_GetRelationshipHandle(
        ref DiscordClientNative self,
        ulong userId,
        ref DiscordRelationshipHandle returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_GetRelationships(
        ref DiscordClientNative self,
        ref DiscordRelationshipHandleSpan returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_GetRelationshipsByGroup(
        ref DiscordClientNative self,
        DiscordRelationshipGroupType groupType,
        ref DiscordRelationshipHandleSpan returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_RejectDiscordFriendRequest(
        ref DiscordClientNative self,
        ulong userId,
        DiscordClientUpdateRelationshipCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_RejectGameFriendRequest(
        ref DiscordClientNative self,
        ulong userId,
        DiscordClientUpdateRelationshipCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_RemoveDiscordAndGameFriend(
        ref DiscordClientNative self,
        ulong userId,
        DiscordClientUpdateRelationshipCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_RemoveGameFriend(
        ref DiscordClientNative self,
        ulong userId,
        DiscordClientUpdateRelationshipCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SearchFriendsByUsername(
        ref DiscordClientNative self,
        DiscordString searchStr,
        ref DiscordUserHandleSpan returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SendDiscordFriendRequest(
        ref DiscordClientNative self,
        DiscordString username,
        DiscordClientSendFriendRequestCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SendDiscordFriendRequestById(
        ref DiscordClientNative self,
        ulong userId,
        DiscordClientUpdateRelationshipCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SendGameFriendRequest(
        ref DiscordClientNative self,
        DiscordString username,
        DiscordClientSendFriendRequestCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SendGameFriendRequestById(
        ref DiscordClientNative self,
        ulong userId,
        DiscordClientUpdateRelationshipCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetRelationshipCreatedCallback(
        ref DiscordClientNative self,
        DiscordClientRelationshipCreatedCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetRelationshipDeletedCallback(
        ref DiscordClientNative self,
        DiscordClientRelationshipDeletedCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_UnblockUser(
        ref DiscordClientNative self,
        ulong userId,
        DiscordClientUpdateRelationshipCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetRelationshipGroupsUpdatedCallback(
        ref DiscordClientNative self,
        DiscordClientRelationshipGroupsUpdatedCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetUserUpdatedCallback(
        ref DiscordClientNative self,
        DiscordClientUserUpdatedCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

}
