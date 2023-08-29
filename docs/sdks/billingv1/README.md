# billingV1

### Available Operations

* [GetBalance](#getbalance)
* [GetInvoices](#getinvoices)
* [GetPaymentMethod](#getpaymentmethod)
* [InitStripeCustomerPortalUrl](#initstripecustomerportalurl)

## GetBalance

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;

var sdk = new HathoraSDK();

using(var res = await sdk.BillingV1.GetBalanceAsync(new GetBalanceSecurity() {
        Auth0 = "",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                          | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `security`                                                         | [GetBalanceSecurity](../../Models/BillingV1/GetBalanceSecurity.md) | :heavy_check_mark:                                                 | The security requirements to use for the request.                  |


### Response

**[GetBalanceResponse](../../Models/BillingV1/GetBalanceResponse.md)**


## GetInvoices

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;

var sdk = new HathoraSDK();

using(var res = await sdk.BillingV1.GetInvoicesAsync(new GetInvoicesSecurity() {
        Auth0 = "",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                            | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `security`                                                           | [GetInvoicesSecurity](../../Models/BillingV1/GetInvoicesSecurity.md) | :heavy_check_mark:                                                   | The security requirements to use for the request.                    |


### Response

**[GetInvoicesResponse](../../Models/BillingV1/GetInvoicesResponse.md)**


## GetPaymentMethod

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;

var sdk = new HathoraSDK();

using(var res = await sdk.BillingV1.GetPaymentMethodAsync(new GetPaymentMethodSecurity() {
        Auth0 = "",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                      | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `security`                                                                     | [GetPaymentMethodSecurity](../../Models/BillingV1/GetPaymentMethodSecurity.md) | :heavy_check_mark:                                                             | The security requirements to use for the request.                              |


### Response

**[GetPaymentMethodResponse](../../Models/BillingV1/GetPaymentMethodResponse.md)**


## InitStripeCustomerPortalUrl

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Shared;
using Hathora.Models.Operations;

var sdk = new HathoraSDK();

using(var res = await sdk.BillingV1.InitStripeCustomerPortalUrlAsync(new InitStripeCustomerPortalUrlSecurity() {
        Auth0 = "",
    }, new CustomerPortalUrl() {
        ReturnUrl = "quibusdam",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                            | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `request`                                                                                            | [CustomerPortalUrl](../../Models/Shared/CustomerPortalUrl.md)                                        | :heavy_check_mark:                                                                                   | The request object to use for the request.                                                           |
| `security`                                                                                           | [InitStripeCustomerPortalUrlSecurity](../../Models/BillingV1/InitStripeCustomerPortalUrlSecurity.md) | :heavy_check_mark:                                                                                   | The security requirements to use for the request.                                                    |


### Response

**[InitStripeCustomerPortalUrlResponse](../../Models/BillingV1/InitStripeCustomerPortalUrlResponse.md)**

