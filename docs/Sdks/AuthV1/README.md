# authV1

## Overview

Operations that allow you to configure authentication for your [applications](https://hathora.dev/docs/concepts/hathora-entities#application).

### Available Operations

* [LoginAnonymous](#loginanonymous)
* [LoginGoogle](#logingoogle)
* [LoginNickname](#loginnickname)

## LoginAnonymous

### Example Usage

```unity
using Hathora;
using Hathora.Models.AuthV1;

var sdk = new HathoraSDK();

var res = await sdk.AuthV1.LoginAnonymousAsync(new LoginAnonymousRequest() {
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
});
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [LoginAnonymousRequest](../../Models/AuthV1/LoginAnonymousRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |


### Response

**[LoginAnonymousResponse](../../Models/AuthV1/LoginAnonymousResponse.md)**


## LoginGoogle

### Example Usage

```unity
using Hathora;
using Hathora.Models.AuthV1;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

var res = await sdk.AuthV1.LoginGoogleAsync(new LoginGoogleRequest() {
    LoginGoogleRequest = new LoginGoogleRequest() {
        IdToken = "quibusdam",
    },
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
});
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [LoginGoogleRequest](../../Models/Shared/LoginGoogleRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[LoginGoogleResponse](../../Models/AuthV1/LoginGoogleResponse.md)**


## LoginNickname

### Example Usage

```unity
using Hathora;
using Hathora.Models.AuthV1;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

var res = await sdk.AuthV1.LoginNicknameAsync(new LoginNicknameRequest() {
    LoginNicknameRequest = new LoginNicknameRequest() {
        Nickname = "unde",
    },
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
});
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [LoginNicknameRequest](../../Models/Shared/LoginNicknameRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[LoginNicknameResponse](../../Models/AuthV1/LoginNicknameResponse.md)**

