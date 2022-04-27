// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.FluidRelay;

namespace Azure.ResourceManager.FluidRelay.Models
{
    internal partial class FluidRelayServerList
    {
        internal static FluidRelayServerList DeserializeFluidRelayServerList(JsonElement element)
        {
            IReadOnlyList<FluidRelayServerData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<FluidRelayServerData> array = new List<FluidRelayServerData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FluidRelayServerData.DeserializeFluidRelayServerData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new FluidRelayServerList(value, nextLink.Value);
        }
    }
}
