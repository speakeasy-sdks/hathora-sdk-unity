# roomV1

### Available Operations

* [~~CreateRoomDeprecated~~](#createroomdeprecated) - :warning: **Deprecated**
* [~~DestroyRoomDeprecated~~](#destroyroomdeprecated) - :warning: **Deprecated**
* [~~GetActiveRoomsForProcessDeprecated~~](#getactiveroomsforprocessdeprecated) - :warning: **Deprecated**
* [~~GetConnectionInfoDeprecated~~](#getconnectioninfodeprecated) - :warning: **Deprecated**
* [~~GetInactiveRoomsForProcessDeprecated~~](#getinactiveroomsforprocessdeprecated) - :warning: **Deprecated**
* [~~GetRoomInfoDeprecated~~](#getroominfodeprecated) - :warning: **Deprecated**
* [~~SuspendRoomDeprecated~~](#suspendroomdeprecated) - :warning: **Deprecated**

## ~~CreateRoomDeprecated~~

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

using(var res = await sdk.RoomV1.CreateRoomDeprecatedAsync(new CreateRoomDeprecatedSecurity() {
        Auth0 = "",
    }, new CreateRoomDeprecatedRequest() {
        CreateRoomRequest = new CreateRoomRequest() {
            Region = Hathora.Models.Shared.Region.SaoPaulo,
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

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [CreateRoomDeprecatedRequest](../../Models/Shared/CreateRoomDeprecatedRequest.md)   | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |
| `security`                                                                          | [CreateRoomDeprecatedSecurity](../../Models/RoomV1/CreateRoomDeprecatedSecurity.md) | :heavy_check_mark:                                                                  | The security requirements to use for the request.                                   |


### Response

**[CreateRoomDeprecatedResponse](../../Models/RoomV1/CreateRoomDeprecatedResponse.md)**


## ~~DestroyRoomDeprecated~~

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;

var sdk = new HathoraSDK();

using(var res = await sdk.RoomV1.DestroyRoomDeprecatedAsync(new DestroyRoomDeprecatedSecurity() {
        Auth0 = "",
    }, new DestroyRoomDeprecatedRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        RoomId = "2swovpy1fnunu",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [DestroyRoomDeprecatedRequest](../../Models/Operations/DestroyRoomDeprecatedRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |
| `security`                                                                              | [DestroyRoomDeprecatedSecurity](../../Models/RoomV1/DestroyRoomDeprecatedSecurity.md)   | :heavy_check_mark:                                                                      | The security requirements to use for the request.                                       |


### Response

**[DestroyRoomDeprecatedResponse](../../Models/RoomV1/DestroyRoomDeprecatedResponse.md)**


## ~~GetActiveRoomsForProcessDeprecated~~

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;

var sdk = new HathoraSDK();

using(var res = await sdk.RoomV1.GetActiveRoomsForProcessDeprecatedAsync(new GetActiveRoomsForProcessDeprecatedSecurity() {
        Auth0 = "",
    }, new GetActiveRoomsForProcessDeprecatedRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        ProcessId = "cbfcddd2-0006-43ae-996c-995fff7bed2e",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                         | [GetActiveRoomsForProcessDeprecatedRequest](../../Models/Operations/GetActiveRoomsForProcessDeprecatedRequest.md) | :heavy_check_mark:                                                                                                | The request object to use for the request.                                                                        |
| `security`                                                                                                        | [GetActiveRoomsForProcessDeprecatedSecurity](../../Models/RoomV1/GetActiveRoomsForProcessDeprecatedSecurity.md)   | :heavy_check_mark:                                                                                                | The security requirements to use for the request.                                                                 |


### Response

**[GetActiveRoomsForProcessDeprecatedResponse](../../Models/RoomV1/GetActiveRoomsForProcessDeprecatedResponse.md)**


## ~~GetConnectionInfoDeprecated~~

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;

var sdk = new HathoraSDK();

using(var res = await sdk.RoomV1.GetConnectionInfoDeprecatedAsync(new GetConnectionInfoDeprecatedRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        RoomId = "2swovpy1fnunu",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [GetConnectionInfoDeprecatedRequest](../../Models/Operations/GetConnectionInfoDeprecatedRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |


### Response

**[GetConnectionInfoDeprecatedResponse](../../Models/RoomV1/GetConnectionInfoDeprecatedResponse.md)**


## ~~GetInactiveRoomsForProcessDeprecated~~

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;

var sdk = new HathoraSDK();

using(var res = await sdk.RoomV1.GetInactiveRoomsForProcessDeprecatedAsync(new GetInactiveRoomsForProcessDeprecatedSecurity() {
        Auth0 = "",
    }, new GetInactiveRoomsForProcessDeprecatedRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        ProcessId = "cbfcddd2-0006-43ae-996c-995fff7bed2e",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                             | [GetInactiveRoomsForProcessDeprecatedRequest](../../Models/Operations/GetInactiveRoomsForProcessDeprecatedRequest.md) | :heavy_check_mark:                                                                                                    | The request object to use for the request.                                                                            |
| `security`                                                                                                            | [GetInactiveRoomsForProcessDeprecatedSecurity](../../Models/RoomV1/GetInactiveRoomsForProcessDeprecatedSecurity.md)   | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |


### Response

**[GetInactiveRoomsForProcessDeprecatedResponse](../../Models/RoomV1/GetInactiveRoomsForProcessDeprecatedResponse.md)**


## ~~GetRoomInfoDeprecated~~

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;

var sdk = new HathoraSDK();

using(var res = await sdk.RoomV1.GetRoomInfoDeprecatedAsync(new GetRoomInfoDeprecatedSecurity() {
        Auth0 = "",
    }, new GetRoomInfoDeprecatedRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        RoomId = "2swovpy1fnunu",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [GetRoomInfoDeprecatedRequest](../../Models/Operations/GetRoomInfoDeprecatedRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |
| `security`                                                                              | [GetRoomInfoDeprecatedSecurity](../../Models/RoomV1/GetRoomInfoDeprecatedSecurity.md)   | :heavy_check_mark:                                                                      | The security requirements to use for the request.                                       |


### Response

**[GetRoomInfoDeprecatedResponse](../../Models/RoomV1/GetRoomInfoDeprecatedResponse.md)**


## ~~SuspendRoomDeprecated~~

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;

var sdk = new HathoraSDK();

using(var res = await sdk.RoomV1.SuspendRoomDeprecatedAsync(new SuspendRoomDeprecatedSecurity() {
        Auth0 = "",
    }, new SuspendRoomDeprecatedRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        RoomId = "2swovpy1fnunu",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [SuspendRoomDeprecatedRequest](../../Models/Operations/SuspendRoomDeprecatedRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |
| `security`                                                                              | [SuspendRoomDeprecatedSecurity](../../Models/RoomV1/SuspendRoomDeprecatedSecurity.md)   | :heavy_check_mark:                                                                      | The security requirements to use for the request.                                       |


### Response

**[SuspendRoomDeprecatedResponse](../../Models/RoomV1/SuspendRoomDeprecatedResponse.md)**

