
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Hathora.Models.RoomV2
{
    using UnityEngine.Networking;
    using System.Collections.Generic;
    public class SuspendRoomResponse {
        public string? ContentType { get; set; }
        
        public int StatusCode { get; set; }
        
        public UnityWebRequest? RawResponse { get; set; }
        
        public string? SuspendRoom404ApplicationJSONString { get; set; }
        
        public string? SuspendRoom500ApplicationJSONString { get; set; }
        
    }
}