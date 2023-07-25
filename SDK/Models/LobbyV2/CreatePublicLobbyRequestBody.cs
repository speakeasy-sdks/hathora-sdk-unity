
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
    using Newtonsoft.Json;
using SDK.Models.Shared;
    
    public class CreatePublicLobbyRequestBody
    {
    /// <summary>
    /// User input to initialize the game state. Object must be smaller than 64KB.
    /// </summary>
        
        [JsonProperty("initialConfig")]
        public LobbyInitialConfig InitialConfig { get; set; }
        
    /// <summary>
    /// Available regions to request a game server.
    /// </summary>
        
        [JsonProperty("region")]
        public Region Region { get; set; }
        
    }
}