
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SDK.Models.BuildV1
{
    using System.Net.Http;
    
    public class RunBuildResponse {
        public string? ContentType { get; set; }
        
    /// <summary>
    /// Ok
    /// </summary>
        public string? RunBuild200TextPlainByteString { get; set; }
        
        public string? RunBuild404ApplicationJSONString { get; set; }
        
        public int StatusCode { get; set; }
        
        public HttpResponseMessage? RawResponse { get; set; }
        
        public string? RunBuild500ApplicationJSONString { get; set; }
        
    }
}