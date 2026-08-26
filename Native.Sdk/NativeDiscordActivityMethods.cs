using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

internal static class NativeDiscordActivityMethods
{
    private const string LibraryName = "discord_partner_sdk";

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityInvite_Init(
        ref DiscordActivityInvite self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityInvite_Drop(
        ref DiscordActivityInvite self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityInvite_Clone(
        ref DiscordActivityInvite self,
        ref DiscordActivityInvite rhs);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityInvite_SetSenderId(
        ref DiscordActivityInvite self,
        ulong value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_ActivityInvite_SenderId(
        ref DiscordActivityInvite self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityInvite_SetChannelId(
        ref DiscordActivityInvite self,
        ulong value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_ActivityInvite_ChannelId(
        ref DiscordActivityInvite self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityInvite_SetMessageId(
        ref DiscordActivityInvite self,
        ulong value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_ActivityInvite_MessageId(
        ref DiscordActivityInvite self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityInvite_SetType(
        ref DiscordActivityInvite self,
        DiscordActivityActionTypes value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern DiscordActivityActionTypes Discord_ActivityInvite_Type(
        ref DiscordActivityInvite self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityInvite_SetApplicationId(
        ref DiscordActivityInvite self,
        ulong value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_ActivityInvite_ApplicationId(
        ref DiscordActivityInvite self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityInvite_SetParentApplicationId(
        ref DiscordActivityInvite self,
        ulong value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_ActivityInvite_ParentApplicationId(
        ref DiscordActivityInvite self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityInvite_SetPartyId(
        ref DiscordActivityInvite self,
        DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityInvite_PartyId(
        ref DiscordActivityInvite self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityInvite_SetSessionId(
        ref DiscordActivityInvite self,
        DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityInvite_SessionId(
        ref DiscordActivityInvite self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityInvite_SetIsValid(
        ref DiscordActivityInvite self,
        [MarshalAs(UnmanagedType.I1)] bool value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_ActivityInvite_IsValid(
        ref DiscordActivityInvite self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityAssets_Init(
        ref DiscordActivityAssets self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityAssets_Drop(
        ref DiscordActivityAssets self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityAssets_Clone(
        ref DiscordActivityAssets self,
        ref DiscordActivityAssets arg0);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityAssets_SetLargeImage(
        ref DiscordActivityAssets self,
        ref DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_ActivityAssets_LargeImage(
        ref DiscordActivityAssets self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityAssets_SetLargeText(
        ref DiscordActivityAssets self,
        ref DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_ActivityAssets_LargeText(
        ref DiscordActivityAssets self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityAssets_SetLargeUrl(
        ref DiscordActivityAssets self,
        ref DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_ActivityAssets_LargeUrl(
        ref DiscordActivityAssets self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityAssets_SetSmallImage(
        ref DiscordActivityAssets self,
        ref DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_ActivityAssets_SmallImage(
        ref DiscordActivityAssets self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityAssets_SetSmallText(
        ref DiscordActivityAssets self,
        ref DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_ActivityAssets_SmallText(
        ref DiscordActivityAssets self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityAssets_SetSmallUrl(
        ref DiscordActivityAssets self,
        ref DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_ActivityAssets_SmallUrl(
        ref DiscordActivityAssets self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityAssets_SetInviteCoverImage(
        ref DiscordActivityAssets self,
        ref DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_ActivityAssets_InviteCoverImage(
        ref DiscordActivityAssets self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityTimestamps_Init(
        ref DiscordActivityTimestamps self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityTimestamps_Drop(
        ref DiscordActivityTimestamps self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityTimestamps_Clone(
        ref DiscordActivityTimestamps self,
        ref DiscordActivityTimestamps arg0);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityTimestamps_SetStart(
        ref DiscordActivityTimestamps self,
        ulong value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_ActivityTimestamps_Start(
        ref DiscordActivityTimestamps self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityTimestamps_SetEnd(
        ref DiscordActivityTimestamps self,
        ulong value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_ActivityTimestamps_End(
        ref DiscordActivityTimestamps self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityParty_Init(
        ref DiscordActivityParty self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityParty_Drop(
        ref DiscordActivityParty self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityParty_Clone(
        ref DiscordActivityParty self,
        ref DiscordActivityParty arg0);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityParty_SetId(
        ref DiscordActivityParty self,
        DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityParty_Id(
        ref DiscordActivityParty self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityParty_SetCurrentSize(
        ref DiscordActivityParty self,
        int value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int Discord_ActivityParty_CurrentSize(
        ref DiscordActivityParty self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityParty_SetMaxSize(
        ref DiscordActivityParty self,
        int value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int Discord_ActivityParty_MaxSize(
        ref DiscordActivityParty self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityParty_SetPrivacy(
        ref DiscordActivityParty self,
        DiscordActivityPartyPrivacy value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern DiscordActivityPartyPrivacy Discord_ActivityParty_Privacy(
        ref DiscordActivityParty self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivitySecrets_Init(
        ref DiscordActivitySecrets self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivitySecrets_Drop(
        ref DiscordActivitySecrets self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivitySecrets_Clone(
        ref DiscordActivitySecrets self,
        ref DiscordActivitySecrets arg0);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivitySecrets_SetJoin(
        ref DiscordActivitySecrets self,
        DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivitySecrets_Join(
        ref DiscordActivitySecrets self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityButton_Init(
        ref DiscordActivityButton self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityButton_Drop(
        ref DiscordActivityButton self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityButton_Clone(
        ref DiscordActivityButton self,
        ref DiscordActivityButton arg0);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityButton_SetLabel(
        ref DiscordActivityButton self,
        DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityButton_Label(
        ref DiscordActivityButton self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityButton_SetUrl(
        ref DiscordActivityButton self,
        DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ActivityButton_Url(
        ref DiscordActivityButton self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Activity_Init(
        ref DiscordActivityNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Activity_Drop(
        ref DiscordActivityNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Activity_Clone(
        ref DiscordActivityNative self,
        ref DiscordActivityNative arg0);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Activity_AddButton(
        ref DiscordActivityNative self,
        ref DiscordActivityButton button);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Activity_Equals(
        ref DiscordActivityNative self,
        ref DiscordActivityNative other);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Activity_GetButtons(
        ref DiscordActivityNative self,
        ref DiscordActivityButtonSpan returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Activity_SetName(
        ref DiscordActivityNative self,
        DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Activity_Name(
        ref DiscordActivityNative self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Activity_SetType(
        ref DiscordActivityNative self,
        DiscordActivityType value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern DiscordActivityType Discord_Activity_Type(
        ref DiscordActivityNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Activity_SetStatusDisplayType(
        ref DiscordActivityNative self,
        ref DiscordStatusDisplayTypes value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Activity_StatusDisplayType(
        ref DiscordActivityNative self,
        ref DiscordStatusDisplayTypes returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Activity_SetState(
        ref DiscordActivityNative self,
        ref DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Activity_State(
        ref DiscordActivityNative self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Activity_SetStateUrl(
        ref DiscordActivityNative self,
        ref DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Activity_StateUrl(
        ref DiscordActivityNative self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Activity_SetDetails(
        ref DiscordActivityNative self,
        ref DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Activity_Details(
        ref DiscordActivityNative self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Activity_SetDetailsUrl(
        ref DiscordActivityNative self,
        ref DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Activity_DetailsUrl(
        ref DiscordActivityNative self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Activity_SetApplicationId(
        ref DiscordActivityNative self,
        ref ulong value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Activity_ApplicationId(
        ref DiscordActivityNative self,
        ref ulong returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Activity_SetParentApplicationId(
        ref DiscordActivityNative self,
        ref ulong value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Activity_ParentApplicationId(
        ref DiscordActivityNative self,
        ref ulong returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Activity_SetAssets(
        ref DiscordActivityNative self,
        ref DiscordActivityAssets value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Activity_Assets(
        ref DiscordActivityNative self,
        ref DiscordActivityAssets returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Activity_SetTimestamps(
        ref DiscordActivityNative self,
        ref DiscordActivityTimestamps value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Activity_Timestamps(
        ref DiscordActivityNative self,
        ref DiscordActivityTimestamps returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Activity_SetParty(
        ref DiscordActivityNative self,
        ref DiscordActivityParty value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Activity_Party(
        ref DiscordActivityNative self,
        ref DiscordActivityParty returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Activity_SetSecrets(
        ref DiscordActivityNative self,
        ref DiscordActivitySecrets value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Activity_Secrets(
        ref DiscordActivityNative self,
        ref DiscordActivitySecrets returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Activity_SetSupportedPlatforms(
        ref DiscordActivityNative self,
        DiscordActivityGamePlatforms value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern DiscordActivityGamePlatforms Discord_Activity_SupportedPlatforms(
        ref DiscordActivityNative self);

}
