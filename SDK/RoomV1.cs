
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SDK.RoomV1
{
    using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SDK.Models.RoomV1;
using SDK.Models.Shared;
using SDK.Utils;

    public interface IRoomV1SDK
    {
        Task<CreateRoomDeprecatedResponse> CreateRoomDeprecatedAsync(CreateRoomDeprecatedSecurity security, CreateRoomDeprecatedRequest request);
        Task<DestroyRoomDeprecatedResponse> DestroyRoomDeprecatedAsync(DestroyRoomDeprecatedSecurity security, DestroyRoomDeprecatedRequest? request = null);
        Task<GetActiveRoomsForProcessDeprecatedResponse> GetActiveRoomsForProcessDeprecatedAsync(GetActiveRoomsForProcessDeprecatedSecurity security, GetActiveRoomsForProcessDeprecatedRequest? request = null);
        Task<GetConnectionInfoDeprecatedResponse> GetConnectionInfoDeprecatedAsync(GetConnectionInfoDeprecatedRequest? request = null);
        Task<GetInactiveRoomsForProcessDeprecatedResponse> GetInactiveRoomsForProcessDeprecatedAsync(GetInactiveRoomsForProcessDeprecatedSecurity security, GetInactiveRoomsForProcessDeprecatedRequest? request = null);
        Task<GetRoomInfoDeprecatedResponse> GetRoomInfoDeprecatedAsync(GetRoomInfoDeprecatedSecurity security, GetRoomInfoDeprecatedRequest? request = null);
        Task<SuspendRoomDeprecatedResponse> SuspendRoomDeprecatedAsync(SuspendRoomDeprecatedSecurity security, SuspendRoomDeprecatedRequest? request = null);
    }

    public class RoomV1SDK: IRoomV1SDK
    {

        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.0.1";
        private const string _sdkGenVersion = "internal";
        private const string _openapiDocVersion = "0.0.1";
        public Uri ServerUrl { get { return _defaultClient.Client.BaseAddress; } }
        private SpeakeasyHttpClient _defaultClient;
        private SpeakeasyHttpClient _securityClient;

        public RoomV1SDK(SpeakeasyHttpClient defaultClient, SpeakeasyHttpClient securityClient, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            Config = config;
        }

        
    [Obsolete("This method will be removed in a future release, please migrate away from it as soon as possible")]
    public async Task<CreateRoomDeprecatedResponse> CreateRoomDeprecatedAsync(CreateRoomDeprecatedSecurity security, CreateRoomDeprecatedRequest request)
    {
        string baseUrl = "";
        var message = CreateRoomDeprecatedRequest.BuildHttpRequestMessage("CreateRoomDeprecated", request, baseUrl);
        var client = _defaultClient;
        CreateRoomDeprecatedSecurity.Apply(security, message);

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new CreateRoomDeprecatedResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 201))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.RoomId = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        if((response.StatusCode == 400))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreateRoomDeprecated400ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        if((response.StatusCode == 403))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreateRoomDeprecated403ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreateRoomDeprecated404ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        if((response.StatusCode == 500))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreateRoomDeprecated500ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        return response;
    }

        
    [Obsolete("This method will be removed in a future release, please migrate away from it as soon as possible")]
    public async Task<DestroyRoomDeprecatedResponse> DestroyRoomDeprecatedAsync(DestroyRoomDeprecatedSecurity security, DestroyRoomDeprecatedRequest? request = null)
    {
        string baseUrl = "";
        var message = DestroyRoomDeprecatedRequest.BuildHttpRequestMessage("DestroyRoomDeprecated", request, baseUrl);
        var client = _defaultClient;
        DestroyRoomDeprecatedSecurity.Apply(security, message);

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new DestroyRoomDeprecatedResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 204))
        {
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.DestroyRoomDeprecated404ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        if((response.StatusCode == 500))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.DestroyRoomDeprecated500ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        return response;
    }

        
    [Obsolete("This method will be removed in a future release, please migrate away from it as soon as possible")]
    public async Task<GetActiveRoomsForProcessDeprecatedResponse> GetActiveRoomsForProcessDeprecatedAsync(GetActiveRoomsForProcessDeprecatedSecurity security, GetActiveRoomsForProcessDeprecatedRequest? request = null)
    {
        string baseUrl = "";
        var message = GetActiveRoomsForProcessDeprecatedRequest.BuildHttpRequestMessage("GetActiveRoomsForProcessDeprecated", request, baseUrl);
        var client = _defaultClient;
        GetActiveRoomsForProcessDeprecatedSecurity.Apply(security, message);

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetActiveRoomsForProcessDeprecatedResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.RoomWithoutAllocations = JsonConvert.DeserializeObject<List<RoomWithoutAllocations>>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.GetActiveRoomsForProcessDeprecated404ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        return response;
    }

        
    [Obsolete("This method will be removed in a future release, please migrate away from it as soon as possible")]
    public async Task<GetConnectionInfoDeprecatedResponse> GetConnectionInfoDeprecatedAsync(GetConnectionInfoDeprecatedRequest? request = null)
    {
        string baseUrl = "";
        var message = GetConnectionInfoDeprecatedRequest.BuildHttpRequestMessage("GetConnectionInfoDeprecated", request, baseUrl);
        var client = _defaultClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetConnectionInfoDeprecatedResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.ConnectionInfo = JsonConvert.DeserializeObject<object>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        if((response.StatusCode == 400))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.GetConnectionInfoDeprecated400ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.GetConnectionInfoDeprecated404ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        if((response.StatusCode == 500))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.GetConnectionInfoDeprecated500ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        return response;
    }

        
    [Obsolete("This method will be removed in a future release, please migrate away from it as soon as possible")]
    public async Task<GetInactiveRoomsForProcessDeprecatedResponse> GetInactiveRoomsForProcessDeprecatedAsync(GetInactiveRoomsForProcessDeprecatedSecurity security, GetInactiveRoomsForProcessDeprecatedRequest? request = null)
    {
        string baseUrl = "";
        var message = GetInactiveRoomsForProcessDeprecatedRequest.BuildHttpRequestMessage("GetInactiveRoomsForProcessDeprecated", request, baseUrl);
        var client = _defaultClient;
        GetInactiveRoomsForProcessDeprecatedSecurity.Apply(security, message);

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetInactiveRoomsForProcessDeprecatedResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.RoomWithoutAllocations = JsonConvert.DeserializeObject<List<RoomWithoutAllocations>>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.GetInactiveRoomsForProcessDeprecated404ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        return response;
    }

        
    [Obsolete("This method will be removed in a future release, please migrate away from it as soon as possible")]
    public async Task<GetRoomInfoDeprecatedResponse> GetRoomInfoDeprecatedAsync(GetRoomInfoDeprecatedSecurity security, GetRoomInfoDeprecatedRequest? request = null)
    {
        string baseUrl = "";
        var message = GetRoomInfoDeprecatedRequest.BuildHttpRequestMessage("GetRoomInfoDeprecated", request, baseUrl);
        var client = _defaultClient;
        GetRoomInfoDeprecatedSecurity.Apply(security, message);

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetRoomInfoDeprecatedResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Room = JsonConvert.DeserializeObject<Room>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.GetRoomInfoDeprecated404ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        return response;
    }

        
    [Obsolete("This method will be removed in a future release, please migrate away from it as soon as possible")]
    public async Task<SuspendRoomDeprecatedResponse> SuspendRoomDeprecatedAsync(SuspendRoomDeprecatedSecurity security, SuspendRoomDeprecatedRequest? request = null)
    {
        string baseUrl = "";
        var message = SuspendRoomDeprecatedRequest.BuildHttpRequestMessage("SuspendRoomDeprecated", request, baseUrl);
        var client = _defaultClient;
        SuspendRoomDeprecatedSecurity.Apply(security, message);

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new SuspendRoomDeprecatedResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 204))
        {
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.SuspendRoomDeprecated404ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        if((response.StatusCode == 500))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.SuspendRoomDeprecated500ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        return response;
    }

        
    }
}