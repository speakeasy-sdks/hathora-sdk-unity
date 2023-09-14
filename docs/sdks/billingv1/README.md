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
using Hathora.Models.Shared;

var sdk = new HathoraSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_DEV_TOKEN_HERE>",
    }
);

using(var res = await sdk.BillingV1.GetBalanceAsync())
{
    // handle response
}
```


### Response

**[GetBalanceResponse](../../models/operations/GetBalanceResponse.md)**


## GetInvoices

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Shared;

var sdk = new HathoraSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_DEV_TOKEN_HERE>",
    }
);

using(var res = await sdk.BillingV1.GetInvoicesAsync())
{
    // handle response
}
```


### Response

**[GetInvoicesResponse](../../models/operations/GetInvoicesResponse.md)**


## GetPaymentMethod

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Shared;

var sdk = new HathoraSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_DEV_TOKEN_HERE>",
    }
);

using(var res = await sdk.BillingV1.GetPaymentMethodAsync())
{
    // handle response
}
```


### Response

**[GetPaymentMethodResponse](../../models/operations/GetPaymentMethodResponse.md)**


## InitStripeCustomerPortalUrl

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Shared;

var sdk = new HathoraSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_DEV_TOKEN_HERE>",
    }
);

using(var res = await sdk.BillingV1.InitStripeCustomerPortalUrlAsync(new CustomerPortalUrl() {
        ReturnUrl = "quibusdam",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [CustomerPortalUrl](../../models/shared/CustomerPortalUrl.md) | :heavy_check_mark:                                            | The request object to use for the request.                    |


### Response

**[InitStripeCustomerPortalUrlResponse](../../models/operations/InitStripeCustomerPortalUrlResponse.md)**

