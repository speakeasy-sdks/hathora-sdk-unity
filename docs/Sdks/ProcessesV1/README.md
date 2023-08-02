# processesV1

## Overview

Operations to get data on active and stopped [processes](https://hathora.dev/docs/concepts/hathora-entities#process).

### Available Operations

* [GetProcessInfo](#getprocessinfo) - Get details for an existing [process](https://hathora.dev/docs/concepts/hathora-entities#process) using `appId` and `processId`.
* [GetRunningProcesses](#getrunningprocesses) - Returns an array of active [process](https://hathora.dev/docs/concepts/hathora-entities#process) objects for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Filter the array by optionally passing in a region.
* [GetStoppedProcesses](#getstoppedprocesses) - Returns an array of stopped [process](https://hathora.dev/docs/concepts/hathora-entities#process) objects for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Filter the array by optionally passing in a region.

## GetProcessInfo

Get details for an existing [process](https://hathora.dev/docs/concepts/hathora-entities#process) using `appId` and `processId`.

### Example Usage

```unity
using Hathora;
using Hathora.Models.ProcessesV1;

var sdk = new HathoraSDK();

var res = await sdk.ProcessesV1.GetProcessInfoAsync(new GetProcessInfoSecurity() {
    Auth0 = "",
}, new GetProcessInfoRequest() {
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    ProcessId = "cbfcddd2-0006-43ae-996c-995fff7bed2e",
});
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `request`                                                                    | [GetProcessInfoRequest](../../Models/ProcessesV1/GetProcessInfoRequest.md)   | :heavy_check_mark:                                                           | The request object to use for the request.                                   |
| `security`                                                                   | [GetProcessInfoSecurity](../../Models/ProcessesV1/GetProcessInfoSecurity.md) | :heavy_check_mark:                                                           | The security requirements to use for the request.                            |


### Response

**[GetProcessInfoResponse](../../Models/ProcessesV1/GetProcessInfoResponse.md)**


## GetRunningProcesses

Returns an array of active [process](https://hathora.dev/docs/concepts/hathora-entities#process) objects for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Filter the array by optionally passing in a region.

### Example Usage

```unity
using Hathora;
using Hathora.Models.ProcessesV1;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

var res = await sdk.ProcessesV1.GetRunningProcessesAsync(new GetRunningProcessesSecurity() {
    Auth0 = "",
}, new GetRunningProcessesRequest() {
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    Region = Hathora.Models.Shared.Region.Sydney,
});
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `request`                                                                              | [GetRunningProcessesRequest](../../Models/ProcessesV1/GetRunningProcessesRequest.md)   | :heavy_check_mark:                                                                     | The request object to use for the request.                                             |
| `security`                                                                             | [GetRunningProcessesSecurity](../../Models/ProcessesV1/GetRunningProcessesSecurity.md) | :heavy_check_mark:                                                                     | The security requirements to use for the request.                                      |


### Response

**[GetRunningProcessesResponse](../../Models/ProcessesV1/GetRunningProcessesResponse.md)**


## GetStoppedProcesses

Returns an array of stopped [process](https://hathora.dev/docs/concepts/hathora-entities#process) objects for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Filter the array by optionally passing in a region.

### Example Usage

```unity
using Hathora;
using Hathora.Models.ProcessesV1;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

var res = await sdk.ProcessesV1.GetStoppedProcessesAsync(new GetStoppedProcessesSecurity() {
    Auth0 = "",
}, new GetStoppedProcessesRequest() {
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    Region = Hathora.Models.Shared.Region.SaoPaulo,
});
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `request`                                                                              | [GetStoppedProcessesRequest](../../Models/ProcessesV1/GetStoppedProcessesRequest.md)   | :heavy_check_mark:                                                                     | The request object to use for the request.                                             |
| `security`                                                                             | [GetStoppedProcessesSecurity](../../Models/ProcessesV1/GetStoppedProcessesSecurity.md) | :heavy_check_mark:                                                                     | The security requirements to use for the request.                                      |


### Response

**[GetStoppedProcessesResponse](../../Models/ProcessesV1/GetStoppedProcessesResponse.md)**

