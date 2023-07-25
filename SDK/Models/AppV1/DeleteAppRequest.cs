
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SDK.Models.AppV1
{
    using System;
using System.Net.Http;
using Newtonsoft.Json;
using SDK.Utils;
    
    public class DeleteAppRequest
    {
        
        [JsonProperty("appId")]
        public string AppId { get; set; }
        
        internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, DeleteAppRequest value, string baseUrl)
        {
            if("DeleteApp" == operationId)
            {
                
                var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
                var message = new HttpRequestMessage(HttpMethod.Delete, baseUrl + $"/apps/v1/delete/{appId}");
                return message;
            }
            throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [DeleteAppRequest]");
        }
    }
}