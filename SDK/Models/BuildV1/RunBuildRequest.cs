
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SDK.Models.BuildV1
{
    using System;
using System.Net.Http;
using Newtonsoft.Json;
using SDK.Utils;
    
    public class RunBuildRequest
    {
        
        [JsonProperty("RequestBody")]
        public RunBuildRequestBody RequestBody { get; set; }
        
        
        [JsonProperty("appId")]
        public string AppId { get; set; }
        
        
        [JsonProperty("buildId")]
        public int BuildId { get; set; }
        
        internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, RunBuildRequest value, string baseUrl)
        {
            if("RunBuild" == operationId)
            {
                
                
                var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
                
                var buildId = PathParamSerializer.Serialize("simple", false, value.BuildId);
                var message = new HttpRequestMessage(HttpMethod.Post, baseUrl + $"/builds/v1/{appId}/run/{buildId}");
                var formDataContent = new MultipartFormDataContent();
                
                formDataContent.Add(new ByteArrayContent(value.RequestBody.File.Content), value.RequestBody.File.File, Utilities.ToString(value.RequestBody.File.Content));

                message.Content = formDataContent;
                return message;
            }
            throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [RunBuildRequest]");
        }
    }
}