
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
    using System.Net.Http;
using Newtonsoft.Json;
using SDK.Utils;
    
    public class CreateAppSecurity
    {
        
        [JsonProperty("auth0")]
        public string Auth0 { get; set; }
        
        // Operation security
        public static void Apply(CreateAppSecurity security, HttpRequestMessage message)
        {
            if(security == null)
            {
                return;
            }
            if(security.Auth0 != null)
            {
                message.Headers.Add("Authorization", Utilities.PrefixBearer(Utilities.ToString(security.Auth0)));
            }
        }
    }
}