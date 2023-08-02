
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Hathora.Models.Shared
{
    using System;
using UnityEngine.Networking;
using System.Text;
using Newtonsoft.Json;
using Hathora.Utils;
    using System.Collections.Generic;
    public class VerificationEmailRequest
    {
        
        [JsonProperty("userId")]
        public string UserId { get; set; }
        
        internal static UnityWebRequest BuildHttpRequestMessage(string operationId, VerificationEmailRequest value, string baseUrl)
        {
            if("SendVerificationEmail" == operationId)
            {
                string json = JsonConvert.SerializeObject(value, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new IsoDateTimeSerializer(), new EnumSerializer() }});var urlString = baseUrl + "/management/v1/sendverificationemail";// #request-debugging post TODO: work in progress
                UnityWebRequest message;message = UnityWebRequest.Post(urlString, json, "application/json");
                return message;
            }
            throw new ArgumentException($"Attempt to build UnityWebRequest for invalid operationId [{operationId}] for request type [VerificationEmailRequest]");
        }
    }
}