// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ManagedClusterSubnet : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(IsIPv6Enabled))
            {
                writer.WritePropertyName("enableIpv6");
                writer.WriteBooleanValue(IsIPv6Enabled.Value);
            }
            if (Optional.IsDefined(PrivateEndpointNetworkPolicies))
            {
                writer.WritePropertyName("privateEndpointNetworkPolicies");
                writer.WriteStringValue(PrivateEndpointNetworkPolicies.Value.ToString());
            }
            if (Optional.IsDefined(PrivateLinkServiceNetworkPolicies))
            {
                writer.WritePropertyName("privateLinkServiceNetworkPolicies");
                writer.WriteStringValue(PrivateLinkServiceNetworkPolicies.Value.ToString());
            }
            if (Optional.IsDefined(NetworkSecurityGroupId))
            {
                writer.WritePropertyName("networkSecurityGroupId");
                writer.WriteStringValue(NetworkSecurityGroupId);
            }
            writer.WriteEndObject();
        }

        internal static ManagedClusterSubnet DeserializeManagedClusterSubnet(JsonElement element)
        {
            string name = default;
            Optional<bool> enableIPv6 = default;
            Optional<ManagedClusterSubnetPrivateEndpointNetworkPoliciesState> privateEndpointNetworkPolicies = default;
            Optional<ManagedClusterSubnetPrivateLinkServiceNetworkPoliciesState> privateLinkServiceNetworkPolicies = default;
            Optional<ResourceIdentifier> networkSecurityGroupId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableIpv6"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableIPv6 = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("privateEndpointNetworkPolicies"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    privateEndpointNetworkPolicies = new ManagedClusterSubnetPrivateEndpointNetworkPoliciesState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateLinkServiceNetworkPolicies"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    privateLinkServiceNetworkPolicies = new ManagedClusterSubnetPrivateLinkServiceNetworkPoliciesState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkSecurityGroupId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    networkSecurityGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new ManagedClusterSubnet(name, Optional.ToNullable(enableIPv6), Optional.ToNullable(privateEndpointNetworkPolicies), Optional.ToNullable(privateLinkServiceNetworkPolicies), networkSecurityGroupId.Value);
        }
    }
}
