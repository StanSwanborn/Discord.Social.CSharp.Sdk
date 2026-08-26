using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

internal static class NativeDiscordGuildMethods
{
    private const string LibraryName = "discord_partner_sdk";

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_GuildMinimal_Drop(
        ref DiscordGuildMinimal self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_GuildMinimal_Clone(
        ref DiscordGuildMinimal self,
        ref DiscordGuildMinimal arg0);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_GuildMinimal_SetId(
        ref DiscordGuildMinimal self,
        ulong value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_GuildMinimal_Id(
        ref DiscordGuildMinimal self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_GuildMinimal_SetName(
        ref DiscordGuildMinimal self,
        DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_GuildMinimal_Name(
        ref DiscordGuildMinimal self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_GuildChannel_Drop(
        ref DiscordGuildChannel self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_GuildChannel_Clone(
        ref DiscordGuildChannel self,
        ref DiscordGuildChannel arg0);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_GuildChannel_SetId(
        ref DiscordGuildChannel self,
        ulong value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_GuildChannel_Id(
        ref DiscordGuildChannel self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_GuildChannel_SetName(
        ref DiscordGuildChannel self,
        DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_GuildChannel_Name(
        ref DiscordGuildChannel self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_GuildChannel_SetType(
        ref DiscordGuildChannel self,
        DiscordChannelType value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern DiscordChannelType Discord_GuildChannel_Type(
        ref DiscordGuildChannel self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_GuildChannel_SetPosition(
        ref DiscordGuildChannel self,
        int value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int Discord_GuildChannel_Position(
        ref DiscordGuildChannel self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_GuildChannel_SetParentId(
        ref DiscordGuildChannel self,
        ref ulong value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_GuildChannel_ParentId(
        ref DiscordGuildChannel self,
        ref ulong returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_GuildChannel_SetIsLinkable(
        ref DiscordGuildChannel self,
        [MarshalAs(UnmanagedType.I1)] bool value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_GuildChannel_IsLinkable(
        ref DiscordGuildChannel self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_GuildChannel_SetIsViewableAndWriteableByAllMembers(
        ref DiscordGuildChannel self,
        [MarshalAs(UnmanagedType.I1)] bool value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_GuildChannel_IsViewableAndWriteableByAllMembers(
        ref DiscordGuildChannel self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_GuildChannel_SetLinkedLobby(
        ref DiscordGuildChannel self,
        ref DiscordLinkedLobby value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_GuildChannel_LinkedLobby(
        ref DiscordGuildChannel self,
        ref DiscordLinkedLobby returnValue);

}
