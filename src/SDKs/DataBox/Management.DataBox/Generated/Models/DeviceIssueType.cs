// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DeviceIssueType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeviceIssueType
    {
        [EnumMember(Value = "DeviceTampering")]
        DeviceTampering,
        [EnumMember(Value = "DeviceNotBootingUp")]
        DeviceNotBootingUp,
        [EnumMember(Value = "DeviceHealthCheckShowFailures")]
        DeviceHealthCheckShowFailures,
        [EnumMember(Value = "NICsAreNotWorking")]
        NICsAreNotWorking,
        [EnumMember(Value = "Misc")]
        Misc
    }
    internal static class DeviceIssueTypeEnumExtension
    {
        internal static string ToSerializedValue(this DeviceIssueType? value)
        {
            return value == null ? null : ((DeviceIssueType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DeviceIssueType value)
        {
            switch( value )
            {
                case DeviceIssueType.DeviceTampering:
                    return "DeviceTampering";
                case DeviceIssueType.DeviceNotBootingUp:
                    return "DeviceNotBootingUp";
                case DeviceIssueType.DeviceHealthCheckShowFailures:
                    return "DeviceHealthCheckShowFailures";
                case DeviceIssueType.NICsAreNotWorking:
                    return "NICsAreNotWorking";
                case DeviceIssueType.Misc:
                    return "Misc";
            }
            return null;
        }

        internal static DeviceIssueType? ParseDeviceIssueType(this string value)
        {
            switch( value )
            {
                case "DeviceTampering":
                    return DeviceIssueType.DeviceTampering;
                case "DeviceNotBootingUp":
                    return DeviceIssueType.DeviceNotBootingUp;
                case "DeviceHealthCheckShowFailures":
                    return DeviceIssueType.DeviceHealthCheckShowFailures;
                case "NICsAreNotWorking":
                    return DeviceIssueType.NICsAreNotWorking;
                case "Misc":
                    return DeviceIssueType.Misc;
            }
            return null;
        }
    }
}
