using Discord.Social.CSharp.Native.Sdk;

public sealed class ActivityButton : IDisposable
{
    private DiscordActivityButton _native;
    private nint _labelAllocation;
    private nint _urlAllocation;
    private bool _disposed;

    public ActivityButton() => NativeDiscordActivityMethods.Discord_ActivityButton_Init(ref _native);

    public void SetLabel(string label) =>
        NativeDiscordActivityMethods.Discord_ActivityButton_SetLabel(ref _native, NativeString.Create(label, out _labelAllocation));

    public void SetURL(string URL) =>
        NativeDiscordActivityMethods.Discord_ActivityButton_SetUrl(ref _native, NativeString.Create(URL, out _urlAllocation));

    internal ref DiscordActivityButton NativeValue
	{
		get
		{
			return ref _native;
		}
	}

    public void Dispose()
    {
        if(_disposed)
            return;

        NativeDiscordActivityMethods.Discord_ActivityButton_Drop(ref _native);

        NativeString.Free(_labelAllocation);
        NativeString.Free(_urlAllocation);

        _disposed = true;
    }
}