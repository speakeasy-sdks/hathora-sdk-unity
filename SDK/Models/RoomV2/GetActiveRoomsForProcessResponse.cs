
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SDK.Models.RoomV2
{
    using System.Collections.Generic;
using System.Net.Http;
using SDK.Models.Shared;
    
    public class GetActiveRoomsForProcessResponse {
        public string? ContentType { get; set; }
        
        public string? GetActiveRoomsForProcess404ApplicationJSONString { get; set; }
        
    /// <summary>
    /// Ok
    /// </summary>
        public List<RoomWithoutAllocations>? RoomWithoutAllocations { get; set; }
        
        public int StatusCode { get; set; }
        
        public HttpResponseMessage? RawResponse { get; set; }
        
    }
}