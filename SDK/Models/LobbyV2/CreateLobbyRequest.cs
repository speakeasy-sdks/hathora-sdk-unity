
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SDK.Models.LobbyV2
{
    using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using SDK.Models.Shared;
using SDK.Utils;
    
    public class CreateLobbyRequest
    {
        
        [JsonProperty("CreateLobbyRequest")]
        public CreateLobbyRequest CreateLobbyRequestValue { get; set; }
        
        
        [JsonProperty("appId")]
        public string AppId { get; set; }
        
        
        [JsonProperty("roomId")]
        public string? RoomId { get; set; }
        
        internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, CreateLobbyRequest value, string baseUrl)
        {
            if("CreateLobby" == operationId)
            {
                var queryParams = new List<string>();
                
                
                
                queryParams.Add(QueryParamSerializer.Serialize("form",true, "roomId", "", value.RoomId));
                var queryParamString = $"?{String.Join("&", queryParams)}";
                
                
                var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
                
                var message = new HttpRequestMessage(HttpMethod.Post, baseUrl + $"/lobby/v2/{appId}/create" + queryParamString);
                
                
                

                string json = JsonConvert.SerializeObject(value, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new IsoDateTimeSerializer(), new EnumSerializer() }});
                message.Content = new StringContent(json, Encoding.UTF8, "application/json");
                return message;
            }
            throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [CreateLobbyRequest]");
        }
    }
}