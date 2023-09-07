
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
    using UnityEngine;
    
    
    [Serializable]
    public class GetLogsForProcessResponse: IDisposable
    {
        [SerializeField]
        public string? ContentType { get; set; } = default!;
        
        /// <summary>
        /// Ok
        /// </summary>
        [SerializeField]
        public MemoryQueueBufferStream? GetLogsForProcess200TextPlainBinaryString { get; set; }
        
        [SerializeField]
        public string? GetLogsForProcess404ApplicationJSONString { get; set; }
        
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