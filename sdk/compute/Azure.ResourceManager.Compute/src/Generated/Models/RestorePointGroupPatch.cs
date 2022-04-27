// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Update Restore Point collection parameters. </summary>
    public partial class RestorePointGroupPatch : UpdateResource
    {
        /// <summary> Initializes a new instance of RestorePointGroupPatch. </summary>
        public RestorePointGroupPatch()
        {
            RestorePoints = new ChangeTrackingList<RestorePointData>();
        }

        /// <summary> The properties of the source resource that this restore point collection is created from. </summary>
        public RestorePointCollectionSourceProperties Source { get; set; }
        /// <summary> The provisioning state of the restore point collection. </summary>
        public string ProvisioningState { get; }
        /// <summary> The unique id of the restore point collection. </summary>
        public string RestorePointCollectionId { get; }
        /// <summary> A list containing all restore points created under this restore point collection. </summary>
        public IReadOnlyList<RestorePointData> RestorePoints { get; }
    }
}
