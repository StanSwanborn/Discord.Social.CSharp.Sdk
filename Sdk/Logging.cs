namespace Discord.Social.CSharp.Sdk.Logging;

public enum LoggingSeverity
{
    Verbose = 1,
    Info = 2,
    Warning = 3,
    Error = 4,
    None = 5
}

public delegate void LogCallback(string message, LoggingSeverity severity);

public enum ClientStatus
{
    Disconnected = 0,
    Connecting = 1,
    Connected = 2,
    Ready = 3,
    Reconnecting = 4,
    Disconnecting = 5,
    HttpWait = 6
}

public enum ClientError
{
    None = 0,
    ConnectionFailed = 1,
    UnexpectedClose = 2,
    ConnectionCanceled = 3
}

public delegate void StatusChangedCallback(
    ClientStatus status,
    ClientError error,
    int errorDetail);