using Discord.Social.CSharp.Native.Sdk;

namespace Discord.Social.CSharp.Sdk.Relationships;

public record RelationshipHandleSpan
{
    internal DiscordRelationshipHandleSpan _native;

    public nuint Size { get; init; }

    internal DiscordRelationshipHandleSpan NativeValue
    {
        get { return _native; }
        init { _native = value; }
    }
}