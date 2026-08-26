using Discord.Social.CSharp.Sdk.Authorization;
using Discord.Social.CSharp.Sdk.Logging;
using Discord.Social.CSharp.Native.Sdk;

namespace Discord.Social.CSharp.Sdk;

public class DiscordClient : IDisposable
{
	private DiscordClientNative _native;
	private bool _disposed;
	private DiscordClientLogCallback? _nativeLogCallback;
	private DiscordClientAuthorizationCallback? _nativeAuthorizeCallback;
	private DiscordClientOnStatusChanged? _nativeStatusChangedCallback;
	private DiscordClientTokenExchangeCallback? _nativeExchangeCallback;
	private DiscordClientUpdateTokenCallback? _nativeUpdateTokenCallback;

	public DiscordClient() => NativeDiscordClientLifecycleMethods.Discord_Client_Init(ref _native);

	public void SetApplicationId(ulong applicationId)
	{
		ObjectDisposedException.ThrowIf(_disposed, this);
		NativeDiscordClientLifecycleMethods.Discord_Client_SetApplicationId(ref _native, applicationId);
	}

	public void Connect()
	{
		ObjectDisposedException.ThrowIf(_disposed, this);
		NativeDiscordClientLifecycleMethods.Discord_Client_Connect(ref _native);
	}

	public void Authorize(AuthorizationArgs args, AuthorizationCallback callback)
	{
		ObjectDisposedException.ThrowIf(_disposed, this);
		ArgumentNullException.ThrowIfNull(args);

		_nativeAuthorizeCallback = (ref result, code, redirectUri, _) => 
			callback(new ClientResult(result), NativeString.Read(code), NativeString.Read(redirectUri));

		NativeDiscordClientAuthorizationMethods.Discord_Client_Authorize(ref _native, ref args.NativeValue, _nativeAuthorizeCallback, null!, nint.Zero);
	}

	public void UpdateToken(AuthorizationTokenType tokenType, string accessToken, ClientUpdateTokenCallback callback)
	{
		ObjectDisposedException.ThrowIf(_disposed, this);
		ArgumentNullException.ThrowIfNull(accessToken);

		_nativeUpdateTokenCallback = (ref result, _) => callback(new ClientResult(result));

		NativeDiscordClientAuthorizationMethods.Discord_Client_UpdateToken(
			ref _native, 
			(DiscordAuthorizationTokenType)tokenType, 
			NativeString.Create(accessToken, out var accessTokenAllocation),
			_nativeUpdateTokenCallback,
			null!,
			nint.Zero
		);
	}

	public void RunCallBacks()
	{
		ObjectDisposedException.ThrowIf(_disposed, this);
		NativeDiscordRuntimeMethods.Discord_RunCallbacks();
	}

	public AuthorizationCodeVerifier CreateAuthorizationCodeVerifier()
	{
		ObjectDisposedException.ThrowIf(_disposed, this);

		var codeVerifier = new DiscordAuthorizationCodeVerifier();
		NativeDiscordClientLifecycleMethods.Discord_Client_CreateAuthorizationCodeVerifier(
			ref _native,
			ref codeVerifier);
		return new AuthorizationCodeVerifier(codeVerifier);
	}

	public void GetToken(ulong applicationId, string code, string codeVerifier, string redirectUri, ClientTokenExchangeCallback callback)
	{
		ObjectDisposedException.ThrowIf(_disposed, this);

		var nativeCode = NativeString.Create(code, out var codeAllocation);
		var nativeCodeVerifier = NativeString.Create(codeVerifier, out var codeVerifierAllocation);
		var nativeRedirectUri = NativeString.Create(redirectUri, out var redirectUriAllocation);

		_nativeExchangeCallback = (ref result, accessToken, refreshToken, tokenType, expiresIn, scope, _) =>
			callback(
				new ClientResult(result),
				NativeString.Read(accessToken),
				NativeString.Read(refreshToken),
				(AuthorizationTokenType)tokenType,
				expiresIn,
				NativeString.Read(scope)
			);

		try
		{
			NativeDiscordClientAuthorizationMethods.Discord_Client_GetToken(
				ref _native, 
				applicationId, 
				nativeCode, 
				nativeCodeVerifier, 
				nativeRedirectUri, 
				_nativeExchangeCallback, 
				null!, 
				nint.Zero
			);
		}
		finally
		{
			NativeString.Free(codeAllocation);
			NativeString.Free(codeVerifierAllocation);
			NativeString.Free(redirectUriAllocation);
		}
	}

	public void RefreshToken(ulong applicationId, string refreshToken, ClientTokenExchangeCallback callback)
	{
		ObjectDisposedException.ThrowIf(_disposed, this);
		ArgumentException.ThrowIfNullOrWhiteSpace(refreshToken);

		var nativeRefreshToken = NativeString.Create(refreshToken, out var refreshTokenAllocation);
		_nativeExchangeCallback = (ref result, accessToken, returnedRefreshToken, tokenType, expiresIn, scope, _) =>
			callback(
				new ClientResult(result),
				NativeString.Read(accessToken),
				NativeString.Read(returnedRefreshToken),
				(AuthorizationTokenType)tokenType,
				expiresIn,
				NativeString.Read(scope)
			);

		try
		{
			NativeDiscordClientAuthorizationMethods.Discord_Client_RefreshToken(
				ref _native,
				applicationId,
				nativeRefreshToken,
				_nativeExchangeCallback,
				null!,
				nint.Zero
			);
		}
		finally
		{
			NativeString.Free(refreshTokenAllocation);
		}
	}

	public void AddLogCallback(LogCallback callback, LoggingSeverity severity = LoggingSeverity.Info)
	{
		ObjectDisposedException.ThrowIf(_disposed, this);
		ArgumentNullException.ThrowIfNull(callback);

		_nativeLogCallback = (message, nativeSeverity, _) =>
			callback(NativeString.Read(message), (LoggingSeverity)nativeSeverity);

		NativeDiscordClientLifecycleMethods.Discord_Client_AddLogCallback(
			ref _native,
			_nativeLogCallback,
			null!,
			nint.Zero,
			(DiscordLoggingSeverity)severity
		);
	}

	public void SetStatusChangedCallback(StatusChangedCallback callback)
	{
		ObjectDisposedException.ThrowIf(_disposed, this);
		ArgumentNullException.ThrowIfNull(callback);

		_nativeStatusChangedCallback = (status, error, errorDetail, _) =>
			callback(
				(ClientStatus)status,
				(ClientError)error,
				errorDetail);

		NativeDiscordClientLifecycleMethods.Discord_Client_SetStatusChangedCallback(
			ref _native,
			_nativeStatusChangedCallback,
			null!,
			nint.Zero
		);
	}

	public void TryStart()
	{
		ObjectDisposedException.ThrowIf(_disposed, this);
		NativeDiscordClientLifecycleMethods.Discord_Client_Connect(ref _native);
	}

	public void Dispose()
	{
		if (_disposed)
			return;

		NativeDiscordClientLifecycleMethods.Discord_Client_Drop(ref _native);
		_nativeLogCallback = null;
		_nativeStatusChangedCallback = null;
		_disposed = true;
		GC.SuppressFinalize(this);
	}
}
