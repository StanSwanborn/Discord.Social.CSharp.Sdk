using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

internal static class NativeDiscordAudioMethods
{
    private const string LibraryName = "discord_partner_sdk";

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AudioDevice_Drop(
        ref DiscordAudioDevice self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AudioDevice_Clone(
        ref DiscordAudioDevice self,
        ref DiscordAudioDevice arg0);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_AudioDevice_Equals(
        ref DiscordAudioDevice self,
        ref DiscordAudioDevice rhs);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AudioDevice_SetId(
        ref DiscordAudioDevice self,
        DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AudioDevice_Id(
        ref DiscordAudioDevice self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AudioDevice_SetName(
        ref DiscordAudioDevice self,
        DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AudioDevice_Name(
        ref DiscordAudioDevice self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_AudioDevice_SetIsDefault(
        ref DiscordAudioDevice self,
        [MarshalAs(UnmanagedType.I1)] bool value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_AudioDevice_IsDefault(
        ref DiscordAudioDevice self);

}
