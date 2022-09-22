// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderForServersGcpOfferingArcAutoProvisioningConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId");
                writer.WriteStringValue(ClientId);
            }
            if (Optional.IsDefined(AgentOnboardingServiceAccountNumericId))
            {
                writer.WritePropertyName("agentOnboardingServiceAccountNumericId");
                writer.WriteStringValue(AgentOnboardingServiceAccountNumericId);
            }
            writer.WriteEndObject();
        }

        internal static DefenderForServersGcpOfferingArcAutoProvisioningConfiguration DeserializeDefenderForServersGcpOfferingArcAutoProvisioningConfiguration(JsonElement element)
        {
            Optional<string> clientId = default;
            Optional<string> agentOnboardingServiceAccountNumericId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientId"))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentOnboardingServiceAccountNumericId"))
                {
                    agentOnboardingServiceAccountNumericId = property.Value.GetString();
                    continue;
                }
            }
            return new DefenderForServersGcpOfferingArcAutoProvisioningConfiguration(clientId.Value, agentOnboardingServiceAccountNumericId.Value);
        }
    }
}
