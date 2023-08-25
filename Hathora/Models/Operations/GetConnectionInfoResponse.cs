
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Hathora.Models.Operations
{
    using Hathora.Models.Shared;
    using System;
    using UnityEngine.Networking;
    
    
    public class GetConnectionInfoResponse: IDisposable
    {
        /// <summary>
        /// Ok
        /// </summary>
        
        public ConnectionInfoV2? ConnectionInfoV2 { get; set; }
        
        
        public string? ContentType { get; set; }
        
        
        public string? GetConnectionInfo400ApplicationJSONString { get; set; }
        
        
        public string? GetConnectionInfo404ApplicationJSONString { get; set; }
        
        
        public string? GetConnectionInfo500ApplicationJSONString { get; set; }
        
        
        public int StatusCode { get; set; }
        
        
        public UnityWebRequest? RawResponse { get; set; }
        
        public void Dispose() {
            if (RawResponse != null) {
                RawResponse.Dispose();
            }
        }
    }
    
}