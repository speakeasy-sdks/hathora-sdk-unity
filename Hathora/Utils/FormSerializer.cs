
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Hathora.Utils
{
    using UnityEngine.Networking;
    using System.Net.Http;

    // TODO: polyfill
    internal class FormSerializer
    {
        public static HttpContent Serialize(object value) =>
            new StringContent(Utilities.ToString(value) ?? "");
    }
}