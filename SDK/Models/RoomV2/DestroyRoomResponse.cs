
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
    using System.Net.Http;
    
    public class DestroyRoomResponse {
        public string? ContentType { get; set; }
        
        public string? DestroyRoom404ApplicationJSONString { get; set; }
        
        public string? DestroyRoom500ApplicationJSONString { get; set; }
        
        public int StatusCode { get; set; }
        
        public HttpResponseMessage? RawResponse { get; set; }
        
    }
}