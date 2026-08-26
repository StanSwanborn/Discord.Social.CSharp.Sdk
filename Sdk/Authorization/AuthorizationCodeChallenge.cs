using Discord.Social.CSharp.Native.Sdk;

namespace Discord.Social.CSharp.Sdk.Authorization;

public enum AuthorizationCodeChallengeMethod
{
    S256 = 0
}

public sealed class AuthorizationCodeChallenge : IDisposable
{
    private DiscordAuthorizationCodeChallenge _native;
    private bool _disposed;

    public AuthorizationCodeChallenge()
    {
        NativeDiscordAuthorizationMethods.Discord_AuthorizationCodeChallenge_Init(ref _native);
    }

    internal AuthorizationCodeChallenge(DiscordAuthorizationCodeChallenge native)
    {
        _native = native;
    }

    public AuthorizationCodeChallengeMethod Method
    {
        get
        {
            ThrowIfDisposed();
            return (AuthorizationCodeChallengeMethod)NativeDiscordAuthorizationMethods.Discord_AuthorizationCodeChallenge_Method(ref _native);
        }
        set
        {
            ThrowIfDisposed();
            NativeDiscordAuthorizationMethods.Discord_AuthorizationCodeChallenge_SetMethod(ref _native, (DiscordAuthenticationCodeChallengeMethod)value);
        }
    }

    public string Challenge
    {
        get
        {
            ThrowIfDisposed();
            var value = new DiscordString();
            NativeDiscordAuthorizationMethods.Discord_AuthorizationCodeChallenge_Challenge(ref _native, ref value);
            return NativeString.Read(value);
        }
        set
        {
            ThrowIfDisposed();
            SetString(value, NativeDiscordAuthorizationMethods.Discord_AuthorizationCodeChallenge_SetChallenge);
        }
    }

    public AuthorizationCodeChallenge Clone()
    {
        ThrowIfDisposed();
        var clone = new AuthorizationCodeChallenge();
        NativeDiscordAuthorizationMethods.Discord_AuthorizationCodeChallenge_Clone(ref clone._native, ref _native);
        return clone;
    }

    public void Dispose()
    {
        if (_disposed)
            return;

        NativeDiscordAuthorizationMethods.Discord_AuthorizationCodeChallenge_Drop(ref _native);
        _disposed = true;
        GC.SuppressFinalize(this);
    }

    ~AuthorizationCodeChallenge() => Dispose();

    internal ref DiscordAuthorizationCodeChallenge NativeValue
    {
        get
        {
            ThrowIfDisposed();
            return ref _native;
        }
    }

    private delegate void SetStringDelegate(ref DiscordAuthorizationCodeChallenge self, DiscordString value);

    private void SetString(string text, SetStringDelegate setter)
    {
        ArgumentNullException.ThrowIfNull(text);
        var nativeString = NativeString.Create(text, out var allocation);
        try
        {
            setter(ref _native, nativeString);
        }
        finally
        {
            NativeString.Free(allocation);
        }
    }

    private void ThrowIfDisposed() => ObjectDisposedException.ThrowIf(_disposed, this);
}