using Discord.Social.CSharp.Native.Sdk;

namespace Discord.Social.CSharp.Sdk.RichPresence;

public enum ActivityType
{
	Playing = 0,
    Streaming = 1,
    Listening = 2,
    Watching = 3,
    CustomStatus = 4,
    Competing = 5,
    HangStatus = 6,
}

public sealed class Activity : IDisposable
{
	private DiscordActivityNative _native;
	private bool _disposed;

	public Activity() => NativeDiscordActivityMethods.Discord_Activity_Init(ref _native);

	public void SetName(string name)
	{
		ThrowIfDisposed();
		SetString(name, NativeDiscordActivityMethods.Discord_Activity_SetName);
	}

	public void SetType(ActivityType type)
	{
		ThrowIfDisposed();
		NativeDiscordActivityMethods.Discord_Activity_SetType(ref _native, (DiscordActivityType)type);
	}

	public void SetState(string state)
	{
		ThrowIfDisposed();
		SetOptionalString(state, NativeDiscordActivityMethods.Discord_Activity_SetState);
	}

	public void SetDetails(string details)
	{
		ThrowIfDisposed();
		SetOptionalString(details, NativeDiscordActivityMethods.Discord_Activity_SetDetails);
	}

	public void AddButton(ActivityButton button)
	{
		ThrowIfDisposed();
		NativeDiscordActivityMethods.Discord_Activity_AddButton(ref _native, ref button.NativeValue);
	}

	public void Dispose()
	{
		if (_disposed)
			return;

		NativeDiscordActivityMethods.Discord_Activity_Drop(ref _native);
		_disposed = true;
		GC.SuppressFinalize(this);
	}

	~Activity() => Dispose();

	internal ref DiscordActivityNative NativeValue
	{
		get
		{
			ThrowIfDisposed();
			return ref _native;
		}
	}

	private delegate void SetStringDelegate(ref DiscordActivityNative self, DiscordString value);

	private delegate void SetOptionalStringDelegate(ref DiscordActivityNative self, ref DiscordString value);

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