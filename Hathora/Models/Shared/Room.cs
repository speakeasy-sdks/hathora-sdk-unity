
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
    using System.Collections.Generic;
    using System;
    using UnityEngine;
    
    
    /// <summary>
    /// A room object represents a game session or match.
    /// </summary>
    [Serializable]
    public class Room
    {
        [SerializeField]
        [JsonProperty("allocations")]
        public List<RoomAllocation> Allocations { get; set; } = default!;
        
        /// <summary>
        /// System generated unique identifier for an application.
        /// </summary>
        [SerializeField]
        [JsonProperty("appId")]
        public string AppId { get; set; } = default!;
        
        [SerializeField]
        [JsonProperty("currentAllocation")]
        public RoomCurrentAllocation CurrentAllocation { get; set; } = default!;
        
        [SerializeField]
        [JsonProperty("roomConfig")]
        public string RoomConfig { get; set; } = default!;
        
        /// <summary>
        /// Unique identifier to a game session or match. Use either a system generated ID or pass in your own.
        /// </summary>
        [SerializeField]
        [JsonProperty("roomId")]
        public string RoomId { get; set; } = default!;
        
        /// <summary>
        /// The allocation status of a room.
        /// 
        /// <remarks>
        /// 
        /// `scheduling`: a process is not allocated yet and the room is waiting to be scheduled
        /// 
        /// `active`: ready to accept connections
        /// 
        /// `suspended`: room is unallocated from the process but can be rescheduled later with the same `roomId`
        /// 
        /// `destroyed`: all associated metadata is deleted
        /// </remarks>
        /// </summary>
        [SerializeField]
        [JsonProperty("status")]
        public RoomStatus Status { get; set; } = default!;
        
    }
    
}