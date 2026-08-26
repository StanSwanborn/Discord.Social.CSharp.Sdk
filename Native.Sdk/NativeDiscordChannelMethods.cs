using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

internal static class NativeDiscordChannelMethods
{
    private const string LibraryName = "discord_partner_sdk";

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ChannelHandle_Drop(
        ref DiscordChannelHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ChannelHandle_Clone(
        ref DiscordChannelHandle self,
        ref DiscordChannelHandle other);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_ChannelHandle_Id(
        ref DiscordChannelHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ChannelHandle_Name(
        ref DiscordChannelHandle self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ChannelHandle_Recipients(
        ref DiscordChannelHandle self,
        ref DiscordUInt64Span returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern DiscordChannelType Discord_ChannelHandle_Type(
        ref DiscordChannelHandle self);

}
