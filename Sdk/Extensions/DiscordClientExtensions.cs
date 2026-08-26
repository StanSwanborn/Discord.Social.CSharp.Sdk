using Discord.Social.CSharp.Native.Sdk;

namespace Discord.Social.CSharp.Sdk.Extensions;

public static class DiscordClientExtensions
{
    public static string GetDefaultPresenceScopes()
    {
        var value = new DiscordString();
        NativeDiscordClientLifecycleMethods.Discord_Client_GetDefaultPresenceScopes(ref value);
        return NativeString.Read(value);
    }
}