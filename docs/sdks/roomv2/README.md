# roomV2

## Overview

Operations to create, manage, and connect to [rooms](https://hathora.dev/docs/concepts/hathora-entities#room).

### Available Operations

* [CreateRoom](#createroom) - Create a new [room](https://hathora.dev/docs/concepts/hathora-entities#room) for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application). Poll the [`GetConnectionInfo()`](https://hathora.dev/api#tag/RoomV2/operation/GetConnectionInfo) endpoint to get connection details for an active room.
* [DestroyRoom](#destroyroom) - Destroy a [room](https://hathora.dev/docs/concepts/hathora-entities#room). All associated metadata is deleted.
* [GetActiveRoomsForProcess](#getactiveroomsforprocess) - Get all active [rooms](https://hathora.dev/docs/concepts/hathora-entities#room) for a given [process](https://hathora.dev/docs/concepts/hathora-entities#process).
* [GetConnectionInfo](#getconnectioninfo) - Poll this endpoint to get connection details to a [room](https://hathora.dev/docs/concepts/hathora-entities#room). Clients can call this endpoint without authentication.
* [GetInactiveRoomsForProcess](#getinactiveroomsforprocess) - Get all inactive [rooms](https://hathora.dev/docs/concepts/hathora-entities#room) for a given [process](https://hathora.dev/docs/concepts/hathora-entities#process).
* [GetRoomInfo](#getroominfo) - Retreive current and historical allocation data for a [room](https://hathora.dev/docs/concepts/hathora-entities#room).
* [SuspendRoom](#suspendroom) - Suspend a [room](https://hathora.dev/docs/concepts/hathora-entities#room). The room is unallocated from the process but can be rescheduled later using the same `roomId`.

## CreateRoom

Create a new [room](https://hathora.dev/docs/concepts/hathora-entities#room) for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application). Poll the [`GetConnectionInfo()`](https://hathora.dev/api#tag/RoomV2/operation/GetConnectionInfo) endpoint to get connection details for an active room.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

using(var res = await sdk.RoomV2.CreateRoomAsync(new CreateRoomSecurity() {
        Auth0 = "",
    }, new CreateRoomRequest() {
        CreateRoomRequest = new CreateRoomRequest() {
            Region = Hathora.Models.Shared.Region.Tokyo,
            RoomConfig = "{"name":"my-room"}",
        },
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        RoomId = "2swovpy1fnunu",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [CreateRoomRequest](../../Models/Shared/CreateRoomRequest.md)   | :heavy_check_mark:                                              | The request object to use for the request.                      |
| `security`                                                      | [CreateRoomSecurity](../../Models/RoomV2/CreateRoomSecurity.md) | :heavy_check_mark:                                              | The security requirements to use for the request.               |


### Response

**[CreateRoomResponse](../../Models/RoomV2/CreateRoomResponse.md)**


## DestroyRoom

Destroy a [room](https://hathora.dev/docs/concepts/hathora-entities#room). All associated metadata is deleted.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;

var sdk = new HathoraSDK();

using(var res = await sdk.RoomV2.DestroyRoomAsync(new DestroyRoomSecurity() {
        Auth0 = "",
    }, new DestroyRoomRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        RoomId = "2swovpy1fnunu",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [DestroyRoomRequest](../../Models/Operations/DestroyRoomRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |
| `security`                                                          | [DestroyRoomSecurity](../../Models/RoomV2/DestroyRoomSecurity.md)   | :heavy_check_mark:                                                  | The security requirements to use for the request.                   |


### Response

**[DestroyRoomResponse](../../Models/RoomV2/DestroyRoomResponse.md)**


## GetActiveRoomsForProcess

Get all active [rooms](https://hathora.dev/docs/concepts/hathora-entities#room) for a given [process](https://hathora.dev/docs/concepts/hathora-entities#process).

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;

var sdk = new HathoraSDK();

using(var res = await sdk.RoomV2.GetActiveRoomsForProcessAsync(new GetActiveRoomsForProcessSecurity() {
        Auth0 = "",
    }, new GetActiveRoomsForProcessRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        ProcessId = "cbfcddd2-0006-43ae-996c-995fff7bed2e",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [GetActiveRoomsForProcessRequest](../../Models/Operations/GetActiveRoomsForProcessRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |
| `security`                                                                                    | [GetActiveRoomsForProcessSecurity](../../Models/RoomV2/GetActiveRoomsForProcessSecurity.md)   | :heavy_check_mark:                                                                            | The security requirements to use for the request.                                             |


### Response

**[GetActiveRoomsForProcessResponse](../../Models/RoomV2/GetActiveRoomsForProcessResponse.md)**


## GetConnectionInfo

Poll this endpoint to get connection details to a [room](https://hathora.dev/docs/concepts/hathora-entities#room). Clients can call this endpoint without authentication.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;

var sdk = new HathoraSDK();

using(var res = await sdk.RoomV2.GetConnectionInfoAsync(new GetConnectionInfoRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        RoomId = "2swovpy1fnunu",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetConnectionInfoRequest](../../Models/Operations/GetConnectionInfoRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[GetConnectionInfoResponse](../../Models/RoomV2/GetConnectionInfoResponse.md)**


## GetInactiveRoomsForProcess

Get all inactive [rooms](https://hathora.dev/docs/concepts/hathora-entities#room) for a given [process](https://hathora.dev/docs/concepts/hathora-entities#process).

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;

var sdk = new HathoraSDK();

using(var res = await sdk.RoomV2.GetInactiveRoomsForProcessAsync(new GetInactiveRoomsForProcessSecurity() {
        Auth0 = "",
    }, new GetInactiveRoomsForProcessRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        ProcessId = "cbfcddd2-0006-43ae-996c-995fff7bed2e",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [GetInactiveRoomsForProcessRequest](../../Models/Operations/GetInactiveRoomsForProcessRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |
| `security`                                                                                        | [GetInactiveRoomsForProcessSecurity](../../Models/RoomV2/GetInactiveRoomsForProcessSecurity.md)   | :heavy_check_mark:                                                                                | The security requirements to use for the request.                                                 |


### Response

**[GetInactiveRoomsForProcessResponse](../../Models/RoomV2/GetInactiveRoomsForProcessResponse.md)**


## GetRoomInfo

Retreive current and historical allocation data for a [room](https://hathora.dev/docs/concepts/hathora-entities#room).

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;

var sdk = new HathoraSDK();

using(var res = await sdk.RoomV2.GetRoomInfoAsync(new GetRoomInfoSecurity() {
        Auth0 = "",
    }, new GetRoomInfoRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        RoomId = "2swovpy1fnunu",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [GetRoomInfoRequest](../../Models/Operations/GetRoomInfoRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |
| `security`                                                          | [GetRoomInfoSecurity](../../Models/RoomV2/GetRoomInfoSecurity.md)   | :heavy_check_mark:                                                  | The security requirements to use for the request.                   |


### Response

**[GetRoomInfoResponse](../../Models/RoomV2/GetRoomInfoResponse.md)**


## SuspendRoom

Suspend a [room](https://hathora.dev/docs/concepts/hathora-entities#room). The room is unallocated from the process but can be rescheduled later using the same `roomId`.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;

var sdk = new HathoraSDK();

using(var res = await sdk.RoomV2.SuspendRoomAsync(new SuspendRoomSecurity() {
        Auth0 = "",
    }, new SuspendRoomRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        RoomId = "2swovpy1fnunu",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [SuspendRoomRequest](../../Models/Operations/SuspendRoomRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |
| `security`                                                          | [SuspendRoomSecurity](../../Models/RoomV2/SuspendRoomSecurity.md)   | :heavy_check_mark:                                                  | The security requirements to use for the request.                   |


### Response

**[SuspendRoomResponse](../../Models/RoomV2/SuspendRoomResponse.md)**

