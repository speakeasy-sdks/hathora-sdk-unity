
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Hathora.Models.LobbyV2
{
    using UnityEngine.Networking;
using Hathora.Models.Shared;
    using System.Collections.Generic;
    public class CreateLocalLobbyResponse {
        public string? ContentType { get; set; }
        
        public string? CreateLocalLobby400ApplicationJSONString { get; set; }
        
        public string? CreateLocalLobby401ApplicationJSONString { get; set; }
        
        public string? CreateLocalLobby404ApplicationJSONString { get; set; }
        
        public string? CreateLocalLobby422ApplicationJSONString { get; set; }
        
        public string? CreateLocalLobby429ApplicationJSONString { get; set; }
        
        public string? CreateLocalLobby500ApplicationJSONString { get; set; }
        
        public Lobby? Lobby { get; set; }
        
        public int StatusCode { get; set; }
        
        public UnityWebRequest? RawResponse { get; set; }
        
    }
}