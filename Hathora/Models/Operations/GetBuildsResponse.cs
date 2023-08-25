
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
    using System.Collections.Generic;
    using System;
    using UnityEngine.Networking;
    
    
    public class GetBuildsResponse: IDisposable
    {
        /// <summary>
        /// Ok
        /// </summary>
        
        public List<Build>? Builds { get; set; }
        
        
        public string? ContentType { get; set; }
        
        
        public string? GetBuilds404ApplicationJSONString { get; set; }
        
        
        public int StatusCode { get; set; }
        
        
        public UnityWebRequest? RawResponse { get; set; }
        
        public void Dispose() {
            if (RawResponse != null) {
                RawResponse.Dispose();
            }
        }
    }
    
}