
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SDK.BillingV1
{
    using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SDK.Models.BillingV1;
using SDK.Models.Shared;
using SDK.Utils;

    public interface IBillingV1SDK
    {
        Task<GetBalanceResponse> GetBalanceAsync(GetBalanceSecurity security);
        Task<GetInvoicesResponse> GetInvoicesAsync(GetInvoicesSecurity security);
        Task<GetPaymentMethodResponse> GetPaymentMethodAsync(GetPaymentMethodSecurity security);
        Task<InitStripeCustomerPortalUrlResponse> InitStripeCustomerPortalUrlAsync(InitStripeCustomerPortalUrlSecurity security, CustomerPortalUrl request);
    }

    public class BillingV1SDK: IBillingV1SDK
    {

        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.0.1";
        private const string _sdkGenVersion = "internal";
        private const string _openapiDocVersion = "0.0.1";
        public Uri ServerUrl { get { return _defaultClient.Client.BaseAddress; } }
        private SpeakeasyHttpClient _defaultClient;
        private SpeakeasyHttpClient _securityClient;

        public BillingV1SDK(SpeakeasyHttpClient defaultClient, SpeakeasyHttpClient securityClient, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            Config = config;
        }

        
    public async Task<GetBalanceResponse> GetBalanceAsync(GetBalanceSecurity security)
    {
        string baseUrl = "";
        var message = new HttpRequestMessage(HttpMethod.Get, baseUrl + "/billing/v1/balance");
        var client = _defaultClient;
        GetBalanceSecurity.Apply(security, message);

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetBalanceResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.GetBalance200ApplicationJSONDoubleNumber = JsonConvert.DeserializeObject<float>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.GetBalance404ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        return response;
    }

        
    public async Task<GetInvoicesResponse> GetInvoicesAsync(GetInvoicesSecurity security)
    {
        string baseUrl = "";
        var message = new HttpRequestMessage(HttpMethod.Get, baseUrl + "/billing/v1/invoices");
        var client = _defaultClient;
        GetInvoicesSecurity.Apply(security, message);

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetInvoicesResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Invoices = JsonConvert.DeserializeObject<List<Invoice>>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.GetInvoices404ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        return response;
    }

        
    public async Task<GetPaymentMethodResponse> GetPaymentMethodAsync(GetPaymentMethodSecurity security)
    {
        string baseUrl = "";
        var message = new HttpRequestMessage(HttpMethod.Get, baseUrl + "/billing/v1/paymentmethod");
        var client = _defaultClient;
        GetPaymentMethodSecurity.Apply(security, message);

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetPaymentMethodResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.PaymentMethod = JsonConvert.DeserializeObject<PaymentMethod>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.GetPaymentMethod404ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        if((response.StatusCode == 500))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.GetPaymentMethod500ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        return response;
    }

        
    public async Task<InitStripeCustomerPortalUrlResponse> InitStripeCustomerPortalUrlAsync(InitStripeCustomerPortalUrlSecurity security, CustomerPortalUrl request)
    {
        string baseUrl = "";
        var message = CustomerPortalUrl.BuildHttpRequestMessage("InitStripeCustomerPortalUrl", request, baseUrl);
        var client = _defaultClient;
        InitStripeCustomerPortalUrlSecurity.Apply(security, message);

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new InitStripeCustomerPortalUrlResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.InitStripeCustomerPortalUrl200ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.InitStripeCustomerPortalUrl404ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        return response;
    }

        
    }
}