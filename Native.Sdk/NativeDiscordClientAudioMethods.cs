using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

internal static class NativeDiscordClientAudioMethods
{
    private const string LibraryName = "discord_partner_sdk";

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_GetDefaultAudioDeviceId(
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_GetCurrentInputDevice(
        ref DiscordClientNative self,
        DiscordClientGetCurrentInputDeviceCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_GetCurrentOutputDevice(
        ref DiscordClientNative self,
        DiscordClientGetCurrentOutputDeviceCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_GetInputDevices(
        ref DiscordClientNative self,
        DiscordClientGetInputDevicesCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern float Discord_Client_GetInputVolume(
        ref DiscordClientNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_GetOutputDevices(
        ref DiscordClientNative self,
        DiscordClientGetOutputDevicesCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern float Discord_Client_GetOutputVolume(
        ref DiscordClientNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Client_GetSelfDeafAll(
        ref DiscordClientNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Client_GetSelfMuteAll(
        ref DiscordClientNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetDeviceChangeCallback(
        ref DiscordClientNative self,
        DiscordClientDeviceChangeCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetEchoCancellation(
        ref DiscordClientNative self,
        [MarshalAs(UnmanagedType.I1)] bool on);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetEngineManagedAudioSession(
        ref DiscordClientNative self,
        [MarshalAs(UnmanagedType.I1)] bool isEngineManaged);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetInputDevice(
        ref DiscordClientNative self,
        DiscordString deviceId,
        DiscordClientSetInputDeviceCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetInputVolume(
        ref DiscordClientNative self,
        float inputVolume);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetNoAudioInputCallback(
        ref DiscordClientNative self,
        DiscordClientNoAudioInputCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetNoAudioInputThreshold(
        ref DiscordClientNative self,
        float dBFSThreshold);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetNoiseCancellation(
        ref DiscordClientNative self,
        [MarshalAs(UnmanagedType.I1)] bool on);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetNoiseSuppression(
        ref DiscordClientNative self,
        [MarshalAs(UnmanagedType.I1)] bool on);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetOpusHardwareCoding(
        ref DiscordClientNative self,
        [MarshalAs(UnmanagedType.I1)] bool encode,
        [MarshalAs(UnmanagedType.I1)] bool decode);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetOutputDevice(
        ref DiscordClientNative self,
        DiscordString deviceId,
        DiscordClientSetOutputDeviceCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetOutputVolume(
        ref DiscordClientNative self,
        float outputVolume);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetSelfDeafAll(
        ref DiscordClientNative self,
        [MarshalAs(UnmanagedType.I1)] bool deaf);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetSelfMuteAll(
        ref DiscordClientNative self,
        [MarshalAs(UnmanagedType.I1)] bool mute);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Client_SetSpeakerMode(
        ref DiscordClientNative self,
        [MarshalAs(UnmanagedType.I1)] bool speakerMode);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetVoiceParticipantChangedCallback(
        ref DiscordClientNative self,
        DiscordClientVoiceParticipantChangedCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Client_ShowAudioRoutePicker(
        ref DiscordClientNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_Client_StartCallWithAudioCallbacks(
        ref DiscordClientNative self,
        ulong lobbyId,
        DiscordClientUserAudioReceivedCallback receivedCb,
        DiscordFreeFn receivedCb__userDataFree,
        nint receivedCb__userData,
        DiscordClientUserAudioCapturedCallback capturedCb,
        DiscordFreeFn capturedCb__userDataFree,
        nint capturedCb__userData,
        ref DiscordCall returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_AbortGetTokenFromDevice(
        ref DiscordClientNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_CloseAuthorizeDeviceScreen(
        ref DiscordClientNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_GetTokenFromDevice(
        ref DiscordClientNative self,
        ref DiscordDeviceAuthorizationArgs args,
        DiscordClientTokenExchangeCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_GetTokenFromDeviceProvisionalMerge(
        ref DiscordClientNative self,
        ref DiscordDeviceAuthorizationArgs args,
        DiscordAuthenticationExternalAuthType externalAuthType,
        DiscordString externalAuthToken,
        DiscordClientTokenExchangeCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_OpenAuthorizeDeviceScreen(
        ref DiscordClientNative self,
        ulong clientId,
        DiscordString userCode);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetAuthorizeDeviceScreenClosedCallback(
        ref DiscordClientNative self,
        DiscordClientAuthorizeDeviceScreenClosedCallback cb,
        DiscordFreeFn cb__userDataFree,
        nint cb__userData);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_AddVoiceLogCallback(
        ref DiscordClientNative self,
        DiscordClientLogCallback callback,
        DiscordFreeFn callback__userDataFree,
        nint callback__userData,
        DiscordLoggingSeverity minSeverity);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_Client_SetVoiceLogDir(
        ref DiscordClientNative self,
        DiscordString path,
        DiscordLoggingSeverity minSeverity);

}
