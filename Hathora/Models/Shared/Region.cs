
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
    using System;
    using UnityEngine;
    
    
    /// <summary>
    /// Region to filter by. If omitted, active public lobbies in all regions will be returned.
    /// </summary>
    public enum Region
    {
    	[JsonProperty("Seattle")]
		Seattle,
		[JsonProperty("Washington_DC")]
		WashingtonDC,
		[JsonProperty("Chicago")]
		Chicago,
		[JsonProperty("London")]
		London,
		[JsonProperty("Frankfurt")]
		Frankfurt,
		[JsonProperty("Mumbai")]
		Mumbai,
		[JsonProperty("Singapore")]
		Singapore,
		[JsonProperty("Tokyo")]
		Tokyo,
		[JsonProperty("Sydney")]
		Sydney,
		[JsonProperty("Sao_Paulo")]
		SaoPaulo,
    }
    
    public static class RegionExtension
    {
        public static string Value(this Region value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static Region ToEnum(this string value)
        {
            foreach(var field in typeof(Region).GetFields())
            {
                var attribute = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    return (Region)field.GetValue(null);
                }
            }

            throw new Exception($"Unknown value {value} for enum Region");
        }
    }
    
}