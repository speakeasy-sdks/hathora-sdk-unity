
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
    
    
    public enum VerificationEmailResponseStatus
    {
    	[JsonProperty("success")]
		Success,
    }
    
    public static class VerificationEmailResponseStatusExtension
    {
        public static string Value(this VerificationEmailResponseStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static VerificationEmailResponseStatus ToEnum(this string value)
        {
            foreach(var field in typeof(VerificationEmailResponseStatus).GetFields())
            {
                var attribute = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    return (VerificationEmailResponseStatus)field.GetValue(null);
                }
            }

            throw new Exception($"Unknown value {value} for enum VerificationEmailResponseStatus");
        }
    }
    
}