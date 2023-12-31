
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
    /// A plan defines how much CPU and memory is required to run an instance of your game server.
    /// 
    /// <remarks>
    /// 
    /// `tiny`: shared core, 1gb memory
    /// 
    /// `small`: 1 core, 2gb memory
    /// 
    /// `medium`: 2 core, 4gb memory
    /// 
    /// `large`: 4 core, 8gb memory
    /// </remarks>
    /// </summary>
    public enum PlanName
    {
    	[JsonProperty("tiny")]
		Tiny,
		[JsonProperty("small")]
		Small,
		[JsonProperty("medium")]
		Medium,
		[JsonProperty("large")]
		Large,
    }
    
    public static class PlanNameExtension
    {
        public static string Value(this PlanName value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PlanName ToEnum(this string value)
        {
            foreach(var field in typeof(PlanName).GetFields())
            {
                var attribute = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    return (PlanName)field.GetValue(null);
                }
            }

            throw new Exception($"Unknown value {value} for enum PlanName");
        }
    }
    
}