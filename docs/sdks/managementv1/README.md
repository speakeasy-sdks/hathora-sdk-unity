# managementV1

### Available Operations

* [SendVerificationEmail](#sendverificationemail)

## SendVerificationEmail

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Shared;

var sdk = new HathoraSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2"
);

using(var res = await sdk.ManagementV1.SendVerificationEmailAsync(new VerificationEmailRequest() {
        UserId = "minus",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [VerificationEmailRequest](../../models/shared/VerificationEmailRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[SendVerificationEmailResponse](../../models/operations/SendVerificationEmailResponse.md)**

