# managementV1

### Available Operations

* [SendVerificationEmail](#sendverificationemail)

## SendVerificationEmail

### Example Usage

```unity
using Hathora;
using Hathora.Models.ManagementV1;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

var res = await sdk.ManagementV1.SendVerificationEmailAsync(new VerificationEmailRequest() {
    UserId = "nisi",
});
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [VerificationEmailRequest](../../Models/Shared/VerificationEmailRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[SendVerificationEmailResponse](../../Models/ManagementV1/SendVerificationEmailResponse.md)**

