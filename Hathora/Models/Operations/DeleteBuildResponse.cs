
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
    using System;
    using UnityEngine.Networking;
    
    
    public class DeleteBuildResponse: IDisposable
    {
        
        public string? ContentType { get; set; }
        
        
        public string? DeleteBuild404ApplicationJSONString { get; set; }
        
        
        public string? DeleteBuild422ApplicationJSONString { get; set; }
        
        
        public string? DeleteBuild500ApplicationJSONString { get; set; }
        
        
        public int StatusCode { get; set; }
        
        
        public UnityWebRequest? RawResponse { get; set; }
        
        public void Dispose() {
            if (RawResponse != null) {
                RawResponse.Dispose();
            }
        }
    }
    
}