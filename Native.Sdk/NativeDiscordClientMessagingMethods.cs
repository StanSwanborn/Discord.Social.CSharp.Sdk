using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

internal static class NativeDiscordClientMessagingMethods
{
    private const string LibraryName = "discord_partner_sdk";

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Client_CanOpenMessageInDiscord(
        ref DiscordClientNative self,
        ulong messageId);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_DeleteUserMessage(
        ref DiscordClientNative self,
        ulong recipientId,
        ulong messageId,
        DiscordClientDeleteUserMessageCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_EditUserMessage(
        ref DiscordClientNative self,
        ulong recipientId,
        ulong messageId,
        DiscordString content,
        DiscordClientEditUserMessageCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_GetLobbyMessagesWithLimit(
        ref DiscordClientNative self,
        ulong lobbyId,
        int limit,
        DiscordClientGetLobbyMessagesCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Client_GetMessageHandle(
        ref DiscordClientNative self,
        ulong messageId,
        ref DiscordMessageHandle returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_GetUserMessageSummaries(
        ref DiscordClientNative self,
        DiscordClientUserMessageSummariesCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_GetUserMessagesWithLimit(
        ref DiscordClientNative self,
        ulong recipientId,
        int limit,
        DiscordClientUserMessagesWithLimitCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_OpenMessageInDiscord(
        ref DiscordClientNative self,
        ulong messageId,
        DiscordClientProvisionalUserMergeRequiredCallback provisionalUserMergeRequiredCallback,
        DiscordFreeFn provisionalUserMergeRequiredCallback__userDataFree,
        nint provisionalUserMergeRequiredCallback__userData,
        DiscordClientOpenMessageInDiscordCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SendLobbyMessage(
        ref DiscordClientNative self,
        ulong lobbyId,
        DiscordString content,
        DiscordClientSendUserMessageCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SendLobbyMessageWithMetadata(
        ref DiscordClientNative self,
        ulong lobbyId,
        DiscordString content,
        DiscordProperties metadata,
        DiscordClientSendUserMessageCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SendUserMessage(
        ref DiscordClientNative self,
        ulong recipientId,
        DiscordString content,
        DiscordClientSendUserMessageCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SendUserMessageWithMetadata(
        ref DiscordClientNative self,
        ulong recipientId,
        DiscordString content,
        DiscordProperties metadata,
        DiscordClientSendUserMessageCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetMessageCreatedCallback(
        ref DiscordClientNative self,
        DiscordClientMessageCreatedCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetMessageDeletedCallback(
        ref DiscordClientNative self,
        DiscordClientMessageDeletedCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetMessageUpdatedCallback(
        ref DiscordClientNative self,
        DiscordClientMessageUpdatedCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetShowingChat(
        ref DiscordClientNative self,
        [MarshalAs(UnmanagedType.I1)] bool showingChat);

}
