// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class NotificationSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(TimeInMinutes))
            {
                writer.WritePropertyName("timeInMinutes");
                writer.WriteNumberValue(TimeInMinutes.Value);
            }
            if (Optional.IsDefined(WebhookUri))
            {
                writer.WritePropertyName("webhookUrl");
                writer.WriteStringValue(WebhookUri.AbsoluteUri);
            }
            if (Optional.IsDefined(EmailRecipient))
            {
                writer.WritePropertyName("emailRecipient");
                writer.WriteStringValue(EmailRecipient);
            }
            if (Optional.IsDefined(NotificationLocale))
            {
                writer.WritePropertyName("notificationLocale");
                writer.WriteStringValue(NotificationLocale);
            }
            writer.WriteEndObject();
        }

        internal static NotificationSettings DeserializeNotificationSettings(JsonElement element)
        {
            Optional<EnableStatus> status = default;
            Optional<int> timeInMinutes = default;
            Optional<Uri> webhookUrl = default;
            Optional<string> emailRecipient = default;
            Optional<string> notificationLocale = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new EnableStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeInMinutes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timeInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("webhookUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        webhookUrl = null;
                        continue;
                    }
                    webhookUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("emailRecipient"))
                {
                    emailRecipient = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("notificationLocale"))
                {
                    notificationLocale = property.Value.GetString();
                    continue;
                }
            }
            return new NotificationSettings(Optional.ToNullable(status), Optional.ToNullable(timeInMinutes), webhookUrl.Value, emailRecipient.Value, notificationLocale.Value);
        }
    }
}
