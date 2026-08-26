using Discord.Social.CSharp.Native.Sdk;

namespace Discord.Social.CSharp.Sdk;

public sealed class Activity
{
	internal string? Name { get; set; }
	internal DiscordActivityType Type { get; set; } = DiscordActivityType.Playing;
	internal string? State { get; set; }
	internal string? Details { get; set; }

	public Activity(string name)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(name);
		Name = name;
	}

	public Activity WithType(DiscordActivityType type)
	{
		Type = type;
		return this;
	}

	public Activity WithState(string state)
	{
		ArgumentNullException.ThrowIfNull(state);
		State = state;
		return this;
	}

	public Activity WithDetails(string details)
	{
		ArgumentNullException.ThrowIfNull(details);
		Details = details;
		return this;
	}
}