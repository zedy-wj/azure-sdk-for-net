// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class AvailabilityZoneMapping
    {
        internal static AvailabilityZoneMapping DeserializeAvailabilityZoneMapping(JsonElement element)
        {
            Optional<string> availabilityZone = default;
            Optional<bool> isAvailable = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("availabilityZone"))
                {
                    availabilityZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAvailable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isAvailable = property.Value.GetBoolean();
                    continue;
                }
            }
            return new AvailabilityZoneMapping(availabilityZone.Value, Optional.ToNullable(isAvailable));
        }
    }
}
