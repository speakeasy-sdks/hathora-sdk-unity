# openapi

<!-- Start SDK Installation -->
## SDK Installation

### Nuget

```bash
dotnet add reference path/to/Hathora.csproj
```
<!-- End SDK Installation -->

## SDK Example Usage
<!-- Start SDK Example Usage -->


```unity
using Hathora;
using Hathora.Models.AppV1;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

var res = await sdk.AppV1.CreateAppAsync(new CreateAppSecurity() {
    Auth0 = "",
}, new AppConfig() {
    AppName = "minecraft",
    AuthConfiguration = new AppConfigAuthConfiguration() {
        Anonymous = new RecordStringNever() {},
        Google = new AppConfigAuthConfigurationGoogle() {
            ClientId = "corrupti",
        },
        Nickname = new RecordStringNever() {},
    },
});
```
<!-- End SDK Example Usage -->

<!-- Start SDK Available Operations -->
## Available Resources and Operations


### [appV1](docs/Sdks/AppV1/README.md)

* [CreateApp](docs/Sdks/AppV1/README.md#createapp) - Create a new [application](https://hathora.dev/docs/concepts/hathora-entities#application).
* [DeleteApp](docs/Sdks/AppV1/README.md#deleteapp) - Delete an [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Your organization will lose access to this application.
* [GetAppInfo](docs/Sdks/AppV1/README.md#getappinfo) - Get details for an [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.
* [GetApps](docs/Sdks/AppV1/README.md#getapps) - Returns an unsorted list of your organization’s [applications](https://hathora.dev/docs/concepts/hathora-entities#application). An application is uniquely identified by an `appId`.
* [UpdateApp](docs/Sdks/AppV1/README.md#updateapp) - Update data for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.

### [authV1](docs/Sdks/AuthV1/README.md)

* [LoginAnonymous](docs/Sdks/AuthV1/README.md#loginanonymous)
* [LoginGoogle](docs/Sdks/AuthV1/README.md#logingoogle)
* [LoginNickname](docs/Sdks/AuthV1/README.md#loginnickname)

### [billingV1](docs/Sdks/BillingV1/README.md)

* [GetBalance](docs/Sdks/BillingV1/README.md#getbalance)
* [GetInvoices](docs/Sdks/BillingV1/README.md#getinvoices)
* [GetPaymentMethod](docs/Sdks/BillingV1/README.md#getpaymentmethod)
* [InitStripeCustomerPortalUrl](docs/Sdks/BillingV1/README.md#initstripecustomerportalurl)

### [buildV1](docs/Sdks/BuildV1/README.md)

* [CreateBuild](docs/Sdks/BuildV1/README.md#createbuild) - Generate a new `buildId` for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. You need `buildId` to run a [build](https://hathora.dev/docs/concepts/hathora-entities#build).
* [DeleteBuild](docs/Sdks/BuildV1/README.md#deletebuild) - Delete a [build](https://hathora.dev/docs/concepts/hathora-entities#build) for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId` and `buildId`.
* [GetBuildInfo](docs/Sdks/BuildV1/README.md#getbuildinfo) - Get details for an existing [build](https://hathora.dev/docs/concepts/hathora-entities#build) using `appId` and `buildId`.
* [GetBuilds](docs/Sdks/BuildV1/README.md#getbuilds) - Returns an array of [build](https://hathora.dev/docs/concepts/hathora-entities#build) objects for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.
* [RunBuild](docs/Sdks/BuildV1/README.md#runbuild) - Provide a tarball that will generate a container image for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Pass in `buildId` generated from Create Build.

### [deploymentV1](docs/Sdks/DeploymentV1/README.md)

* [CreateDeployment](docs/Sdks/DeploymentV1/README.md#createdeployment) - Create a new [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment) for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) and [build](https://hathora.dev/docs/concepts/hathora-entities#build).
* [GetDeploymentInfo](docs/Sdks/DeploymentV1/README.md#getdeploymentinfo) - Get details for an existing [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment) using `appId`.
* [GetDeployments](docs/Sdks/DeploymentV1/README.md#getdeployments) - Returns an array of [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment) objects for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.

### [discoveryV1](docs/Sdks/DiscoveryV1/README.md)

* [GetPingServiceEndpoints](docs/Sdks/DiscoveryV1/README.md#getpingserviceendpoints) - Returns an array of all regions with a host and port that a client can directly ping.

### [lobbyV1](docs/Sdks/LobbyV1/README.md)

* [~~CreatePrivateLobbyDeprecated~~](docs/Sdks/LobbyV1/README.md#createprivatelobbydeprecated) - :warning: **Deprecated**
* [~~CreatePublicLobbyDeprecated~~](docs/Sdks/LobbyV1/README.md#createpubliclobbydeprecated) - :warning: **Deprecated**
* [~~ListActivePublicLobbiesDeprecated~~](docs/Sdks/LobbyV1/README.md#listactivepubliclobbiesdeprecated) - :warning: **Deprecated**

### [lobbyV2](docs/Sdks/LobbyV2/README.md)

* [CreateLobby](docs/Sdks/LobbyV2/README.md#createlobby) - Create a new [lobby](https://hathora.dev/docs/concepts/hathora-entities#lobby) for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.
* [~~CreateLocalLobby~~](docs/Sdks/LobbyV2/README.md#createlocallobby) - :warning: **Deprecated**
* [~~CreatePrivateLobby~~](docs/Sdks/LobbyV2/README.md#createprivatelobby) - :warning: **Deprecated**
* [~~CreatePublicLobby~~](docs/Sdks/LobbyV2/README.md#createpubliclobby) - :warning: **Deprecated**
* [GetLobbyInfo](docs/Sdks/LobbyV2/README.md#getlobbyinfo) - Get details for an existing [lobby](https://hathora.dev/docs/concepts/hathora-entities#lobby) using `appId` and `roomId`.
* [ListActivePublicLobbies](docs/Sdks/LobbyV2/README.md#listactivepubliclobbies) - Get all active [lobbies](https://hathora.dev/docs/concepts/hathora-entities#lobby) for a given [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Filter the array by optionally passing in a `region`.
* [SetLobbyState](docs/Sdks/LobbyV2/README.md#setlobbystate) - Set the state of a [lobby](https://hathora.dev/docs/concepts/hathora-entities#lobby) using `appId` and `roomId`. State is intended to be set by the server and must be smaller than 1MB.

### [logV1](docs/Sdks/LogV1/README.md)

* [GetLogsForApp](docs/Sdks/LogV1/README.md#getlogsforapp) - Returns a stream of logs for an [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.
* [GetLogsForDeployment](docs/Sdks/LogV1/README.md#getlogsfordeployment) - Returns a stream of logs for a [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment) using `appId` and `deploymentId`.
* [GetLogsForProcess](docs/Sdks/LogV1/README.md#getlogsforprocess) - Returns a stream of logs for a [process](https://hathora.dev/docs/concepts/hathora-entities#process) using `appId` and `processId`.

### [managementV1](docs/Sdks/ManagementV1/README.md)

* [SendVerificationEmail](docs/Sdks/ManagementV1/README.md#sendverificationemail)

### [metricsV1](docs/Sdks/MetricsV1/README.md)

* [GetMetrics](docs/Sdks/MetricsV1/README.md#getmetrics) - Get metrics for a [process](https://hathora.dev/docs/concepts/hathora-entities#process) using `appId` and `processId`.

### [processesV1](docs/Sdks/ProcessesV1/README.md)

* [GetProcessInfo](docs/Sdks/ProcessesV1/README.md#getprocessinfo) - Get details for an existing [process](https://hathora.dev/docs/concepts/hathora-entities#process) using `appId` and `processId`.
* [GetRunningProcesses](docs/Sdks/ProcessesV1/README.md#getrunningprocesses) - Returns an array of active [process](https://hathora.dev/docs/concepts/hathora-entities#process) objects for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Filter the array by optionally passing in a region.
* [GetStoppedProcesses](docs/Sdks/ProcessesV1/README.md#getstoppedprocesses) - Returns an array of stopped [process](https://hathora.dev/docs/concepts/hathora-entities#process) objects for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Filter the array by optionally passing in a region.

### [roomV1](docs/Sdks/RoomV1/README.md)

* [~~CreateRoomDeprecated~~](docs/Sdks/RoomV1/README.md#createroomdeprecated) - :warning: **Deprecated**
* [~~DestroyRoomDeprecated~~](docs/Sdks/RoomV1/README.md#destroyroomdeprecated) - :warning: **Deprecated**
* [~~GetActiveRoomsForProcessDeprecated~~](docs/Sdks/RoomV1/README.md#getactiveroomsforprocessdeprecated) - :warning: **Deprecated**
* [~~GetConnectionInfoDeprecated~~](docs/Sdks/RoomV1/README.md#getconnectioninfodeprecated) - :warning: **Deprecated**
* [~~GetInactiveRoomsForProcessDeprecated~~](docs/Sdks/RoomV1/README.md#getinactiveroomsforprocessdeprecated) - :warning: **Deprecated**
* [~~GetRoomInfoDeprecated~~](docs/Sdks/RoomV1/README.md#getroominfodeprecated) - :warning: **Deprecated**
* [~~SuspendRoomDeprecated~~](docs/Sdks/RoomV1/README.md#suspendroomdeprecated) - :warning: **Deprecated**

### [roomV2](docs/Sdks/RoomV2/README.md)

* [CreateRoom](docs/Sdks/RoomV2/README.md#createroom) - Create a new [room](https://hathora.dev/docs/concepts/hathora-entities#room) for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId` and `region`.
* [DestroyRoom](docs/Sdks/RoomV2/README.md#destroyroom) - Destroy a [room](https://hathora.dev/docs/concepts/hathora-entities#room) using `appId` and `roomId`. All associated metadata is deleted.
* [GetActiveRoomsForProcess](docs/Sdks/RoomV2/README.md#getactiveroomsforprocess) - Get all active [rooms](https://hathora.dev/docs/concepts/hathora-entities#room) for a given [process](https://hathora.dev/docs/concepts/hathora-entities#process) using `appId` and `processId`.
* [GetConnectionInfo](docs/Sdks/RoomV2/README.md#getconnectioninfo) - Get connection details to a [room](https://hathora.dev/docs/concepts/hathora-entities#room) using `appId` and `roomId`. Clients can call this endpoint without authentication.
* [GetInactiveRoomsForProcess](docs/Sdks/RoomV2/README.md#getinactiveroomsforprocess) - Get all inactive [rooms](https://hathora.dev/docs/concepts/hathora-entities#room) for a given [process](https://hathora.dev/docs/concepts/hathora-entities#process) using `appId` and `processId`.
* [GetRoomInfo](docs/Sdks/RoomV2/README.md#getroominfo) - Get details for an existing [room](https://hathora.dev/docs/concepts/hathora-entities#room) using `appId` and `roomId`.
* [SuspendRoom](docs/Sdks/RoomV2/README.md#suspendroom) - Suspend a [room](https://hathora.dev/docs/concepts/hathora-entities#room) using `appId` and `roomId`. The room is unallocated from the process but can be rescheduled later using the same `roomId`.
<!-- End SDK Available Operations -->

### Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

### Contributions

While we value open-source contributions to this SDK, this library is generated programmatically.
Feel free to open a PR or a Github issue as a proof of concept and we'll do our best to include it in a future release!

### SDK Created by [Speakeasy](https://docs.speakeasyapi.dev/docs/using-speakeasy/client-sdks)
