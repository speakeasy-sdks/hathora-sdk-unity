
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
    using UnityEngine;
    
    
    [Serializable]
    public class GetInactiveRoomsForProcessDeprecatedRequest
    {
        [SerializeField]
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=processId")]
        public string ProcessId { get; set; } = default!;
        
        [SerializeField]
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=appId")]
        public string? AppId { get; set; }
        
    }
    
}