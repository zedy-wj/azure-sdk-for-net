// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class CustomImagePropertiesFromVm : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SourceVmId))
            {
                writer.WritePropertyName("sourceVmId");
                writer.WriteStringValue(SourceVmId);
            }
            if (Optional.IsDefined(WindowsOSInfo))
            {
                writer.WritePropertyName("windowsOsInfo");
                writer.WriteObjectValue(WindowsOSInfo);
            }
            if (Optional.IsDefined(LinuxOSInfo))
            {
                writer.WritePropertyName("linuxOsInfo");
                writer.WriteObjectValue(LinuxOSInfo);
            }
            writer.WriteEndObject();
        }

        internal static CustomImagePropertiesFromVm DeserializeCustomImagePropertiesFromVm(JsonElement element)
        {
            Optional<string> sourceVmId = default;
            Optional<WindowsOSInfo> windowsOSInfo = default;
            Optional<LinuxOSInfo> linuxOSInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceVmId"))
                {
                    sourceVmId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("windowsOsInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    windowsOSInfo = WindowsOSInfo.DeserializeWindowsOSInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("linuxOsInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    linuxOSInfo = LinuxOSInfo.DeserializeLinuxOSInfo(property.Value);
                    continue;
                }
            }
            return new CustomImagePropertiesFromVm(sourceVmId.Value, windowsOSInfo.Value, linuxOSInfo.Value);
        }
    }
}
