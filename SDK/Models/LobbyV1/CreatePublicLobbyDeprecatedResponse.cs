
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SDK.Models.LobbyV1
{
    using System.Net.Http;
    
    public class CreatePublicLobbyDeprecatedResponse {
        public string? ContentType { get; set; }
        
        public string? CreatePublicLobbyDeprecated400ApplicationJSONString { get; set; }
        
        public string? CreatePublicLobbyDeprecated401ApplicationJSONString { get; set; }
        
        public string? CreatePublicLobbyDeprecated404ApplicationJSONString { get; set; }
        
        public string? CreatePublicLobbyDeprecated422ApplicationJSONString { get; set; }
        
        public string? CreatePublicLobbyDeprecated429ApplicationJSONString { get; set; }
        
        public string? CreatePublicLobbyDeprecated500ApplicationJSONString { get; set; }
        
    /// <summary>
    /// Ok
    /// </summary>
        public string? RoomId { get; set; }
        
        public int StatusCode { get; set; }
        
        public HttpResponseMessage? RawResponse { get; set; }
        
    }
}