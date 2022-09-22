// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Node type update request. </summary>
    public partial class ServiceFabricManagedNodeTypePatch
    {
        /// <summary> Initializes a new instance of ServiceFabricManagedNodeTypePatch. </summary>
        public ServiceFabricManagedNodeTypePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Node type update parameters. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The node type sku. </summary>
        public NodeTypeSku Sku { get; set; }
    }
}
