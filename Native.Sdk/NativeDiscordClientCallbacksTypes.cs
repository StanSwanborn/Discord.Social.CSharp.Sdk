using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordFreeFn(nint ptr);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordCallOnVoiceStateChanged(ulong userId, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordCallOnParticipantChanged(ulong userId, [MarshalAs(UnmanagedType.I1)] bool added, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordCallOnSpeakingStatusChanged(ulong userId, [MarshalAs(UnmanagedType.I1)] bool isPlayingSound, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordCallOnStatusChanged(DiscordCallStatus status, DiscordCallError error, int errorDetail, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientEndCallCallback(nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientEndCallsCallback(nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientGetCurrentInputDeviceCallback(ref DiscordAudioDevice device, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientGetCurrentOutputDeviceCallback(ref DiscordAudioDevice device, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientGetInputDevicesCallback(DiscordAudioDeviceSpan devices, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientGetOutputDevicesCallback(DiscordAudioDeviceSpan devices, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientDeviceChangeCallback(DiscordAudioDeviceSpan inputDevices, DiscordAudioDeviceSpan outputDevices, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientSetInputDeviceCallback(ref DiscordClientResultNative result, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientNoAudioInputCallback([MarshalAs(UnmanagedType.I1)] bool inputDetected, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientSetOutputDeviceCallback(ref DiscordClientResultNative result, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientVoiceParticipantChangedCallback(ulong lobbyId, ulong memberId, [MarshalAs(UnmanagedType.I1)] bool added, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientUserAudioReceivedCallback(ulong userId, ref short data, ulong samplesPerChannel, int sampleRate, ulong channels, ref bool outShouldMute, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientUserAudioCapturedCallback(ref short data, ulong samplesPerChannel, int sampleRate, ulong channels, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientAuthorizationCallback(ref DiscordClientResultNative result, DiscordString code, DiscordString redirectUri, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientExchangeChildTokenCallback(ref DiscordClientResultNative result, DiscordString accessToken, DiscordAuthorizationTokenType tokenType, int expiresIn, DiscordString scopes, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientFetchCurrentUserCallback(ref DiscordClientResultNative result, ulong id, DiscordString name, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientTokenExchangeCallback(ref DiscordClientResultNative result, DiscordString accessToken, DiscordString refreshToken, DiscordAuthorizationTokenType tokenType, int expiresIn, DiscordString scopes, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientAuthorizeRequestCallback(nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientRevokeTokenCallback(ref DiscordClientResultNative result, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientAuthorizeDeviceScreenClosedCallback(nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientTokenExpirationCallback(nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientUnmergeIntoProvisionalAccountCallback(ref DiscordClientResultNative result, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientUpdateProvisionalAccountDisplayNameCallback(ref DiscordClientResultNative result, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientUpdateTokenCallback(ref DiscordClientResultNative result, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientDeleteUserMessageCallback(ref DiscordClientResultNative result, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientEditUserMessageCallback(ref DiscordClientResultNative result, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientGetLobbyMessagesCallback(ref DiscordClientResultNative result, DiscordMessageHandleSpan messages, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientUserMessageSummariesCallback(ref DiscordClientResultNative result, DiscordUserMessageSummarySpan summaries, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientUserMessagesWithLimitCallback(ref DiscordClientResultNative result, DiscordMessageHandleSpan messages, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientProvisionalUserMergeRequiredCallback(nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientOpenMessageInDiscordCallback(ref DiscordClientResultNative result, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientSendUserMessageCallback(ref DiscordClientResultNative result, ulong messageId, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientMessageCreatedCallback(ulong messageId, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientMessageDeletedCallback(ulong messageId, ulong channelId, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientMessageUpdatedCallback(ulong messageId, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientLogCallback(DiscordString message, DiscordLoggingSeverity severity, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientOpenConnectedGamesSettingsInDiscordCallback(ref DiscordClientResultNative result, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientOnStatusChanged(DiscordClientStatus status, DiscordClientError error, int errorDetail, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientCreateOrJoinLobbyCallback(ref DiscordClientResultNative result, ulong lobbyId, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientGetGuildChannelsCallback(ref DiscordClientResultNative result, DiscordGuildChannelSpan guildChannels, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientGetUserGuildsCallback(ref DiscordClientResultNative result, DiscordGuildMinimalSpan guilds, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientJoinLinkedLobbyGuildCallback(ref DiscordClientResultNative result, DiscordString inviteUrl, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientLeaveLobbyCallback(ref DiscordClientResultNative result, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientLinkOrUnlinkChannelCallback(ref DiscordClientResultNative result, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientLobbyCreatedCallback(ulong lobbyId, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientLobbyDeletedCallback(ulong lobbyId, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientLobbyMemberAddedCallback(ulong lobbyId, ulong memberId, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientLobbyMemberRemovedCallback(ulong lobbyId, ulong memberId, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientLobbyMemberUpdatedCallback(ulong lobbyId, ulong memberId, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientLobbyUpdatedCallback(ulong lobbyId, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientIsDiscordAppInstalledCallback([MarshalAs(UnmanagedType.I1)] bool installed, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientAcceptActivityInviteCallback(ref DiscordClientResultNative result, DiscordString joinSecret, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientSendActivityInviteCallback(ref DiscordClientResultNative result, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientActivityInviteCallback(ref DiscordActivityInvite invite, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientActivityJoinCallback(DiscordString joinSecret, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientActivityJoinWithApplicationCallback(ulong applicationId, DiscordString joinSecret, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientUpdateStatusCallback(ref DiscordClientResultNative result, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientUpdateRichPresenceCallback(ref DiscordClientResultNative result, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientUpdateRelationshipCallback(ref DiscordClientResultNative result, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientSendFriendRequestCallback(ref DiscordClientResultNative result, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientRelationshipCreatedCallback(ulong userId, [MarshalAs(UnmanagedType.I1)] bool isDiscordRelationshipUpdate, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientRelationshipDeletedCallback(ulong userId, [MarshalAs(UnmanagedType.I1)] bool isDiscordRelationshipUpdate, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientGetDiscordClientConnectedUserCallback(ref DiscordClientResultNative result, ref DiscordUserHandle user, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientRelationshipGroupsUpdatedCallback(ulong userId, nint userData);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DiscordClientUserUpdatedCallback(ulong userId, nint userData);
