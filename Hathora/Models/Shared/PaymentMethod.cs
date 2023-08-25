
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Hathora.Models.Shared
{
    using Newtonsoft.Json;
    
    
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public class PaymentMethod
    {
        [JsonProperty("ach")]
        public AchPaymentMethod? Ach { get; set; }
        
        [JsonProperty("card")]
        public CardPaymentMethod? Card { get; set; }
        
        [JsonProperty("link")]
        public LinkPaymentMethod? Link { get; set; }
        
    }
    
}