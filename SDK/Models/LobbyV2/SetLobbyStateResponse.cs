
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
    using System.Net.Http;
using SDK.Models.Shared;
    
    public class SetLobbyStateResponse {
        public string? ContentType { get; set; }
        
    /// <summary>
    /// Ok
    /// </summary>
        public Lobby? Lobby { get; set; }
        
        public string? SetLobbyState404ApplicationJSONString { get; set; }
        
        public int StatusCode { get; set; }
        
        public HttpResponseMessage? RawResponse { get; set; }
        
        public string? SetLobbyState422ApplicationJSONString { get; set; }
        
    }
}