// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Extensions;

    /// <summary>The properties that define a received route.</summary>
    public partial class PeeringReceivedRoute :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringReceivedRoute,
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringReceivedRouteInternal
    {

        /// <summary>Backing field for <see cref="AsPath" /> property.</summary>
        private string _asPath;

        /// <summary>The AS path for the prefix.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        public string AsPath { get => this._asPath; }

        /// <summary>Internal Acessors for AsPath</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringReceivedRouteInternal.AsPath { get => this._asPath; set { {_asPath = value;} } }

        /// <summary>Internal Acessors for NextHop</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringReceivedRouteInternal.NextHop { get => this._nextHop; set { {_nextHop = value;} } }

        /// <summary>Internal Acessors for OriginAsValidationState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringReceivedRouteInternal.OriginAsValidationState { get => this._originAsValidationState; set { {_originAsValidationState = value;} } }

        /// <summary>Internal Acessors for Prefix</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringReceivedRouteInternal.Prefix { get => this._prefix; set { {_prefix = value;} } }

        /// <summary>Internal Acessors for ReceivedTimestamp</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringReceivedRouteInternal.ReceivedTimestamp { get => this._receivedTimestamp; set { {_receivedTimestamp = value;} } }

        /// <summary>Internal Acessors for RpkiValidationState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringReceivedRouteInternal.RpkiValidationState { get => this._rpkiValidationState; set { {_rpkiValidationState = value;} } }

        /// <summary>Internal Acessors for TrustAnchor</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringReceivedRouteInternal.TrustAnchor { get => this._trustAnchor; set { {_trustAnchor = value;} } }

        /// <summary>Backing field for <see cref="NextHop" /> property.</summary>
        private string _nextHop;

        /// <summary>The next hop for the prefix.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        public string NextHop { get => this._nextHop; }

        /// <summary>Backing field for <see cref="OriginAsValidationState" /> property.</summary>
        private string _originAsValidationState;

        /// <summary>The origin AS change information for the prefix.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        public string OriginAsValidationState { get => this._originAsValidationState; }

        /// <summary>Backing field for <see cref="Prefix" /> property.</summary>
        private string _prefix;

        /// <summary>The prefix.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        public string Prefix { get => this._prefix; }

        /// <summary>Backing field for <see cref="ReceivedTimestamp" /> property.</summary>
        private string _receivedTimestamp;

        /// <summary>The received timestamp associated with the prefix.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        public string ReceivedTimestamp { get => this._receivedTimestamp; }

        /// <summary>Backing field for <see cref="RpkiValidationState" /> property.</summary>
        private string _rpkiValidationState;

        /// <summary>
        /// The RPKI validation state for the prefix and origin AS that's listed in the AS path.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        public string RpkiValidationState { get => this._rpkiValidationState; }

        /// <summary>Backing field for <see cref="TrustAnchor" /> property.</summary>
        private string _trustAnchor;

        /// <summary>
        /// The authority which holds the Route Origin Authorization record for the prefix, if any.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        public string TrustAnchor { get => this._trustAnchor; }

        /// <summary>Creates an new <see cref="PeeringReceivedRoute" /> instance.</summary>
        public PeeringReceivedRoute()
        {

        }
    }
    /// The properties that define a received route.
    public partial interface IPeeringReceivedRoute :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.IJsonSerializable
    {
        /// <summary>The AS path for the prefix.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The AS path for the prefix.",
        SerializedName = @"asPath",
        PossibleTypes = new [] { typeof(string) })]
        string AsPath { get;  }
        /// <summary>The next hop for the prefix.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The next hop for the prefix.",
        SerializedName = @"nextHop",
        PossibleTypes = new [] { typeof(string) })]
        string NextHop { get;  }
        /// <summary>The origin AS change information for the prefix.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The origin AS change information for the prefix.",
        SerializedName = @"originAsValidationState",
        PossibleTypes = new [] { typeof(string) })]
        string OriginAsValidationState { get;  }
        /// <summary>The prefix.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The prefix.",
        SerializedName = @"prefix",
        PossibleTypes = new [] { typeof(string) })]
        string Prefix { get;  }
        /// <summary>The received timestamp associated with the prefix.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The received timestamp associated with the prefix.",
        SerializedName = @"receivedTimestamp",
        PossibleTypes = new [] { typeof(string) })]
        string ReceivedTimestamp { get;  }
        /// <summary>
        /// The RPKI validation state for the prefix and origin AS that's listed in the AS path.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The RPKI validation state for the prefix and origin AS that's listed in the AS path.",
        SerializedName = @"rpkiValidationState",
        PossibleTypes = new [] { typeof(string) })]
        string RpkiValidationState { get;  }
        /// <summary>
        /// The authority which holds the Route Origin Authorization record for the prefix, if any.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The authority which holds the Route Origin Authorization record for the prefix, if any.",
        SerializedName = @"trustAnchor",
        PossibleTypes = new [] { typeof(string) })]
        string TrustAnchor { get;  }

    }
    /// The properties that define a received route.
    internal partial interface IPeeringReceivedRouteInternal

    {
        /// <summary>The AS path for the prefix.</summary>
        string AsPath { get; set; }
        /// <summary>The next hop for the prefix.</summary>
        string NextHop { get; set; }
        /// <summary>The origin AS change information for the prefix.</summary>
        string OriginAsValidationState { get; set; }
        /// <summary>The prefix.</summary>
        string Prefix { get; set; }
        /// <summary>The received timestamp associated with the prefix.</summary>
        string ReceivedTimestamp { get; set; }
        /// <summary>
        /// The RPKI validation state for the prefix and origin AS that's listed in the AS path.
        /// </summary>
        string RpkiValidationState { get; set; }
        /// <summary>
        /// The authority which holds the Route Origin Authorization record for the prefix, if any.
        /// </summary>
        string TrustAnchor { get; set; }

    }
}