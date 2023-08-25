
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
    using Hathora.Utils;
    
    
    public class ListActivePublicLobbiesRequest
    {
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=appId")]
        public string AppId { get; set; }
        
        /// <summary>
        /// Region to filter by. If omitted, active public lobbies in all regions will be returned.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=region")]
        public Region? Region { get; set; }
        
    }
    
}