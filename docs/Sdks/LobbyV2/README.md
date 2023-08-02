# lobbyV2

## Overview

Operations to create and manage [lobbies](https://hathora.dev/docs/concepts/hathora-entities#lobby).

### Available Operations

* [CreateLobby](#createlobby) - Create a new [lobby](https://hathora.dev/docs/concepts/hathora-entities#lobby) for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.
* [~~CreateLocalLobby~~](#createlocallobby) - :warning: **Deprecated**
* [~~CreatePrivateLobby~~](#createprivatelobby) - :warning: **Deprecated**
* [~~CreatePublicLobby~~](#createpubliclobby) - :warning: **Deprecated**
* [GetLobbyInfo](#getlobbyinfo) - Get details for an existing [lobby](https://hathora.dev/docs/concepts/hathora-entities#lobby) using `appId` and `roomId`.
* [ListActivePublicLobbies](#listactivepubliclobbies) - Get all active [lobbies](https://hathora.dev/docs/concepts/hathora-entities#lobby) for a given [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Filter the array by optionally passing in a `region`.
* [SetLobbyState](#setlobbystate) - Set the state of a [lobby](https://hathora.dev/docs/concepts/hathora-entities#lobby) using `appId` and `roomId`. State is intended to be set by the server and must be smaller than 1MB.

## CreateLobby

Create a new [lobby](https://hathora.dev/docs/concepts/hathora-entities#lobby) for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.

### Example Usage

```unity
using Hathora;
using Hathora.Models.LobbyV2;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

var res = await sdk.LobbyV2.CreateLobbyAsync(new CreateLobbyRequest() {
    CreateLobbyRequest = new CreateLobbyRequest() {
        InitialConfig = new LobbyInitialConfig() {},
        Region = Hathora.Models.Shared.Region.SaoPaulo,
        Visibility = Hathora.Models.Shared.LobbyVisibility.Private,
    },
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    RoomId = "2swovpy1fnunu",
});
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [CreateLobbyRequest](../../Models/Shared/CreateLobbyRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[CreateLobbyResponse](../../Models/LobbyV2/CreateLobbyResponse.md)**


## ~~CreateLocalLobby~~

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```unity
using Hathora;
using Hathora.Models.LobbyV2;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

var res = await sdk.LobbyV2.CreateLocalLobbyAsync(new CreateLocalLobbyRequest() {
    RequestBody = new CreateLocalLobbyRequestBody() {
        InitialConfig = new LobbyInitialConfig() {},
        Region = Hathora.Models.Shared.Region.Chicago,
    },
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    RoomId = "2swovpy1fnunu",
});
```

### Parameters

| Parameter                                                                  | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `request`                                                                  | [CreateLocalLobbyRequest](../../Models/LobbyV2/CreateLocalLobbyRequest.md) | :heavy_check_mark:                                                         | The request object to use for the request.                                 |


### Response

**[CreateLocalLobbyResponse](../../Models/LobbyV2/CreateLocalLobbyResponse.md)**


## ~~CreatePrivateLobby~~

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```unity
using Hathora;
using Hathora.Models.LobbyV2;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

var res = await sdk.LobbyV2.CreatePrivateLobbyAsync(new CreatePrivateLobbyRequest() {
    RequestBody = new CreatePrivateLobbyRequestBody() {
        InitialConfig = new LobbyInitialConfig() {},
        Region = Hathora.Models.Shared.Region.London,
    },
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    RoomId = "2swovpy1fnunu",
});
```

### Parameters

| Parameter                                                                      | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `request`                                                                      | [CreatePrivateLobbyRequest](../../Models/LobbyV2/CreatePrivateLobbyRequest.md) | :heavy_check_mark:                                                             | The request object to use for the request.                                     |


### Response

**[CreatePrivateLobbyResponse](../../Models/LobbyV2/CreatePrivateLobbyResponse.md)**


## ~~CreatePublicLobby~~

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```unity
using Hathora;
using Hathora.Models.LobbyV2;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

var res = await sdk.LobbyV2.CreatePublicLobbyAsync(new CreatePublicLobbyRequest() {
    RequestBody = new CreatePublicLobbyRequestBody() {
        InitialConfig = new LobbyInitialConfig() {},
        Region = Hathora.Models.Shared.Region.Frankfurt,
    },
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    RoomId = "2swovpy1fnunu",
});
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `request`                                                                    | [CreatePublicLobbyRequest](../../Models/LobbyV2/CreatePublicLobbyRequest.md) | :heavy_check_mark:                                                           | The request object to use for the request.                                   |


### Response

**[CreatePublicLobbyResponse](../../Models/LobbyV2/CreatePublicLobbyResponse.md)**


## GetLobbyInfo

Get details for an existing [lobby](https://hathora.dev/docs/concepts/hathora-entities#lobby) using `appId` and `roomId`.

### Example Usage

```unity
using Hathora;
using Hathora.Models.LobbyV2;

var sdk = new HathoraSDK();

var res = await sdk.LobbyV2.GetLobbyInfoAsync(new GetLobbyInfoRequest() {
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    RoomId = "2swovpy1fnunu",
});
```

### Parameters

| Parameter                                                          | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `request`                                                          | [GetLobbyInfoRequest](../../Models/LobbyV2/GetLobbyInfoRequest.md) | :heavy_check_mark:                                                 | The request object to use for the request.                         |


### Response

**[GetLobbyInfoResponse](../../Models/LobbyV2/GetLobbyInfoResponse.md)**


## ListActivePublicLobbies

Get all active [lobbies](https://hathora.dev/docs/concepts/hathora-entities#lobby) for a given [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Filter the array by optionally passing in a `region`.

### Example Usage

```unity
using Hathora;
using Hathora.Models.LobbyV2;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

var res = await sdk.LobbyV2.ListActivePublicLobbiesAsync(new ListActivePublicLobbiesRequest() {
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    Region = Hathora.Models.Shared.Region.Tokyo,
});
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `request`                                                                                | [ListActivePublicLobbiesRequest](../../Models/LobbyV2/ListActivePublicLobbiesRequest.md) | :heavy_check_mark:                                                                       | The request object to use for the request.                                               |


### Response

**[ListActivePublicLobbiesResponse](../../Models/LobbyV2/ListActivePublicLobbiesResponse.md)**


## SetLobbyState

Set the state of a [lobby](https://hathora.dev/docs/concepts/hathora-entities#lobby) using `appId` and `roomId`. State is intended to be set by the server and must be smaller than 1MB.

### Example Usage

```unity
using Hathora;
using Hathora.Models.LobbyV2;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

var res = await sdk.LobbyV2.SetLobbyStateAsync(new SetLobbyStateSecurity() {
    Auth0 = "",
}, new SetLobbyStateRequest() {
    SetLobbyStateRequest = new SetLobbyStateRequest() {
        State = new SetLobbyStateRequestState() {},
    },
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    RoomId = "2swovpy1fnunu",
});
```

### Parameters

| Parameter                                                              | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `request`                                                              | [SetLobbyStateRequest](../../Models/Shared/SetLobbyStateRequest.md)    | :heavy_check_mark:                                                     | The request object to use for the request.                             |
| `security`                                                             | [SetLobbyStateSecurity](../../Models/LobbyV2/SetLobbyStateSecurity.md) | :heavy_check_mark:                                                     | The security requirements to use for the request.                      |


### Response

**[SetLobbyStateResponse](../../Models/LobbyV2/SetLobbyStateResponse.md)**

