<!-- Start SDK Example Usage -->


```csharp
using Hathora;
using Hathora.Models.Shared;

var sdk = new HathoraSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_DEV_TOKEN_HERE>",
    }
);

using(var res = await sdk.AppV1.CreateAppAsync(new AppConfig() {
        AppName = "minecraft",
        AuthConfiguration = new AuthConfiguration() {
            Anonymous = new RecordStringNever() {},
            Google = new AuthConfigurationGoogle() {
                ClientId = "corrupti",
            },
            Nickname = new RecordStringNever() {},
        },
    }))
{
    // handle response
}
```
<!-- End SDK Example Usage -->