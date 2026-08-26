using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

internal static class NativeDiscordResultMethods
{
    private const string LibraryName = "discord_partner_sdk";

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ClientResult_Drop(
        ref DiscordClientResultNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ClientResult_Clone(
        ref DiscordClientResultNative self,
        ref DiscordClientResultNative arg0);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ClientResult_ToString(
        ref DiscordClientResultNative self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ClientResult_SetType(
        ref DiscordClientResultNative self,
        DiscordErrorType value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern DiscordErrorType Discord_ClientResult_Type(
        ref DiscordClientResultNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ClientResult_SetError(
        ref DiscordClientResultNative self,
        DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ClientResult_Error(
        ref DiscordClientResultNative self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ClientResult_SetErrorCode(
        ref DiscordClientResultNative self,
        int value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int Discord_ClientResult_ErrorCode(
        ref DiscordClientResultNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ClientResult_SetStatus(
        ref DiscordClientResultNative self,
        DiscordHttpStatusCode value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern DiscordHttpStatusCode Discord_ClientResult_Status(
        ref DiscordClientResultNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ClientResult_SetResponseBody(
        ref DiscordClientResultNative self,
        DiscordString value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ClientResult_ResponseBody(
        ref DiscordClientResultNative self,
        ref DiscordString returnValue);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ClientResult_SetSuccessful(
        ref DiscordClientResultNative self,
        [MarshalAs(UnmanagedType.I1)] bool value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_ClientResult_Successful(
        ref DiscordClientResultNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ClientResult_SetRetryable(
        ref DiscordClientResultNative self,
        [MarshalAs(UnmanagedType.I1)] bool value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool Discord_ClientResult_Retryable(
        ref DiscordClientResultNative self);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void Discord_ClientResult_SetRetryAfter(
        ref DiscordClientResultNative self,
        float value);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    internal static extern float Discord_ClientResult_RetryAfter(
        ref DiscordClientResultNative self);

}
