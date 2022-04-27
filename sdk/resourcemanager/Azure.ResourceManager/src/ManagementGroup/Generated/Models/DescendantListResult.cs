// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagementGroups.Models
{
    /// <summary> Describes the result of the request to view descendants. </summary>
    internal partial class DescendantListResult
    {
        /// <summary> Initializes a new instance of DescendantListResult. </summary>
        internal DescendantListResult()
        {
            Value = new ChangeTrackingList<DescendantData>();
        }

        /// <summary> Initializes a new instance of DescendantListResult. </summary>
        /// <param name="value"> The list of descendants. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal DescendantListResult(IReadOnlyList<DescendantData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of descendants. </summary>
        public IReadOnlyList<DescendantData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
