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