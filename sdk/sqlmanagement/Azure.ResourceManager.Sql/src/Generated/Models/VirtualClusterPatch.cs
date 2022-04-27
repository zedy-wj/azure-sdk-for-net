// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> An update request for an Azure SQL Database virtual cluster. </summary>
    public partial class VirtualClusterPatch
    {
        /// <summary> Initializes a new instance of VirtualClusterPatch. </summary>
        public VirtualClusterPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            ChildResources = new ChangeTrackingList<string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Subnet resource ID for the virtual cluster. </summary>
        public string SubnetId { get; }
        /// <summary> If the service has different generations of hardware, for the same SKU, then that can be captured here. </summary>
        public string Family { get; set; }
        /// <summary> List of resources in this virtual cluster. </summary>
        public IReadOnlyList<string> ChildResources { get; }
        /// <summary> Specifies maintenance configuration id to apply to this virtual cluster. </summary>
        public string MaintenanceConfigurationId { get; set; }
    }
}
