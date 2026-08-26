using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

internal static class NativeDiscordMessagingMethods
{
    private const string LibraryName = "discord_partner_sdk";

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AdditionalContent_Init(
        ref DiscordAdditionalContent self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AdditionalContent_Drop(
        ref DiscordAdditionalContent self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AdditionalContent_Clone(
        ref DiscordAdditionalContent self,
        ref DiscordAdditionalContent arg0);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_AdditionalContent_Equals(
        ref DiscordAdditionalContent self,
        ref DiscordAdditionalContent rhs);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AdditionalContent_TypeToString(
        DiscordAdditionalContentType type,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AdditionalContent_SetType(
        ref DiscordAdditionalContent self,
        DiscordAdditionalContentType value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern DiscordAdditionalContentType Discord_AdditionalContent_Type(
        ref DiscordAdditionalContent self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AdditionalContent_SetTitle(
        ref DiscordAdditionalContent self,
        ref DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_AdditionalContent_Title(
        ref DiscordAdditionalContent self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AdditionalContent_SetCount(
        ref DiscordAdditionalContent self,
        byte value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern byte Discord_AdditionalContent_Count(
        ref DiscordAdditionalContent self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_MessageHandle_Drop(
        ref DiscordMessageHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_MessageHandle_Clone(
        ref DiscordMessageHandle self,
        ref DiscordMessageHandle other);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_MessageHandle_AdditionalContent(
        ref DiscordMessageHandle self,
        ref DiscordAdditionalContent returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_MessageHandle_AdditionalName(
        ref DiscordMessageHandle self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_MessageHandle_ApplicationId(
        ref DiscordMessageHandle self,
        ref ulong returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_MessageHandle_Author(
        ref DiscordMessageHandle self,
        ref DiscordUserHandle returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_MessageHandle_AuthorId(
        ref DiscordMessageHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_MessageHandle_Channel(
        ref DiscordMessageHandle self,
        ref DiscordChannelHandle returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_MessageHandle_ChannelId(
        ref DiscordMessageHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_MessageHandle_Content(
        ref DiscordMessageHandle self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_MessageHandle_DisclosureType(
        ref DiscordMessageHandle self,
        ref DiscordDisclosureTypes returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_MessageHandle_EditedTimestamp(
        ref DiscordMessageHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_MessageHandle_Id(
        ref DiscordMessageHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_MessageHandle_Lobby(
        ref DiscordMessageHandle self,
        ref DiscordLobbyHandle returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_MessageHandle_Metadata(
        ref DiscordMessageHandle self,
        ref DiscordProperties returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_MessageHandle_ModerationMetadata(
        ref DiscordMessageHandle self,
        ref DiscordProperties returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_MessageHandle_RawContent(
        ref DiscordMessageHandle self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_MessageHandle_Recipient(
        ref DiscordMessageHandle self,
        ref DiscordUserHandle returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_MessageHandle_RecipientId(
        ref DiscordMessageHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_MessageHandle_SentFromGame(
        ref DiscordMessageHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_MessageHandle_SentTimestamp(
        ref DiscordMessageHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_UserMessageSummary_Drop(
        ref DiscordUserMessageSummary self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_UserMessageSummary_Clone(
        ref DiscordUserMessageSummary self,
        ref DiscordUserMessageSummary arg0);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_UserMessageSummary_LastMessageId(
        ref DiscordUserMessageSummary self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_UserMessageSummary_UserId(
        ref DiscordUserMessageSummary self);

}
