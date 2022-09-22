// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Search.Models
{
    internal partial class PrivateLinkResourcesResult
    {
        internal static PrivateLinkResourcesResult DeserializePrivateLinkResourcesResult(JsonElement element)
        {
            Optional<IReadOnlyList<SearchPrivateLinkResource>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SearchPrivateLinkResource> array = new List<SearchPrivateLinkResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SearchPrivateLinkResource.DeserializeSearchPrivateLinkResource(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new PrivateLinkResourcesResult(Optional.ToList(value));
        }
    }
}
