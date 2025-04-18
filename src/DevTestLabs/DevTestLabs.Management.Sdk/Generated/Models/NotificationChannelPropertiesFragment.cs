// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System.Linq;

    /// <summary>
    /// Properties of a schedule.
    /// </summary>
    public partial class NotificationChannelPropertiesFragment
    {
        /// <summary>
        /// Initializes a new instance of the NotificationChannelPropertiesFragment class.
        /// </summary>
        public NotificationChannelPropertiesFragment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NotificationChannelPropertiesFragment class.
        /// </summary>

        /// <param name="webHookUrl">The webhook URL to send notifications to.
        /// </param>

        /// <param name="description">Description of notification.
        /// </param>

        /// <param name="events">The list of event for which this notification is enabled.
        /// </param>

        /// <param name="provisioningState">The provisioning status of the resource.
        /// </param>

        /// <param name="uniqueIdentifier">The unique immutable identifier of a resource (Guid).
        /// </param>
        public NotificationChannelPropertiesFragment(string webHookUrl = default(string), string description = default(string), System.Collections.Generic.IList<EventFragment> events = default(System.Collections.Generic.IList<EventFragment>), string provisioningState = default(string), string uniqueIdentifier = default(string))

        {
            this.WebHookUrl = webHookUrl;
            this.Description = description;
            this.Events = events;
            this.ProvisioningState = provisioningState;
            this.UniqueIdentifier = uniqueIdentifier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the webhook URL to send notifications to.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "webHookUrl")]
        public string WebHookUrl {get; set; }

        /// <summary>
        /// Gets or sets description of notification.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        public string Description {get; set; }

        /// <summary>
        /// Gets or sets the list of event for which this notification is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "events")]
        public System.Collections.Generic.IList<EventFragment> Events {get; set; }

        /// <summary>
        /// Gets or sets the provisioning status of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState {get; set; }

        /// <summary>
        /// Gets or sets the unique immutable identifier of a resource (Guid).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "uniqueIdentifier")]
        public string UniqueIdentifier {get; set; }
    }
}