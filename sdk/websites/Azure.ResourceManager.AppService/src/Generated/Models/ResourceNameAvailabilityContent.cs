// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Resource name availability request content. </summary>
    internal partial class ResourceNameAvailabilityContent
    {
        /// <summary> Initializes a new instance of ResourceNameAvailabilityContent. </summary>
        /// <param name="name"> Resource name to verify. </param>
        /// <param name="resourceType"> Resource type used for verification. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ResourceNameAvailabilityContent(string name, CheckNameResourceTypes resourceType)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            ResourceType = resourceType;
        }

        /// <summary> Resource name to verify. </summary>
        public string Name { get; }
        /// <summary> Resource type used for verification. </summary>
        public CheckNameResourceTypes ResourceType { get; }
        /// <summary> Is fully qualified domain name. </summary>
        public bool? IsFqdn { get; set; }
    }
}
