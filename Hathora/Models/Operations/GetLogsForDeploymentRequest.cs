
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
    public class GetLogsForDeploymentRequest
    {
        [SerializeField]
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=appId")]
        public string AppId { get; set; } = default!;
        
        [SerializeField]
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=deploymentId")]
        public int DeploymentId { get; set; } = default!;
        
        [SerializeField]
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=follow")]
        public bool? Follow { get; set; }
        
        [SerializeField]
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=tailLines")]
        public int? TailLines { get; set; }
        
    }
    
}