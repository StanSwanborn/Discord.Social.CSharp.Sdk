# Discord.Social.CSharp.Sdk

C# wrapper around the C++ Discord Social SDK that aims to mirror the official reference documentation and provide a clear, idiomatic C# API surface.

Status: Early alpha — APIs may change. See the `Version` in the project file (Discord.Social.CSharp.Sdk.csproj) for the current package version.

---

## Table of contents

- [Overview](#overview)
- [Features](#features)
- [Requirements](#requirements)
- [Installation (NuGet)](#installation-nuget)
- [Quick start](#quick-start)
- [Building from source](#building-from-source)
- [Native dependencies](#native-dependencies)
- [API surface (high level)](#api-surface-high-level)
- [Contributing](#contributing)
- [License](#license)
- [Acknowledgements & links](#acknowledgements--links)

---

## Overview

This library provides a managed C# wrapper around Discord's Social (Partner) SDK, exposing native functionality (authorization, rich presence, relationships, lobbies, voice, messaging, etc.) through a safe, memory-managed API.

It uses P/Invoke to call the native `discord_partner_sdk` library and ships convenience types and delegates to make integration straightforward in .NET applications.

Note: this project is an interoperability layer only — you still need the native partner SDK binary for your platform at runtime.

## Features

- Managed C# types and wrappers for Discord Social SDK concepts (Client, Authorization, Relationships, Rich Presence, Lobbies, Calls).
- Thin, low-overhead P/Invoke bindings that mirror the native API to keep behavior predictable.
- Examples and helpers for common tasks (authorize users, update rich presence, manage lobbies).

## Requirements

- .NET 10.0 or later (TargetFramework is `net10.0` in the project file).
- Native Discord partner SDK library for your target OS (see "Native dependencies" below).

## Installation (NuGet)

The package ID in the project is:

- `Discord.Social.CSharp.Sdk`

Current project version (from the .csproj): `0.1.0-alpha.1` (this may change). If the package is published to NuGet, install with:

```bash
dotnet add package Discord.Social.CSharp.Sdk --version 0.1.0-alpha.1
```

If the package is not on NuGet yet, clone and build from source (see next section).

## Quick start

Below is a minimal example demonstrating the primary usage pattern. This example shows creating the client, setting the application id, connecting, updating rich presence, and running callbacks.

```csharp
using Discord.Social.CSharp.Sdk;
using Discord.Social.CSharp.Sdk.RichPresence;

class Program
{
    static void Main()
    {
        using var client = new DiscordClient();

        // Set Discord ApplicationId
        client.SetApplicationId(discordOptions.Value.ApplicationId);

        // Setup logging
        client.AddLogCallback((message, severity) =>
            Console.WriteLine($"[{severity}] {message}"), LoggingSeverity.Info
        );
        
        client.SetStatusChangedCallback((status, error, errorDetail) =>
            Console.WriteLine($"Status changed: {status}, Error: {error}, Detail: {errorDetail}")
        );

        Console.WriteLine("Attempting OAuth authorization on Discord account...");

        var codeVerifier    = client.CreateAuthorizationCodeVerifier();
        var authArgs        = new AuthorizationArgs();

        authArgs.SetClientId(discordOptions.ApplicationId);
        authArgs.SetScopes(DiscordClientExtensions.GetDefaultPresenceScopes());
        authArgs.SetCodeChallenge(codeVerifier.Challenge());

        client.Authorize(authArgs, (result, code, redirectUri) =>
        {
            using (result) if (!result.Successful) throw new OAuthFailedException();

            # Successfully authorized with OAuth against Discord account, retrieve Access Token.
            client.GetToken(discordOptions.ApplicationId, code, codeVerifier.Verifier, redirectUri, (result, accessToken, refreshToken, tokenType, expiresIn, scope) =>
            {
                using (result) if (!result.Successful || string.IsNullOrWhiteSpace(accessToken)) throw new OAuthFailedException();

                // Successfully retrieved token, update into local client
                client.UpdateToken(token.TokenType, token.AccessToken, (result) =>
                {
                    Console.WriteLine("Successfully updated token! ✓");
                });
            });
        });

        // We have authorized, updated the access token and can now connect to the client.
        client.Connect();

        // In your application's main loop call RunCallBacks regularly
        while (true)
        {
            client.RunCallBacks();
            Thread.Sleep(100);
        }
    }
}
```

This is only a simple snippet. Refer to the SDK folder in the repository for more types and detailed examples.

## Building from source

1. Clone the repository:

```bash
git clone https://github.com/StanSwanborn/Discord.Social.CSharp.Sdk.git
cd Discord.Social.CSharp.Sdk
```

2. Restore and build:

```bash
dotnet restore
dotnet build -c Release
```

3. Run tests or example projects if any (none included in the repo at the time of writing).

## Native dependencies

This wrapper requires the native Discord partner SDK binary at runtime. The repository contains one copy for Linux under `native/linux/libdiscord_partner_sdk.so` and the .csproj is configured to copy that into output for Linux builds.

If you target other platforms, provide the corresponding native library for each platform and ensure the runtime loader can find it at executable/runtime path. Typical options:

- Place the native library next to your executable.
- Add the native library to a folder and set the appropriate environment variable or use the OS-specific loader path.
- On Windows the native DLL name will likely differ (e.g. `discord_partner_sdk.dll`) — ensure you provide the correct file and update the project packaging if you want to ship multiple platform variants.

Important: The included native library is platform-specific. Check the upstream Discord partner SDK licensing and distribution restrictions before redistributing the native binaries.

## API surface (high level)

The primary entrypoint is `DiscordClient` in `Sdk/DiscordClient.cs` which exposes methods such as:

- `SetApplicationId(ulong applicationId)` — set app id
- `Connect()` — connect the client
- `UpdateRichPresence(Activity activity, ClientUpdateRichPresenceCallback callback)` — update rich presence
- `Authorize(AuthorizationArgs args, AuthorizationCallback callback)` — start authorization flow
- `UpdateToken(...)`, `RunCallBacks()`, and many more related to relationships, lobbies, calls, and messages.

Explore the `Sdk/` and `Native.Sdk/` folders for the complete set of bindings and helper types.

## Contributing

Contributions are welcome. A few guidelines:

- Open issues for bugs and feature requests.
- Use feature branches and submit pull requests with clear descriptions.
- Add tests or examples for new functionality when appropriate.
- If you modify or redistribute native binaries, include details about where you obtained them and ensure you comply with their license.

If you'd like, I can open a CONTRIBUTING.md file with a suggested template and PR checklist.

## License

There is no LICENSE file in the repository at the time of this edit. Please add an explicit license (MIT, Apache-2.0, or another license) so consumers know how they can use this code. If you want, I can add a permissive MIT LICENSE file as a PR or commit — tell me which license you prefer.

## Acknowledgements & links

- Project: https://github.com/StanSwanborn/Discord.Social.CSharp.Sdk
- The project was created to expose the Discord Partner (Social) SDK to .NET.

Notes from code search: I inspected several source files for the README (e.g., Sdk/DiscordClient.cs, Native.Sdk/*) to collect API and native-dependency details. Code search results may be incomplete — view the repository search page for more files: https://github.com/StanSwanborn/Discord.Social.CSharp.Sdk/search

---

If you'd like, I can also:

- Add a dedicated NuGet-specific README (if you want different content in the package than in the repo),
- Add a LICENSE file (MIT/Apache),
- Add a GitHub Actions workflow to build and publish a NuGet package, or
- Create example projects showing complete authorization flows and platform packaging.
