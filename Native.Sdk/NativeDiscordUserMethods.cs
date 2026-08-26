using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

internal static class NativeDiscordUserMethods
{
    private const string LibraryName = "discord_partner_sdk";

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_UserApplicationProfileHandle_Drop(
        ref DiscordUserApplicationProfileHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_UserApplicationProfileHandle_Clone(
        ref DiscordUserApplicationProfileHandle self,
        ref DiscordUserApplicationProfileHandle other);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_UserApplicationProfileHandle_AvatarHash(
        ref DiscordUserApplicationProfileHandle self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_UserApplicationProfileHandle_Metadata(
        ref DiscordUserApplicationProfileHandle self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_UserApplicationProfileHandle_ProviderId(
        ref DiscordUserApplicationProfileHandle self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_UserApplicationProfileHandle_ProviderIssuedUserId(
        ref DiscordUserApplicationProfileHandle self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern DiscordExternalIdentityProviderType Discord_UserApplicationProfileHandle_ProviderType(
        ref DiscordUserApplicationProfileHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_UserApplicationProfileHandle_Username(
        ref DiscordUserApplicationProfileHandle self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_UserHandle_Drop(
        ref DiscordUserHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_UserHandle_Clone(
        ref DiscordUserHandle self,
        ref DiscordUserHandle arg0);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_UserHandle_Avatar(
        ref DiscordUserHandle self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_UserHandle_AvatarTypeToString(
        DiscordUserHandleAvatarType type,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_UserHandle_AvatarUrl(
        ref DiscordUserHandle self,
        DiscordUserHandleAvatarType animatedType,
        DiscordUserHandleAvatarType staticType,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_UserHandle_DisplayName(
        ref DiscordUserHandle self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_UserHandle_GameActivity(
        ref DiscordUserHandle self,
        ref DiscordActivityNative returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_UserHandle_GlobalName(
        ref DiscordUserHandle self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_UserHandle_Id(
        ref DiscordUserHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_UserHandle_IsProvisional(
        ref DiscordUserHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_UserHandle_Relationship(
        ref DiscordUserHandle self,
        ref DiscordRelationshipHandle returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern DiscordStatusType Discord_UserHandle_Status(
        ref DiscordUserHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_UserHandle_UserApplicationProfiles(
        ref DiscordUserHandle self,
        ref DiscordUserApplicationProfileHandleSpan returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_UserHandle_Username(
        ref DiscordUserHandle self,
        ref DiscordString returnValue);

}
