using Discord.Social.CSharp.Native.Sdk;

namespace Discord.Social.CSharp.Sdk.Authorization;

public enum AuthorizationIntegrationType
{
    GuildInstall = 0,
    UserInstall = 1
}

public sealed class AuthorizationArgs : IDisposable
{
    private DiscordAuthorizationArgs _native;
    private bool _disposed;

    public AuthorizationArgs() => NativeDiscordAuthorizationMethods.Discord_AuthorizationArgs_Init(ref _native);

    public ulong ClientId
    {
        get
        {
            ThrowIfDisposed();
            return NativeDiscordAuthorizationMethods.Discord_AuthorizationArgs_ClientId(ref _native);
        }
    }

    public string Scopes
    {
        get
        {
            ThrowIfDisposed();
            var value = new DiscordString();
            NativeDiscordAuthorizationMethods.Discord_AuthorizationArgs_Scopes(ref _native, ref value);
            return NativeString.Read(value);
        }
    }

    public string? State
    {
        get
        {
            ThrowIfDisposed();
            var value = new DiscordString();
            return NativeDiscordAuthorizationMethods.Discord_AuthorizationArgs_State(ref _native, ref value)
                ? NativeString.Read(value)
                : null;
        }
    }

    public string? Nonce
    {
        get
        {
            ThrowIfDisposed();
            var value = new DiscordString();
            return NativeDiscordAuthorizationMethods.Discord_AuthorizationArgs_Nonce(ref _native, ref value)
                ? NativeString.Read(value)
                : null;
        }
    }

    public AuthorizationCodeChallenge? CodeChallenge
    {
        get
        {
            ThrowIfDisposed();
            var value = new DiscordAuthorizationCodeChallenge();
            return NativeDiscordAuthorizationMethods.Discord_AuthorizationArgs_CodeChallenge(ref _native, ref value)
                ? new AuthorizationCodeChallenge(value)
                : null;
        }
    }

    public AuthorizationIntegrationType? IntegrationType
    {
        get
        {
            ThrowIfDisposed();
            var value = new DiscordIntegrationType();
            return NativeDiscordAuthorizationMethods.Discord_AuthorizationArgs_IntegrationType(ref _native, ref value)
                ? (AuthorizationIntegrationType)value
                : null;
        }
    }

    public string? CustomSchemeParam
    {
        get
        {
            ThrowIfDisposed();
            var value = new DiscordString();
            return NativeDiscordAuthorizationMethods.Discord_AuthorizationArgs_CustomSchemeParam(ref _native, ref value)
                ? NativeString.Read(value)
                : null;
        }
    }

    public void SetClientId(ulong clientId)
    {
        ThrowIfDisposed();
        NativeDiscordAuthorizationMethods.Discord_AuthorizationArgs_SetClientId(ref _native, clientId);
    }

    public void SetScopes(string scopes)
    {
        ThrowIfDisposed();
        SetString(scopes, NativeDiscordAuthorizationMethods.Discord_AuthorizationArgs_SetScopes);
    }

    public void SetState(string state)
    {
        ThrowIfDisposed();
        SetOptionalString(state, NativeDiscordAuthorizationMethods.Discord_AuthorizationArgs_SetState);
    }

    public void SetNonce(string nonce)
    {
        ThrowIfDisposed();
        SetOptionalString(nonce, NativeDiscordAuthorizationMethods.Discord_AuthorizationArgs_SetNonce);
    }

    public void SetCodeChallenge(AuthorizationCodeChallenge codeChallenge)
    {
        ThrowIfDisposed();
        ArgumentNullException.ThrowIfNull(codeChallenge);
        NativeDiscordAuthorizationMethods.Discord_AuthorizationArgs_SetCodeChallenge(
            ref _native,
            ref codeChallenge.NativeValue);
    }

    public void SetIntegrationType(AuthorizationIntegrationType integrationType)
    {
        ThrowIfDisposed();
        var nativeValue = (DiscordIntegrationType)integrationType;
        NativeDiscordAuthorizationMethods.Discord_AuthorizationArgs_SetIntegrationType(
            ref _native,
            ref nativeValue);
    }

    public void SetCustomSchemeParam(string customSchemeParam)
    {
        ThrowIfDisposed();
        SetOptionalString(customSchemeParam, NativeDiscordAuthorizationMethods.Discord_AuthorizationArgs_SetCustomSchemeParam);
    }

    public AuthorizationArgs Clone()
    {
        ThrowIfDisposed();
        var clone = new AuthorizationArgs();
        NativeDiscordAuthorizationMethods.Discord_AuthorizationArgs_Clone(ref clone._native, ref _native);
        return clone;
    }

    public void Dispose()
    {
        if (_disposed)
            return;

        NativeDiscordAuthorizationMethods.Discord_AuthorizationArgs_Drop(ref _native);
        _disposed = true;
        GC.SuppressFinalize(this);
    }

    ~AuthorizationArgs() => Dispose();

    internal ref DiscordAuthorizationArgs NativeValue
    {
        get
        {
            ThrowIfDisposed();
            return ref _native;
        }
    }

    private delegate void SetStringDelegate(ref DiscordAuthorizationArgs self, DiscordString value);

    private delegate void SetOptionalStringDelegate(ref DiscordAuthorizationArgs self, ref DiscordString value);

    private void SetString(string value, SetStringDelegate setter)
    {
        ArgumentNullException.ThrowIfNull(value);
        var nativeString = NativeString.Create(value, out var allocation);
        try
        {
            setter(ref _native, nativeString);
        }
        finally
        {
            NativeString.Free(allocation);
        }
    }

    private void SetOptionalString(string value, SetOptionalStringDelegate setter)
    {
        ArgumentNullException.ThrowIfNull(value);
        var nativeString = NativeString.Create(value, out var allocation);
        try
        {
            setter(ref _native, ref nativeString);
        }
        finally
        {
            NativeString.Free(allocation);
        }
    }

    private void ThrowIfDisposed() => ObjectDisposedException.ThrowIf(_disposed, this);
}