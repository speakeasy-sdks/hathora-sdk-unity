
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
    using System.Collections.Generic;
using Newtonsoft.Json;
using Hathora.Models.Shared;
    using System.Collections.Generic;
/// <summary>
/// Connection information for the default and additional ports.
/// </summary>
    public class ConnectionInfoV2
    {
        
        [JsonProperty("additionalExposedPorts")]
        public List<ExposedPort> AdditionalExposedPorts { get; set; }
        
    /// <summary>
    /// Connection information to an exposed port on an active process.
    /// </summary>
        
        [JsonProperty("exposedPort")]
        public ExposedPort? ExposedPort { get; set; }
        
    /// <summary>
    /// Unique identifier to a game session or match. Use either a system generated ID or pass in your own.
    /// </summary>
        
        [JsonProperty("roomId")]
        public string RoomId { get; set; }
        
        
        [JsonProperty("status")]
        public ConnectionInfoV2Status Status { get; set; }
        
    }
}