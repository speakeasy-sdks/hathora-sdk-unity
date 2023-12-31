
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
    using System;
    using UnityEngine;
    
    
    /// <summary>
    /// Configure [player authentication](https://hathora.dev/docs/lobbies-and-matchmaking/auth-service) for your application. Use Hathora's built-in auth providers or use your own [custom authentication](https://hathora.dev/docs/lobbies-and-matchmaking/auth-service#custom-auth-provider).
    /// </summary>
    [Serializable]
    public class AuthConfiguration
    {
        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [SerializeField]
        [JsonProperty("anonymous")]
        public RecordStringNever? Anonymous { get; set; }
        
        /// <summary>
        /// Enable google auth for your application.
        /// </summary>
        [SerializeField]
        [JsonProperty("google")]
        public AuthConfigurationGoogle? Google { get; set; }
        
        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [SerializeField]
        [JsonProperty("nickname")]
        public RecordStringNever? Nickname { get; set; }
        
    }
    
}