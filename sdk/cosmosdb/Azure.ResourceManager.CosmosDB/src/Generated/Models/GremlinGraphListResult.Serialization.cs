// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class GremlinGraphListResult
    {
        internal static GremlinGraphListResult DeserializeGremlinGraphListResult(JsonElement element)
        {
            Optional<IReadOnlyList<GremlinGraphData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<GremlinGraphData> array = new List<GremlinGraphData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GremlinGraphData.DeserializeGremlinGraphData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new GremlinGraphListResult(Optional.ToList(value));
        }
    }
}
