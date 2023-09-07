
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
    /// Status of creating a build.
    /// 
    /// <remarks>
    /// 
    /// `created`: a new `buildId` was generated
    /// 
    /// `running`: the container image is being built
    /// 
    /// `succeeded`: the container image was successfully built and stored in our registry
    /// 
    /// `failed`: there was an issue creating and storing the container image in our container registry
    /// </remarks>
    /// </summary>
    public enum BuildStatus
    {
    	[JsonProperty("created")]
		Created,
		[JsonProperty("running")]
		Running,
		[JsonProperty("succeeded")]
		Succeeded,
		[JsonProperty("failed")]
		Failed,
    }
    
    public static class BuildStatusExtension
    {
        public static string Value(this BuildStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static BuildStatus ToEnum(this string value)
        {
            foreach(var field in typeof(BuildStatus).GetFields())
            {
                var attribute = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    return (BuildStatus)field.GetValue(null);
                }
            }

            throw new Exception($"Unknown value {value} for enum BuildStatus");
        }
    }
    
}