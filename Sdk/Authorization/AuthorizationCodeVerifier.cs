using Discord.Social.CSharp.Native.Sdk;

namespace Discord.Social.CSharp.Sdk.Authorization;

public sealed class AuthorizationCodeVerifier : IDisposable
{
    private DiscordAuthorizationCodeVerifier _native;
    private bool _disposed;

    internal AuthorizationCodeVerifier(DiscordAuthorizationCodeVerifier native) =>_native = native;

    public AuthorizationCodeChallenge Challenge()
    {
        ThrowIfDisposed();
        var challenge = new DiscordAuthorizationCodeChallenge();
        NativeDiscordAuthorizationMethods.Discord_AuthorizationCodeVerifier_Challenge(ref _native, ref challenge);
        return new AuthorizationCodeChallenge(challenge);
    }

    public string Verifier
    {
        get
        {
            ThrowIfDisposed();
            var value = new DiscordString();
            NativeDiscordAuthorizationMethods.Discord_AuthorizationCodeVerifier_Verifier(ref _native, ref value);
            return NativeString.Read(value);
        }
        set
        {
            ThrowIfDisposed();
            ArgumentNullException.ThrowIfNull(value);
            var nativeString = NativeString.Create(value, out var allocation);
            try
            {
                NativeDiscordAuthorizationMethods.Discord_AuthorizationCodeVerifier_SetVerifier(ref _native, nativeString);
            }
            finally
            {
                NativeString.Free(allocation);
            }
        }
    }

    public void SetChallenge(AuthorizationCodeChallenge challenge)
    {
        ThrowIfDisposed();
        ArgumentNullException.ThrowIfNull(challenge);
        NativeDiscordAuthorizationMethods.Discord_AuthorizationCodeVerifier_SetChallenge(
            ref _native,
            ref challenge.NativeValue);
    }

    public AuthorizationCodeVerifier Clone()
    {
        ThrowIfDisposed();
        var clone = new AuthorizationCodeVerifier(new DiscordAuthorizationCodeVerifier());
        NativeDiscordAuthorizationMethods.Discord_AuthorizationCodeVerifier_Clone(ref clone._native, ref _native);
        return clone;
    }

    public void Dispose()
    {
        if (_disposed)
            return;

        NativeDiscordAuthorizationMethods.Discord_AuthorizationCodeVerifier_Drop(ref _native);
        _disposed = true;
        GC.SuppressFinalize(this);
    }

    ~AuthorizationCodeVerifier() => Dispose();

    internal ref DiscordAuthorizationCodeVerifier NativeValue
    {
        get
        {
            ThrowIfDisposed();
            return ref _native;
        }
    }

    private void ThrowIfDisposed() => ObjectDisposedException.ThrowIf(_disposed, this);
}