
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Hathora
{
    using Hathora.Models.Operations;
    using Hathora.Models.Shared;
    using Hathora.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System;
    using UnityEngine.Networking;

    public interface ILobbyV2SDK
    {
        Task<CreateLobbyResponse> CreateLobbyAsync(Models.Operations.CreateLobbyRequest request);
        Task<CreateLocalLobbyResponse> CreateLocalLobbyAsync(CreateLocalLobbyRequest request);
        Task<CreatePrivateLobbyResponse> CreatePrivateLobbyAsync(CreatePrivateLobbyRequest request);
        Task<CreatePublicLobbyResponse> CreatePublicLobbyAsync(CreatePublicLobbyRequest request);
        Task<GetLobbyInfoResponse> GetLobbyInfoAsync(GetLobbyInfoRequest? request = null);
        Task<ListActivePublicLobbiesResponse> ListActivePublicLobbiesAsync(ListActivePublicLobbiesRequest? request = null);
        Task<SetLobbyStateResponse> SetLobbyStateAsync(SetLobbyStateSecurity security, Models.Operations.SetLobbyStateRequest request);
    }

    public class LobbyV2SDK: ILobbyV2SDK
    {
        public SDKConfig Config { get; private set; }
        private const string _target = "unity";
        private const string _sdkVersion = "0.0.1";
        private const string _sdkGenVersion = "internal";
        private const string _openapiDocVersion = "0.0.1";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public LobbyV2SDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        /// <summary>
        /// Create a new lobby for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.
        /// </summary>
        public async Task<CreateLobbyResponse> CreateLobbyAsync(Models.Operations.CreateLobbyRequest request)
        {
            request.AppId ??= Config.AppId;
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/lobby/v2/{appId}/create", request);
            

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbPOST);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", $"speakeasy-sdk/{_target} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "CreateLobbyRequestValue", "json");
            if (serializedBody == null) 
            {
                throw new ArgumentNullException("request body is required");
            }
            else
            {
                httpRequest.uploadHandler = new UploadHandlerRaw(serializedBody.Body);
                httpRequest.SetRequestHeader("Content-Type", serializedBody.ContentType);
            }
            
            var client = _defaultClient;
            
            var httpResponse = await client.SendAsync(httpRequest);
            switch (httpResponse.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                case UnityWebRequest.Result.ProtocolError:
                    var errorMsg = httpResponse.error;
                    httpRequest.Dispose();
                    throw new Exception(errorMsg);
            }

            var contentType = httpResponse.GetResponseHeader("Content-Type");
            var response = new CreateLobbyResponse
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 201))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Lobby = JsonConvert.DeserializeObject<Lobby>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter() }});
                }
                
                return response;
            }
            if((response.StatusCode == 400))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreateLobby400ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 401))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreateLobby401ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 404))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreateLobby404ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 422))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreateLobby422ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 429))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreateLobby429ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 500))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreateLobby500ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            return response;
        }
        

        [Obsolete("This method will be removed in a future release, please migrate away from it as soon as possible")]
        public async Task<CreateLocalLobbyResponse> CreateLocalLobbyAsync(CreateLocalLobbyRequest request)
        {
            request.AppId ??= Config.AppId;
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/lobby/v2/{appId}/create/local", request);
            

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbPOST);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", $"speakeasy-sdk/{_target} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "RequestBody", "json");
            if (serializedBody == null) 
            {
                throw new ArgumentNullException("request body is required");
            }
            else
            {
                httpRequest.uploadHandler = new UploadHandlerRaw(serializedBody.Body);
                httpRequest.SetRequestHeader("Content-Type", serializedBody.ContentType);
            }
            
            var client = _defaultClient;
            
            var httpResponse = await client.SendAsync(httpRequest);
            switch (httpResponse.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                case UnityWebRequest.Result.ProtocolError:
                    var errorMsg = httpResponse.error;
                    httpRequest.Dispose();
                    throw new Exception(errorMsg);
            }

            var contentType = httpResponse.GetResponseHeader("Content-Type");
            var response = new CreateLocalLobbyResponse
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 201))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Lobby = JsonConvert.DeserializeObject<Lobby>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter() }});
                }
                
                return response;
            }
            if((response.StatusCode == 400))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreateLocalLobby400ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 401))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreateLocalLobby401ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 404))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreateLocalLobby404ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 422))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreateLocalLobby422ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 429))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreateLocalLobby429ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 500))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreateLocalLobby500ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            return response;
        }
        

        [Obsolete("This method will be removed in a future release, please migrate away from it as soon as possible")]
        public async Task<CreatePrivateLobbyResponse> CreatePrivateLobbyAsync(CreatePrivateLobbyRequest request)
        {
            request.AppId ??= Config.AppId;
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/lobby/v2/{appId}/create/private", request);
            

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbPOST);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", $"speakeasy-sdk/{_target} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "RequestBody", "json");
            if (serializedBody == null) 
            {
                throw new ArgumentNullException("request body is required");
            }
            else
            {
                httpRequest.uploadHandler = new UploadHandlerRaw(serializedBody.Body);
                httpRequest.SetRequestHeader("Content-Type", serializedBody.ContentType);
            }
            
            var client = _defaultClient;
            
            var httpResponse = await client.SendAsync(httpRequest);
            switch (httpResponse.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                case UnityWebRequest.Result.ProtocolError:
                    var errorMsg = httpResponse.error;
                    httpRequest.Dispose();
                    throw new Exception(errorMsg);
            }

            var contentType = httpResponse.GetResponseHeader("Content-Type");
            var response = new CreatePrivateLobbyResponse
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 201))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Lobby = JsonConvert.DeserializeObject<Lobby>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter() }});
                }
                
                return response;
            }
            if((response.StatusCode == 400))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreatePrivateLobby400ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 401))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreatePrivateLobby401ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 404))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreatePrivateLobby404ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 422))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreatePrivateLobby422ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 429))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreatePrivateLobby429ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 500))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreatePrivateLobby500ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            return response;
        }
        

        [Obsolete("This method will be removed in a future release, please migrate away from it as soon as possible")]
        public async Task<CreatePublicLobbyResponse> CreatePublicLobbyAsync(CreatePublicLobbyRequest request)
        {
            request.AppId ??= Config.AppId;
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/lobby/v2/{appId}/create/public", request);
            

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbPOST);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", $"speakeasy-sdk/{_target} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "RequestBody", "json");
            if (serializedBody == null) 
            {
                throw new ArgumentNullException("request body is required");
            }
            else
            {
                httpRequest.uploadHandler = new UploadHandlerRaw(serializedBody.Body);
                httpRequest.SetRequestHeader("Content-Type", serializedBody.ContentType);
            }
            
            var client = _defaultClient;
            
            var httpResponse = await client.SendAsync(httpRequest);
            switch (httpResponse.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                case UnityWebRequest.Result.ProtocolError:
                    var errorMsg = httpResponse.error;
                    httpRequest.Dispose();
                    throw new Exception(errorMsg);
            }

            var contentType = httpResponse.GetResponseHeader("Content-Type");
            var response = new CreatePublicLobbyResponse
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 201))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Lobby = JsonConvert.DeserializeObject<Lobby>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter() }});
                }
                
                return response;
            }
            if((response.StatusCode == 400))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreatePublicLobby400ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 401))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreatePublicLobby401ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 404))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreatePublicLobby404ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 422))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreatePublicLobby422ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 429))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreatePublicLobby429ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 500))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreatePublicLobby500ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            return response;
        }
        

        /// <summary>
        /// Get details for an existing lobby using `appId` and `roomId`.
        /// </summary>
        public async Task<GetLobbyInfoResponse> GetLobbyInfoAsync(GetLobbyInfoRequest? request = null)
        {
            request.AppId ??= Config.AppId;
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/lobby/v2/{appId}/info/{roomId}", request);
            

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbGET);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", $"speakeasy-sdk/{_target} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _defaultClient;
            
            var httpResponse = await client.SendAsync(httpRequest);
            switch (httpResponse.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                case UnityWebRequest.Result.ProtocolError:
                    var errorMsg = httpResponse.error;
                    httpRequest.Dispose();
                    throw new Exception(errorMsg);
            }

            var contentType = httpResponse.GetResponseHeader("Content-Type");
            var response = new GetLobbyInfoResponse
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Lobby = JsonConvert.DeserializeObject<Lobby>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter() }});
                }
                
                return response;
            }
            if((response.StatusCode == 404))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.GetLobbyInfo404ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            return response;
        }
        

        /// <summary>
        /// Get all active lobbies for a given [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Filter the array by optionally passing in a `region`.
        /// </summary>
        public async Task<ListActivePublicLobbiesResponse> ListActivePublicLobbiesAsync(ListActivePublicLobbiesRequest? request = null)
        {
            request.AppId ??= Config.AppId;
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/lobby/v2/{appId}/list/public", request);
            

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbGET);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", $"speakeasy-sdk/{_target} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _defaultClient;
            
            var httpResponse = await client.SendAsync(httpRequest);
            switch (httpResponse.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                case UnityWebRequest.Result.ProtocolError:
                    var errorMsg = httpResponse.error;
                    httpRequest.Dispose();
                    throw new Exception(errorMsg);
            }

            var contentType = httpResponse.GetResponseHeader("Content-Type");
            var response = new ListActivePublicLobbiesResponse
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Lobbies = JsonConvert.DeserializeObject<List<Lobby>>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter() }});
                }
                
                return response;
            }
            return response;
        }
        

        /// <summary>
        /// Set the state of a lobby using `appId` and `roomId`. State is intended to be set by the server and must be smaller than 1MB.
        /// </summary>
        public async Task<SetLobbyStateResponse> SetLobbyStateAsync(SetLobbyStateSecurity security, Models.Operations.SetLobbyStateRequest request)
        {
            request.AppId ??= Config.AppId;
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/lobby/v2/{appId}/setState/{roomId}", request);
            

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbPOST);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", $"speakeasy-sdk/{_target} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            var serializedBody = RequestBodySerializer.Serialize(request, "SetLobbyStateRequestValue", "json");
            if (serializedBody == null) 
            {
                throw new ArgumentNullException("request body is required");
            }
            else
            {
                httpRequest.uploadHandler = new UploadHandlerRaw(serializedBody.Body);
                httpRequest.SetRequestHeader("Content-Type", serializedBody.ContentType);
            }
            
            var client = SecuritySerializer.Apply(_defaultClient, security);
            
            var httpResponse = await client.SendAsync(httpRequest);
            switch (httpResponse.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                case UnityWebRequest.Result.ProtocolError:
                    var errorMsg = httpResponse.error;
                    httpRequest.Dispose();
                    throw new Exception(errorMsg);
            }

            var contentType = httpResponse.GetResponseHeader("Content-Type");
            var response = new SetLobbyStateResponse
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Lobby = JsonConvert.DeserializeObject<Lobby>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter() }});
                }
                
                return response;
            }
            if((response.StatusCode == 404))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.SetLobbyState404ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 422))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.SetLobbyState422ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            return response;
        }
        
    }
}