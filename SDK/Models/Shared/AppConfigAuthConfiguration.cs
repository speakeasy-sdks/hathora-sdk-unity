
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SDK.Models.Shared
{
    using Newtonsoft.Json;
using SDK.Models.Shared;
    
    public class AppConfigAuthConfiguration
    {
    /// <summary>
    /// Construct a type with a set of properties K of type T
    /// </summary>
        
        [JsonProperty("anonymous")]
        public RecordStringNever? Anonymous { get; set; }
        
        
        [JsonProperty("google")]
        public AppConfigAuthConfigurationGoogle? Google { get; set; }
        
    /// <summary>
    /// Construct a type with a set of properties K of type T
    /// </summary>
        
        [JsonProperty("nickname")]
        public RecordStringNever? Nickname { get; set; }
        
    }
}