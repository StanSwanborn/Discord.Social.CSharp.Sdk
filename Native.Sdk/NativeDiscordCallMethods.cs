using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

internal static class NativeDiscordCallMethods
{
    private const string LibraryName = "discord_partner_sdk";

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_VoiceStateHandle_Drop(
        ref DiscordVoiceStateHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_VoiceStateHandle_Clone(
        ref DiscordVoiceStateHandle self,
        ref DiscordVoiceStateHandle other);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_VoiceStateHandle_SelfDeaf(
        ref DiscordVoiceStateHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_VoiceStateHandle_SelfMute(
        ref DiscordVoiceStateHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_VADThresholdSettings_Drop(
        ref DiscordVADThresholdSettings self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_VADThresholdSettings_SetVadThreshold(
        ref DiscordVADThresholdSettings self,
        float value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern float Discord_VADThresholdSettings_VadThreshold(
        ref DiscordVADThresholdSettings self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_VADThresholdSettings_SetAutomatic(
        ref DiscordVADThresholdSettings self,
        [MarshalAs(UnmanagedType.I1)] bool value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_VADThresholdSettings_Automatic(
        ref DiscordVADThresholdSettings self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Call_Drop(
        ref DiscordCall self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Call_Clone(
        ref DiscordCall self,
        ref DiscordCall other);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Call_ErrorToString(
        DiscordCallError type,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern DiscordAudioModeType Discord_Call_GetAudioMode(
        ref DiscordCall self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_Call_GetChannelId(
        ref DiscordCall self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_Call_GetGuildId(
        ref DiscordCall self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Call_GetLocalMute(
        ref DiscordCall self,
        ulong userId);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Call_GetParticipants(
        ref DiscordCall self,
        ref DiscordUInt64Span returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern float Discord_Call_GetParticipantVolume(
        ref DiscordCall self,
        ulong userId);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Call_GetPTTActive(
        ref DiscordCall self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern uint Discord_Call_GetPTTReleaseDelay(
        ref DiscordCall self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Call_GetSelfDeaf(
        ref DiscordCall self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Call_GetSelfMute(
        ref DiscordCall self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern DiscordCallStatus Discord_Call_GetStatus(
        ref DiscordCall self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Call_GetVADThreshold(
        ref DiscordCall self,
        ref DiscordVADThresholdSettings returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Call_GetVoiceStateHandle(
        ref DiscordCall self,
        ulong userId,
        ref DiscordVoiceStateHandle returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Call_SetAudioMode(
        ref DiscordCall self,
        DiscordAudioModeType audioMode);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Call_SetLocalMute(
        ref DiscordCall self,
        ulong userId,
        [MarshalAs(UnmanagedType.I1)] bool mute);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Call_SetOnVoiceStateChangedCallback(
        ref DiscordCall self,
        DiscordCallOnVoiceStateChanged cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Call_SetParticipantChangedCallback(
        ref DiscordCall self,
        DiscordCallOnParticipantChanged cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Call_SetParticipantVolume(
        ref DiscordCall self,
        ulong userId,
        float volume);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Call_SetPTTActive(
        ref DiscordCall self,
        [MarshalAs(UnmanagedType.I1)] bool active);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Call_SetPTTReleaseDelay(
        ref DiscordCall self,
        uint releaseDelayMs);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Call_SetSelfDeaf(
        ref DiscordCall self,
        [MarshalAs(UnmanagedType.I1)] bool deaf);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Call_SetSelfMute(
        ref DiscordCall self,
        [MarshalAs(UnmanagedType.I1)] bool mute);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Call_SetSpeakingStatusChangedCallback(
        ref DiscordCall self,
        DiscordCallOnSpeakingStatusChanged cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Call_SetStatusChangedCallback(
        ref DiscordCall self,
        DiscordCallOnStatusChanged cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Call_SetVADThreshold(
        ref DiscordCall self,
        [MarshalAs(UnmanagedType.I1)] bool automatic,
        float threshold);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Call_StatusToString(
        DiscordCallStatus type,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_CallInfoHandle_Drop(
        ref DiscordCallInfoHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_CallInfoHandle_Clone(
        ref DiscordCallInfoHandle self,
        ref DiscordCallInfoHandle other);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_CallInfoHandle_ChannelId(
        ref DiscordCallInfoHandle self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_CallInfoHandle_GetParticipants(
        ref DiscordCallInfoHandle self,
        ref DiscordUInt64Span returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_CallInfoHandle_GetVoiceStateHandle(
        ref DiscordCallInfoHandle self,
        ulong userId,
        ref DiscordVoiceStateHandle returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern ulong Discord_CallInfoHandle_GuildId(
        ref DiscordCallInfoHandle self);

}
