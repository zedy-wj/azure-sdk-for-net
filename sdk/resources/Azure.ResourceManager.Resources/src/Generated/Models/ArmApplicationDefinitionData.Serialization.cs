// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    public partial class ArmApplicationDefinitionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ManagedBy))
            {
                writer.WritePropertyName("managedBy");
                writer.WriteStringValue(ManagedBy);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("lockLevel");
            writer.WriteStringValue(LockLevel.ToSerialString());
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("isEnabled");
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsCollectionDefined(Authorizations))
            {
                writer.WritePropertyName("authorizations");
                writer.WriteStartArray();
                foreach (var item in Authorizations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Artifacts))
            {
                writer.WritePropertyName("artifacts");
                writer.WriteStartArray();
                foreach (var item in Artifacts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(PackageFileUri))
            {
                writer.WritePropertyName("packageFileUri");
                writer.WriteStringValue(PackageFileUri.AbsoluteUri);
            }
            if (Optional.IsDefined(MainTemplate))
            {
                writer.WritePropertyName("mainTemplate");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(MainTemplate);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(MainTemplate.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(CreateUiDefinition))
            {
                writer.WritePropertyName("createUiDefinition");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(CreateUiDefinition);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(CreateUiDefinition.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(NotificationPolicy))
            {
                writer.WritePropertyName("notificationPolicy");
                writer.WriteObjectValue(NotificationPolicy);
            }
            if (Optional.IsDefined(LockingPolicy))
            {
                writer.WritePropertyName("lockingPolicy");
                writer.WriteObjectValue(LockingPolicy);
            }
            if (Optional.IsDefined(DeploymentPolicy))
            {
                writer.WritePropertyName("deploymentPolicy");
                writer.WriteObjectValue(DeploymentPolicy);
            }
            if (Optional.IsDefined(ManagementPolicy))
            {
                writer.WritePropertyName("managementPolicy");
                writer.WriteObjectValue(ManagementPolicy);
            }
            if (Optional.IsCollectionDefined(Policies))
            {
                writer.WritePropertyName("policies");
                writer.WriteStartArray();
                foreach (var item in Policies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ArmApplicationDefinitionData DeserializeArmApplicationDefinitionData(JsonElement element)
        {
            Optional<string> managedBy = default;
            Optional<ArmApplicationSku> sku = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            ArmApplicationLockLevel lockLevel = default;
            Optional<string> displayName = default;
            Optional<bool> isEnabled = default;
            Optional<IList<ArmApplicationAuthorization>> authorizations = default;
            Optional<IList<ArmApplicationDefinitionArtifact>> artifacts = default;
            Optional<string> description = default;
            Optional<Uri> packageFileUri = default;
            Optional<BinaryData> mainTemplate = default;
            Optional<BinaryData> createUiDefinition = default;
            Optional<ArmApplicationNotificationPolicy> notificationPolicy = default;
            Optional<ArmApplicationPackageLockingPolicy> lockingPolicy = default;
            Optional<ArmApplicationDeploymentPolicy> deploymentPolicy = default;
            Optional<ArmApplicationManagementPolicy> managementPolicy = default;
            Optional<IList<ArmApplicationPolicy>> policies = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedBy"))
                {
                    managedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = ArmApplicationSku.DeserializeArmApplicationSku(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("lockLevel"))
                        {
                            lockLevel = property0.Value.GetString().ToArmApplicationLockLevel();
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("authorizations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ArmApplicationAuthorization> array = new List<ArmApplicationAuthorization>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ArmApplicationAuthorization.DeserializeArmApplicationAuthorization(item));
                            }
                            authorizations = array;
                            continue;
                        }
                        if (property0.NameEquals("artifacts"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ArmApplicationDefinitionArtifact> array = new List<ArmApplicationDefinitionArtifact>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ArmApplicationDefinitionArtifact.DeserializeArmApplicationDefinitionArtifact(item));
                            }
                            artifacts = array;
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("packageFileUri"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                packageFileUri = null;
                                continue;
                            }
                            packageFileUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("mainTemplate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            mainTemplate = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("createUiDefinition"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createUiDefinition = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("notificationPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            notificationPolicy = ArmApplicationNotificationPolicy.DeserializeArmApplicationNotificationPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("lockingPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lockingPolicy = ArmApplicationPackageLockingPolicy.DeserializeArmApplicationPackageLockingPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("deploymentPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            deploymentPolicy = ArmApplicationDeploymentPolicy.DeserializeArmApplicationDeploymentPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("managementPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            managementPolicy = ArmApplicationManagementPolicy.DeserializeArmApplicationManagementPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("policies"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ArmApplicationPolicy> array = new List<ArmApplicationPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ArmApplicationPolicy.DeserializeArmApplicationPolicy(item));
                            }
                            policies = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ArmApplicationDefinitionData(id, name, type, systemData, tags, location, managedBy.Value, sku.Value, lockLevel, displayName.Value, Optional.ToNullable(isEnabled), Optional.ToList(authorizations), Optional.ToList(artifacts), description.Value, packageFileUri.Value, mainTemplate.Value, createUiDefinition.Value, notificationPolicy.Value, lockingPolicy.Value, deploymentPolicy.Value, managementPolicy.Value, Optional.ToList(policies));
        }
    }
}
