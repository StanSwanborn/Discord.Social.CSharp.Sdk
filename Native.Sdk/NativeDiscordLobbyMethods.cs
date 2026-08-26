using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

internal static class NativeDiscordLobbyMethods
{
    private const string LibraryName = "discord_partner_sdk";

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_LinkedLobby_Init(
        ref DiscordLinkedLobby self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_LinkedLobby_Drop(
        ref DiscordLinkedLobby self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_LinkedLobby_Clone(
        ref DiscordLinkedLobby self,
        ref DiscordLinkedLobby arg0);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_LinkedLobby_SetApplicationId(
        ref DiscordLinkedLobby self,
        ulong value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_LinkedLobby_ApplicationId(
        ref DiscordLinkedLobby self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_LinkedLobby_SetLobbyId(
        ref DiscordLinkedLobby self,
        ulong value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_LinkedLobby_LobbyId(
        ref DiscordLinkedLobby self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_LinkedChannel_Drop(
        ref DiscordLinkedChannel self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_LinkedChannel_Clone(
        ref DiscordLinkedChannel self,
        ref DiscordLinkedChannel arg0);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_LinkedChannel_SetId(
        ref DiscordLinkedChannel self,
        ulong value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_LinkedChannel_Id(
        ref DiscordLinkedChannel self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_LinkedChannel_SetName(
        ref DiscordLinkedChannel self,
        DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_LinkedChannel_Name(
        ref DiscordLinkedChannel self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_LinkedChannel_SetGuildId(
        ref DiscordLinkedChannel self,
        ulong value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_LinkedChannel_GuildId(
        ref DiscordLinkedChannel self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_LobbyMemberHandle_Drop(
        ref DiscordLobbyMemberHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_LobbyMemberHandle_Clone(
        ref DiscordLobbyMemberHandle self,
        ref DiscordLobbyMemberHandle other);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_LobbyMemberHandle_CanLinkLobby(
        ref DiscordLobbyMemberHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_LobbyMemberHandle_Connected(
        ref DiscordLobbyMemberHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_LobbyMemberHandle_Id(
        ref DiscordLobbyMemberHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_LobbyMemberHandle_Metadata(
        ref DiscordLobbyMemberHandle self,
        ref DiscordProperties returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_LobbyMemberHandle_User(
        ref DiscordLobbyMemberHandle self,
        ref DiscordUserHandle returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_LobbyHandle_Drop(
        ref DiscordLobbyHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_LobbyHandle_Clone(
        ref DiscordLobbyHandle self,
        ref DiscordLobbyHandle other);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_LobbyHandle_GetCallInfoHandle(
        ref DiscordLobbyHandle self,
        ref DiscordCallInfoHandle returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_LobbyHandle_GetLobbyMemberHandle(
        ref DiscordLobbyHandle self,
        ulong memberId,
        ref DiscordLobbyMemberHandle returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_LobbyHandle_Id(
        ref DiscordLobbyHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_LobbyHandle_LinkedChannel(
        ref DiscordLobbyHandle self,
        ref DiscordLinkedChannel returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_LobbyHandle_LobbyMemberIds(
        ref DiscordLobbyHandle self,
        ref DiscordUInt64Span returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_LobbyHandle_LobbyMembers(
        ref DiscordLobbyHandle self,
        ref DiscordLobbyMemberHandleSpan returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_LobbyHandle_Metadata(
        ref DiscordLobbyHandle self,
        ref DiscordProperties returnValue);

}
