// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.PowerShell;

    /// <summary>Properties of the devcenter plan member.</summary>
    [System.ComponentModel.TypeConverter(typeof(PlanMemberPropertiesTypeConverter))]
    public partial class PlanMemberProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.PlanMemberProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IPlanMemberProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IPlanMemberProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PlanMemberProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.PlanMemberProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IPlanMemberProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IPlanMemberProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PlanMemberProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PlanMemberProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="PlanMemberProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IPlanMemberProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.PlanMemberProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PlanMemberProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MemberId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IPlanMemberPropertiesInternal)this).MemberId = (string) content.GetValueForProperty("MemberId",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IPlanMemberPropertiesInternal)this).MemberId, global::System.Convert.ToString);
            }
            if (content.Contains("MemberType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IPlanMemberPropertiesInternal)this).MemberType = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.PlanMemberType?) content.GetValueForProperty("MemberType",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IPlanMemberPropertiesInternal)this).MemberType, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.PlanMemberType.CreateFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IPlanMemberPropertiesInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IPlanMemberPropertiesInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IPlanMemberPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IPlanMemberPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ProvisioningState.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.PlanMemberProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PlanMemberProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MemberId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IPlanMemberPropertiesInternal)this).MemberId = (string) content.GetValueForProperty("MemberId",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IPlanMemberPropertiesInternal)this).MemberId, global::System.Convert.ToString);
            }
            if (content.Contains("MemberType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IPlanMemberPropertiesInternal)this).MemberType = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.PlanMemberType?) content.GetValueForProperty("MemberType",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IPlanMemberPropertiesInternal)this).MemberType, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.PlanMemberType.CreateFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IPlanMemberPropertiesInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IPlanMemberPropertiesInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IPlanMemberPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IPlanMemberPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ProvisioningState.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Properties of the devcenter plan member.
    [System.ComponentModel.TypeConverter(typeof(PlanMemberPropertiesTypeConverter))]
    public partial interface IPlanMemberProperties

    {

    }
}