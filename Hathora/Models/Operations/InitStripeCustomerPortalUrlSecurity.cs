
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
    public class InitStripeCustomerPortalUrlSecurity
    {
        [SerializeField]
        [SpeakeasyMetadata("security:scheme=true,type=http,subType=bearer,name=Authorization")]
        public string Auth0 { get; set; } = default!;
        
    }
    
}