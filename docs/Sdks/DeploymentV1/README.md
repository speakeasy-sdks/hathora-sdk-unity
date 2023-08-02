# deploymentV1

## Overview

Operations that allow you configure and manage an application's [build](https://hathora.dev/docs/concepts/hathora-entities#build) at runtime.

### Available Operations

* [CreateDeployment](#createdeployment) - Create a new [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment) for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) and [build](https://hathora.dev/docs/concepts/hathora-entities#build).
* [GetDeploymentInfo](#getdeploymentinfo) - Get details for an existing [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment) using `appId`.
* [GetDeployments](#getdeployments) - Returns an array of [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment) objects for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.

## CreateDeployment

Create a new [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment) for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) and [build](https://hathora.dev/docs/concepts/hathora-entities#build).

### Example Usage

```unity
using Hathora;
using Hathora.Models.DeploymentV1;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

var res = await sdk.DeploymentV1.CreateDeploymentAsync(new CreateDeploymentSecurity() {
    Auth0 = "",
}, new CreateDeploymentRequest() {
    DeploymentConfig = new DeploymentConfig() {
        AdditionalContainerPorts = new List<ContainerPort>() {
            new ContainerPort() {
                Name = "default",
                Port = 8000,
                TransportType = Hathora.Models.Shared.TransportType.Udp,
            },
            new ContainerPort() {
                Name = "default",
                Port = 8000,
                TransportType = Hathora.Models.Shared.TransportType.Udp,
            },
        },
        ContainerPort = 4000,
        Env = new List<DeploymentConfigEnv>() {
            new DeploymentConfigEnv() {
                Name = "EULA",
                Value = "TRUE",
            },
            new DeploymentConfigEnv() {
                Name = "EULA",
                Value = "TRUE",
            },
        },
        PlanName = Hathora.Models.Shared.PlanName.Tiny,
        RoomsPerProcess = 3,
        TransportType = Hathora.Models.Shared.TransportType.Udp,
    },
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    BuildId = 1,
});
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [CreateDeploymentRequest](../../Models/Shared/CreateDeploymentRequest.md)         | :heavy_check_mark:                                                                | The request object to use for the request.                                        |
| `security`                                                                        | [CreateDeploymentSecurity](../../Models/DeploymentV1/CreateDeploymentSecurity.md) | :heavy_check_mark:                                                                | The security requirements to use for the request.                                 |


### Response

**[CreateDeploymentResponse](../../Models/DeploymentV1/CreateDeploymentResponse.md)**


## GetDeploymentInfo

Get details for an existing [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment) using `appId`.

### Example Usage

```unity
using Hathora;
using Hathora.Models.DeploymentV1;

var sdk = new HathoraSDK();

var res = await sdk.DeploymentV1.GetDeploymentInfoAsync(new GetDeploymentInfoSecurity() {
    Auth0 = "",
}, new GetDeploymentInfoRequest() {
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    DeploymentId = 1,
});
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GetDeploymentInfoRequest](../../Models/DeploymentV1/GetDeploymentInfoRequest.md)   | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |
| `security`                                                                          | [GetDeploymentInfoSecurity](../../Models/DeploymentV1/GetDeploymentInfoSecurity.md) | :heavy_check_mark:                                                                  | The security requirements to use for the request.                                   |


### Response

**[GetDeploymentInfoResponse](../../Models/DeploymentV1/GetDeploymentInfoResponse.md)**


## GetDeployments

Returns an array of [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment) objects for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.

### Example Usage

```unity
using Hathora;
using Hathora.Models.DeploymentV1;

var sdk = new HathoraSDK();

var res = await sdk.DeploymentV1.GetDeploymentsAsync(new GetDeploymentsSecurity() {
    Auth0 = "",
}, new GetDeploymentsRequest() {
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
});
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [GetDeploymentsRequest](../../Models/DeploymentV1/GetDeploymentsRequest.md)   | :heavy_check_mark:                                                            | The request object to use for the request.                                    |
| `security`                                                                    | [GetDeploymentsSecurity](../../Models/DeploymentV1/GetDeploymentsSecurity.md) | :heavy_check_mark:                                                            | The security requirements to use for the request.                             |


### Response

**[GetDeploymentsResponse](../../Models/DeploymentV1/GetDeploymentsResponse.md)**

