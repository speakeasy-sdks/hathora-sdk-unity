
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
    using Hathora.Utils;
    using System;
    using UnityEngine.Networking;
    
    
    public class GetLogsForAppResponse: IDisposable
    {
        
        public string? ContentType { get; set; }
        
        /// <summary>
        /// Ok
        /// </summary>
        
        public MemoryQueueBufferStream? GetLogsForApp200TextPlainBinaryString { get; set; }
        
        
        public string? GetLogsForApp404ApplicationJSONString { get; set; }
        
        
        public int StatusCode { get; set; }
        
        
        public UnityWebRequest? RawResponse { get; set; }
        
        public void Dispose() {
            if (RawResponse != null) {
                RawResponse.Dispose();
            }
        }
    }
    
}