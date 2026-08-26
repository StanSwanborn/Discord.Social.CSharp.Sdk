using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

internal static class NativeDiscordRelationshipMethods
{
    private const string LibraryName = "discord_partner_sdk";

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_RelationshipHandle_Drop(
        ref DiscordRelationshipHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_RelationshipHandle_Clone(
        ref DiscordRelationshipHandle self,
        ref DiscordRelationshipHandle other);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern DiscordRelationshipType Discord_RelationshipHandle_DiscordRelationshipType(
        ref DiscordRelationshipHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern DiscordRelationshipType Discord_RelationshipHandle_GameRelationshipType(
        ref DiscordRelationshipHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_RelationshipHandle_Id(
        ref DiscordRelationshipHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_RelationshipHandle_IsSpamRequest(
        ref DiscordRelationshipHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_RelationshipHandle_User(
        ref DiscordRelationshipHandle self,
        ref DiscordUserHandle returnValue);

}
