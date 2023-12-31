
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
    using UnityEngine;
    
    
    [Serializable]
    public class DeleteBuildResponse: IDisposable
    {
        [SerializeField]
        public string? ContentType { get; set; } = default!;
        
        [SerializeField]
        public string? DeleteBuild404ApplicationJSONString { get; set; }
        
        [SerializeField]
        public string? DeleteBuild422ApplicationJSONString { get; set; }
        
        [SerializeField]
        public string? DeleteBuild500ApplicationJSONString { get; set; }
        
        [SerializeField]
        public int StatusCode { get; set; } = default!;
        
        [SerializeField]
        public UnityWebRequest? RawResponse { get; set; }
        
        public void Dispose() {
            if (RawResponse != null) {
                RawResponse.Dispose();
            }
        }
    }
    
}