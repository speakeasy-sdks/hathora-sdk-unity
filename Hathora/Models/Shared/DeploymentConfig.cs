
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
/// User specified deployment configuration for your application at runtime.
/// </summary>
    public class DeploymentConfig
    {
    /// <summary>
    /// Additional ports your server listens on.
    /// </summary>
        
        [JsonProperty("additionalContainerPorts")]
        public List<ContainerPort>? AdditionalContainerPorts { get; set; }
        
    /// <summary>
    /// Default port the server listens on.
    /// </summary>
        
        [JsonProperty("containerPort")]
        public int ContainerPort { get; set; }
        
    /// <summary>
    /// The environment variable that our process will have access to at runtime.
    /// </summary>
        
        [JsonProperty("env")]
        public List<DeploymentConfigEnv> Env { get; set; }
        
    /// <summary>
    /// A plan defines how much CPU and memory is required to run an instance of your game server.
    /// 
    /// <remarks>
    /// 
    /// `tiny`: shared core, 1gb memory
    /// 
    /// `small`: 1 core, 2gb memory
    /// 
    /// `medium`: 2 core, 4gb memory
    /// 
    /// `large`: 4 core, 8gb memory
    /// </remarks>
    /// </summary>
        
        [JsonProperty("planName")]
        public PlanName PlanName { get; set; }
        
    /// <summary>
    /// Governs how many [rooms](https://hathora.dev/docs/concepts/hathora-entities#room) can be scheduled in a process.
    /// </summary>
        
        [JsonProperty("roomsPerProcess")]
        public int RoomsPerProcess { get; set; }
        
    /// <summary>
    /// Transport type specifies the underlying communication protocol to the exposed port.
    /// </summary>
        
        [JsonProperty("transportType")]
        public TransportType TransportType { get; set; }
        
    }
}