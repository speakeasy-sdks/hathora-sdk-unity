
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
    using Newtonsoft.Json;
    
    
    /// <summary>
    /// Ok
    /// </summary>
    public class LoginResponse
    {
        /// <summary>
        /// A unique Hathora-signed JWT player token.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }
        
    }
    
}