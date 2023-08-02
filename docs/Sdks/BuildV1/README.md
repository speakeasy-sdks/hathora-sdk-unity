# buildV1

## Overview

Operations that allow you create and manage your [build](https://hathora.dev/docs/concepts/hathora-entities#build).

### Available Operations

* [CreateBuild](#createbuild) - Generate a new `buildId` for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. You need `buildId` to run a [build](https://hathora.dev/docs/concepts/hathora-entities#build).
* [DeleteBuild](#deletebuild) - Delete a [build](https://hathora.dev/docs/concepts/hathora-entities#build) for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId` and `buildId`.
* [GetBuildInfo](#getbuildinfo) - Get details for an existing [build](https://hathora.dev/docs/concepts/hathora-entities#build) using `appId` and `buildId`.
* [GetBuilds](#getbuilds) - Returns an array of [build](https://hathora.dev/docs/concepts/hathora-entities#build) objects for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.
* [RunBuild](#runbuild) - Provide a tarball that will generate a container image for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Pass in `buildId` generated from Create Build.

## CreateBuild

Generate a new `buildId` for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. You need `buildId` to run a [build](https://hathora.dev/docs/concepts/hathora-entities#build).

### Example Usage

```unity
using Hathora;
using Hathora.Models.BuildV1;

var sdk = new HathoraSDK();

var res = await sdk.BuildV1.CreateBuildAsync(new CreateBuildSecurity() {
    Auth0 = "",
}, new CreateBuildRequest() {
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
});
```

### Parameters

| Parameter                                                          | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `request`                                                          | [CreateBuildRequest](../../Models/BuildV1/CreateBuildRequest.md)   | :heavy_check_mark:                                                 | The request object to use for the request.                         |
| `security`                                                         | [CreateBuildSecurity](../../Models/BuildV1/CreateBuildSecurity.md) | :heavy_check_mark:                                                 | The security requirements to use for the request.                  |


### Response

**[CreateBuildResponse](../../Models/BuildV1/CreateBuildResponse.md)**


## DeleteBuild

Delete a [build](https://hathora.dev/docs/concepts/hathora-entities#build) for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId` and `buildId`.

### Example Usage

```unity
using Hathora;
using Hathora.Models.BuildV1;

var sdk = new HathoraSDK();

var res = await sdk.BuildV1.DeleteBuildAsync(new DeleteBuildSecurity() {
    Auth0 = "",
}, new DeleteBuildRequest() {
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    BuildId = 1,
});
```

### Parameters

| Parameter                                                          | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `request`                                                          | [DeleteBuildRequest](../../Models/BuildV1/DeleteBuildRequest.md)   | :heavy_check_mark:                                                 | The request object to use for the request.                         |
| `security`                                                         | [DeleteBuildSecurity](../../Models/BuildV1/DeleteBuildSecurity.md) | :heavy_check_mark:                                                 | The security requirements to use for the request.                  |


### Response

**[DeleteBuildResponse](../../Models/BuildV1/DeleteBuildResponse.md)**


## GetBuildInfo

Get details for an existing [build](https://hathora.dev/docs/concepts/hathora-entities#build) using `appId` and `buildId`.

### Example Usage

```unity
using Hathora;
using Hathora.Models.BuildV1;

var sdk = new HathoraSDK();

var res = await sdk.BuildV1.GetBuildInfoAsync(new GetBuildInfoSecurity() {
    Auth0 = "",
}, new GetBuildInfoRequest() {
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    BuildId = 1,
});
```

### Parameters

| Parameter                                                            | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `request`                                                            | [GetBuildInfoRequest](../../Models/BuildV1/GetBuildInfoRequest.md)   | :heavy_check_mark:                                                   | The request object to use for the request.                           |
| `security`                                                           | [GetBuildInfoSecurity](../../Models/BuildV1/GetBuildInfoSecurity.md) | :heavy_check_mark:                                                   | The security requirements to use for the request.                    |


### Response

**[GetBuildInfoResponse](../../Models/BuildV1/GetBuildInfoResponse.md)**


## GetBuilds

Returns an array of [build](https://hathora.dev/docs/concepts/hathora-entities#build) objects for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.

### Example Usage

```unity
using Hathora;
using Hathora.Models.BuildV1;

var sdk = new HathoraSDK();

var res = await sdk.BuildV1.GetBuildsAsync(new GetBuildsSecurity() {
    Auth0 = "",
}, new GetBuildsRequest() {
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
});
```

### Parameters

| Parameter                                                      | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `request`                                                      | [GetBuildsRequest](../../Models/BuildV1/GetBuildsRequest.md)   | :heavy_check_mark:                                             | The request object to use for the request.                     |
| `security`                                                     | [GetBuildsSecurity](../../Models/BuildV1/GetBuildsSecurity.md) | :heavy_check_mark:                                             | The security requirements to use for the request.              |


### Response

**[GetBuildsResponse](../../Models/BuildV1/GetBuildsResponse.md)**


## RunBuild

Provide a tarball that will generate a container image for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Pass in `buildId` generated from Create Build.

### Example Usage

```unity
using Hathora;
using Hathora.Models.BuildV1;

var sdk = new HathoraSDK();

var res = await sdk.BuildV1.RunBuildAsync(new RunBuildSecurity() {
    Auth0 = "",
}, new RunBuildRequest() {
    RequestBody = new RunBuildRequestBody() {
        File = new RunBuildRequestBodyFile() {
            Content = "corrupti as bytes <<<>>>",
            File = "illum",
        },
    },
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    BuildId = 1,
});
```

### Parameters

| Parameter                                                    | Type                                                         | Required                                                     | Description                                                  |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| `request`                                                    | [RunBuildRequest](../../Models/BuildV1/RunBuildRequest.md)   | :heavy_check_mark:                                           | The request object to use for the request.                   |
| `security`                                                   | [RunBuildSecurity](../../Models/BuildV1/RunBuildSecurity.md) | :heavy_check_mark:                                           | The security requirements to use for the request.            |


### Response

**[RunBuildResponse](../../Models/BuildV1/RunBuildResponse.md)**

