// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Grafana.Models
{
    /// <summary> Properties specific to the grafana resource. </summary>
    public partial class ManagedGrafanaProperties
    {
        /// <summary> Initializes a new instance of ManagedGrafanaProperties. </summary>
        public ManagedGrafanaProperties()
        {
        }

        /// <summary> Initializes a new instance of ManagedGrafanaProperties. </summary>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="grafanaVersion"> The Grafana software version. </param>
        /// <param name="endpoint"> The endpoint of the Grafana instance. </param>
        /// <param name="zoneRedundancy"></param>
        /// <param name="autoGeneratedDomainNameLabelScope"></param>
        internal ManagedGrafanaProperties(ProvisioningState? provisioningState, string grafanaVersion, string endpoint, ZoneRedundancy? zoneRedundancy, AutoGeneratedDomainNameLabelScope? autoGeneratedDomainNameLabelScope)
        {
            ProvisioningState = provisioningState;
            GrafanaVersion = grafanaVersion;
            Endpoint = endpoint;
            ZoneRedundancy = zoneRedundancy;
            AutoGeneratedDomainNameLabelScope = autoGeneratedDomainNameLabelScope;
        }

        /// <summary> Provisioning state of the resource. </summary>
        public ProvisioningState? ProvisioningState { get; set; }
        /// <summary> The Grafana software version. </summary>
        public string GrafanaVersion { get; }
        /// <summary> The endpoint of the Grafana instance. </summary>
        public string Endpoint { get; }
        /// <summary> Gets or sets the zone redundancy. </summary>
        public ZoneRedundancy? ZoneRedundancy { get; set; }
        /// <summary> Gets or sets the auto generated domain name label scope. </summary>
        public AutoGeneratedDomainNameLabelScope? AutoGeneratedDomainNameLabelScope { get; set; }
    }
}
