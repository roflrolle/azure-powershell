// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Runtime.Extensions;

    /// <summary>The manifest for the custom resource provider</summary>
    public partial class CustomRpManifestProperties :
        Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Models.ICustomRpManifestProperties,
        Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Models.ICustomRpManifestPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Action" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Models.ICustomRpActionRouteDefinition> _action;

        /// <summary>A list of actions that the custom resource provider implements.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Models.ICustomRpActionRouteDefinition> Action { get => this._action; set => this._action = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Models.ICustomRpManifestPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The provisioning state of the resource provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="ResourceType" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Models.ICustomRpResourceTypeRouteDefinition> _resourceType;

        /// <summary>A list of resource types that the custom resource provider implements.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Models.ICustomRpResourceTypeRouteDefinition> ResourceType { get => this._resourceType; set => this._resourceType = value; }

        /// <summary>Backing field for <see cref="Validation" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Models.ICustomRpValidations> _validation;

        /// <summary>A list of validations to run on the custom resource provider's requests.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Models.ICustomRpValidations> Validation { get => this._validation; set => this._validation = value; }

        /// <summary>Creates an new <see cref="CustomRpManifestProperties" /> instance.</summary>
        public CustomRpManifestProperties()
        {

        }
    }
    /// The manifest for the custom resource provider
    public partial interface ICustomRpManifestProperties :
        Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Runtime.IJsonSerializable
    {
        /// <summary>A list of actions that the custom resource provider implements.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A list of actions that the custom resource provider implements.",
        SerializedName = @"actions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Models.ICustomRpActionRouteDefinition) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Models.ICustomRpActionRouteDefinition> Action { get; set; }
        /// <summary>The provisioning state of the resource provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The provisioning state of the resource provider.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.PSArgumentCompleterAttribute("Accepted", "Deleting", "Running", "Succeeded", "Failed")]
        string ProvisioningState { get;  }
        /// <summary>A list of resource types that the custom resource provider implements.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A list of resource types that the custom resource provider implements.",
        SerializedName = @"resourceTypes",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Models.ICustomRpResourceTypeRouteDefinition) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Models.ICustomRpResourceTypeRouteDefinition> ResourceType { get; set; }
        /// <summary>A list of validations to run on the custom resource provider's requests.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A list of validations to run on the custom resource provider's requests.",
        SerializedName = @"validations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Models.ICustomRpValidations) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Models.ICustomRpValidations> Validation { get; set; }

    }
    /// The manifest for the custom resource provider
    internal partial interface ICustomRpManifestPropertiesInternal

    {
        /// <summary>A list of actions that the custom resource provider implements.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Models.ICustomRpActionRouteDefinition> Action { get; set; }
        /// <summary>The provisioning state of the resource provider.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.PSArgumentCompleterAttribute("Accepted", "Deleting", "Running", "Succeeded", "Failed")]
        string ProvisioningState { get; set; }
        /// <summary>A list of resource types that the custom resource provider implements.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Models.ICustomRpResourceTypeRouteDefinition> ResourceType { get; set; }
        /// <summary>A list of validations to run on the custom resource provider's requests.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CustomProviders.Models.ICustomRpValidations> Validation { get; set; }

    }
}