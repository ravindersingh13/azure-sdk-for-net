// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of an application rule.
    /// </summary>
    public partial class AzureFirewallApplicationRule
    {
        /// <summary>
        /// Initializes a new instance of the AzureFirewallApplicationRule
        /// class.
        /// </summary>
        public AzureFirewallApplicationRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureFirewallApplicationRule
        /// class.
        /// </summary>
        /// <param name="name">Name of the application rule.</param>
        /// <param name="description">Description of the rule.</param>
        /// <param name="sourceAddresses">List of source IP addresses for this
        /// rule.</param>
        /// <param name="protocols">Array of ApplicationRuleProtocols.</param>
        /// <param name="targetFqdns">List of FQDNs for this rule.</param>
        /// <param name="fqdnTags">List of FQDN Tags for this rule.</param>
        /// <param name="sourceIpGroups">List of source IpGroups for this
        /// rule.</param>
        public AzureFirewallApplicationRule(string name = default(string), string description = default(string), IList<string> sourceAddresses = default(IList<string>), IList<AzureFirewallApplicationRuleProtocol> protocols = default(IList<AzureFirewallApplicationRuleProtocol>), IList<string> targetFqdns = default(IList<string>), IList<string> fqdnTags = default(IList<string>), IList<string> sourceIpGroups = default(IList<string>))
        {
            Name = name;
            Description = description;
            SourceAddresses = sourceAddresses;
            Protocols = protocols;
            TargetFqdns = targetFqdns;
            FqdnTags = fqdnTags;
            SourceIpGroups = sourceIpGroups;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the application rule.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets description of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets list of source IP addresses for this rule.
        /// </summary>
        [JsonProperty(PropertyName = "sourceAddresses")]
        public IList<string> SourceAddresses { get; set; }

        /// <summary>
        /// Gets or sets array of ApplicationRuleProtocols.
        /// </summary>
        [JsonProperty(PropertyName = "protocols")]
        public IList<AzureFirewallApplicationRuleProtocol> Protocols { get; set; }

        /// <summary>
        /// Gets or sets list of FQDNs for this rule.
        /// </summary>
        [JsonProperty(PropertyName = "targetFqdns")]
        public IList<string> TargetFqdns { get; set; }

        /// <summary>
        /// Gets or sets list of FQDN Tags for this rule.
        /// </summary>
        [JsonProperty(PropertyName = "fqdnTags")]
        public IList<string> FqdnTags { get; set; }

        /// <summary>
        /// Gets or sets list of source IpGroups for this rule.
        /// </summary>
        [JsonProperty(PropertyName = "sourceIpGroups")]
        public IList<string> SourceIpGroups { get; set; }

    }
}
