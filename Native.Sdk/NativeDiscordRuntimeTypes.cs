using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

[StructLayout(LayoutKind.Sequential)]
internal struct DiscordClientNative
{
    internal nint Opaque0;
}

internal enum DiscordActivityActionTypes
{
    Invalid = 0,
    Join = 1,
    JoinRequest = 5,
}

internal enum DiscordActivityPartyPrivacy
{
    Private = 0,
    Public = 1,
}

public enum DiscordActivityType
{
    Playing = 0,
    Streaming = 1,
    Listening = 2,
    Watching = 3,
    CustomStatus = 4,
    Competing = 5,
    HangStatus = 6,
}

internal enum DiscordStatusDisplayTypes
{
    Name = 0,
    State = 1,
    Details = 2,
}

internal enum DiscordActivityGamePlatforms
{
    Desktop = 1,
    Xbox = 2,
    Samsung = 4,
    IOS = 8,
    Android = 16,
    Embedded = 32,
    PS4 = 64,
    PS5 = 128,
}

internal enum DiscordErrorType
{
    None = 0,
    NetworkError = 1,
    HTTPError = 2,
    ClientNotReady = 3,
    Disabled = 4,
    ClientDestroyed = 5,
    ValidationError = 6,
    Aborted = 7,
    AuthorizationFailed = 8,
    RPCError = 9,
}

internal enum DiscordHttpStatusCode
{
    None = 0,
    Continue = 100,
    SwitchingProtocols = 101,
    Processing = 102,
    EarlyHints = 103,
    Ok = 200,
    Created = 201,
    Accepted = 202,
    NonAuthoritativeInfo = 203,
    NoContent = 204,
    ResetContent = 205,
    PartialContent = 206,
    MultiStatus = 207,
    AlreadyReported = 208,
    ImUsed = 209,
    MultipleChoices = 300,
    MovedPermanently = 301,
    Found = 302,
    SeeOther = 303,
    NotModified = 304,
    TemporaryRedirect = 307,
    PermanentRedirect = 308,
    BadRequest = 400,
    Unauthorized = 401,
    PaymentRequired = 402,
    Forbidden = 403,
    NotFound = 404,
    MethodNotAllowed = 405,
    NotAcceptable = 406,
    ProxyAuthRequired = 407,
    RequestTimeout = 408,
    Conflict = 409,
    Gone = 410,
    LengthRequired = 411,
    PreconditionFailed = 412,
    PayloadTooLarge = 413,
    UriTooLong = 414,
    UnsupportedMediaType = 415,
    RangeNotSatisfiable = 416,
    ExpectationFailed = 417,
    MisdirectedRequest = 421,
    UnprocessableEntity = 422,
    Locked = 423,
    FailedDependency = 424,
    TooEarly = 425,
    UpgradeRequired = 426,
    PreconditionRequired = 428,
    TooManyRequests = 429,
    RequestHeaderFieldsTooLarge = 431,
    InternalServerError = 500,
    NotImplemented = 501,
    BadGateway = 502,
    ServiceUnavailable = 503,
    GatewayTimeout = 504,
    HttpVersionNotSupported = 505,
    VariantAlsoNegotiates = 506,
    InsufficientStorage = 507,
    LoopDetected = 508,
    NotExtended = 510,
    NetworkAuthorizationRequired = 511,
}

internal enum DiscordAuthenticationCodeChallengeMethod
{
    S256 = 0,
}

internal enum DiscordIntegrationType
{
    GuildInstall = 0,
    UserInstall = 1,
}

internal enum DiscordChannelType
{
    GuildText = 0,
    Dm = 1,
    GuildVoice = 2,
    GroupDm = 3,
    GuildCategory = 4,
    GuildNews = 5,
    GuildStore = 6,
    GuildNewsThread = 10,
    GuildPublicThread = 11,
    GuildPrivateThread = 12,
    GuildStageVoice = 13,
    GuildDirectory = 14,
    GuildForum = 15,
    GuildMedia = 16,
    Lobby = 17,
    EphemeralDm = 18,
}

internal enum DiscordAdditionalContentType
{
    Other = 0,
    Attachment = 1,
    Poll = 2,
    VoiceMessage = 3,
    Thread = 4,
    Embed = 5,
    Sticker = 6,
}

internal enum DiscordAudioSystem
{
    Standard = 0,
    Game = 1,
}

internal enum DiscordCallError
{
    None = 0,
    SignalingConnectionFailed = 1,
    SignalingUnexpectedClose = 2,
    VoiceConnectionFailed = 3,
    JoinTimeout = 4,
    Forbidden = 5,
}

internal enum DiscordAudioModeType
{
    MODE_UNINIT = 0,
    MODE_VAD = 1,
    MODE_PTT = 2,
}

internal enum DiscordCallStatus
{
    Disconnected = 0,
    Joining = 1,
    Connecting = 2,
    SignalingConnected = 3,
    Connected = 4,
    Reconnecting = 5,
    Disconnecting = 6,
}

internal enum DiscordRelationshipType
{
    None = 0,
    Friend = 1,
    Blocked = 2,
    PendingIncoming = 3,
    PendingOutgoing = 4,
    Implicit = 5,
    Suggestion = 6,
}

internal enum DiscordExternalIdentityProviderType
{
    OIDC = 0,
    EpicOnlineServices = 1,
    Steam = 2,
    Unity = 3,
    DiscordBot = 4,
    None = 5,
    Unknown = 6,
}

internal enum DiscordUserHandleAvatarType
{
    Gif = 0,
    Webp = 1,
    Png = 2,
    Jpeg = 3,
}

internal enum DiscordStatusType
{
    Online = 0,
    Offline = 1,
    Blocked = 2,
    Idle = 3,
    Dnd = 4,
    Invisible = 5,
    Streaming = 6,
    Unknown = 7,
}

internal enum DiscordDisclosureTypes
{
    MessageDataVisibleOnDiscord = 3,
}

internal enum DiscordClientError
{
    None = 0,
    ConnectionFailed = 1,
    UnexpectedClose = 2,
    ConnectionCanceled = 3,
}

internal enum DiscordClientStatus
{
    Disconnected = 0,
    Connecting = 1,
    Connected = 2,
    Ready = 3,
    Reconnecting = 4,
    Disconnecting = 5,
    HttpWait = 6,
}

internal enum DiscordClientThread
{
    Client = 0,
    Voice = 1,
    Network = 2,
}

internal enum DiscordAuthorizationTokenType
{
    User = 0,
    Bearer = 1,
}

internal enum DiscordAuthenticationExternalAuthType
{
    OIDC = 0,
    EpicOnlineServicesAccessToken = 1,
    EpicOnlineServicesIdToken = 2,
    SteamSessionTicket = 3,
    UnityServicesIdToken = 4,
    DiscordBotIssuedAccessToken = 5,
    AppleIdToken = 6,
    PlayStationNetworkIdToken = 7,
}

internal enum DiscordLoggingSeverity
{
    Verbose = 1,
    Info = 2,
    Warning = 3,
    Error = 4,
    None = 5,
}

internal enum DiscordRelationshipGroupType
{
    OnlinePlayingGame = 0,
    OnlineElsewhere = 1,
    Offline = 2,
}
