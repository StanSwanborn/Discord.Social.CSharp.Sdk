using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

internal static class NativeDiscordClientOptionsMethods
{
    private const string LibraryName = "discord_partner_sdk";

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ClientCreateOptions_Init(
        ref DiscordClientCreateOptions self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ClientCreateOptions_Drop(
        ref DiscordClientCreateOptions self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ClientCreateOptions_Clone(
        ref DiscordClientCreateOptions self,
        ref DiscordClientCreateOptions arg0);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ClientCreateOptions_SetWebBase(
        ref DiscordClientCreateOptions self,
        DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ClientCreateOptions_WebBase(
        ref DiscordClientCreateOptions self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ClientCreateOptions_SetApiBase(
        ref DiscordClientCreateOptions self,
        DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ClientCreateOptions_ApiBase(
        ref DiscordClientCreateOptions self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ClientCreateOptions_SetExperimentalAudioSystem(
        ref DiscordClientCreateOptions self,
        DiscordAudioSystem value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern DiscordAudioSystem Discord_ClientCreateOptions_ExperimentalAudioSystem(
        ref DiscordClientCreateOptions self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ClientCreateOptions_SetExperimentalAndroidPreventCommsForBluetooth(
        ref DiscordClientCreateOptions self,
        [MarshalAs(UnmanagedType.I1)] bool value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_ClientCreateOptions_ExperimentalAndroidPreventCommsForBluetooth(
        ref DiscordClientCreateOptions self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ClientCreateOptions_SetCpuAffinityMask(
        ref DiscordClientCreateOptions self,
        ref ulong value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_ClientCreateOptions_CpuAffinityMask(
        ref DiscordClientCreateOptions self,
        ref ulong returnValue);

}
