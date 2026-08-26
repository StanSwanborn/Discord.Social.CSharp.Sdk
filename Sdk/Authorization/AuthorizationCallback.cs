using Discord.Social.CSharp.Native.Sdk;

public delegate void AuthorizationCallback(ClientResult result, string code, string redirectUri);

public delegate void ClientTokenExchangeCallback(ClientResult result, string accessToken, string refreshToken, AuthorizationTokenType tokenType, int expiresIn, string scope);

public enum AuthorizationTokenType
{
    User = 0,
    Bearer = 1,
}

public sealed class ClientResult : IDisposable
{
    private DiscordClientResultNative _native;
    private bool _disposed;

    internal ClientResult(DiscordClientResultNative native) =>NativeDiscordResultMethods.Discord_ClientResult_Clone(ref _native, ref native);

    public bool Successful
    {
        get
        {
            ObjectDisposedException.ThrowIf(_disposed, this);
            return NativeDiscordResultMethods.Discord_ClientResult_Successful(ref _native);
        }
    }

    public string Error
    {
        get
        {
            ObjectDisposedException.ThrowIf(_disposed, this);
            var value = new DiscordString();

            NativeDiscordResultMethods.Discord_ClientResult_Error(ref _native, ref value);

            return NativeString.Read(value);
        }
    }

    public void Dispose()
    {
        if (_disposed)
            return;

        NativeDiscordResultMethods.Discord_ClientResult_Drop(ref _native);
        _disposed = true;
    }
}