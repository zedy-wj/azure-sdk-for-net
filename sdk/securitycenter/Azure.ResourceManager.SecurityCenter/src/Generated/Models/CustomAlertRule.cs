// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary>
    /// A custom alert rule.
    /// Please note <see cref="CustomAlertRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AllowlistCustomAlertRule"/>, <see cref="AmqpC2DMessagesNotInAllowedRange"/>, <see cref="AmqpC2DRejectedMessagesNotInAllowedRange"/>, <see cref="AmqpD2CMessagesNotInAllowedRange"/>, <see cref="ConnectionFromIPNotAllowed"/>, <see cref="ConnectionToIPNotAllowed"/>, <see cref="DenylistCustomAlertRule"/>, <see cref="DirectMethodInvokesNotInAllowedRange"/>, <see cref="FailedLocalLoginsNotInAllowedRange"/>, <see cref="FileUploadsNotInAllowedRange"/>, <see cref="HttpC2DMessagesNotInAllowedRange"/>, <see cref="HttpC2DRejectedMessagesNotInAllowedRange"/>, <see cref="HttpD2CMessagesNotInAllowedRange"/>, <see cref="ListCustomAlertRule"/>, <see cref="LocalUserNotAllowed"/>, <see cref="MqttC2DMessagesNotInAllowedRange"/>, <see cref="MqttC2DRejectedMessagesNotInAllowedRange"/>, <see cref="MqttD2CMessagesNotInAllowedRange"/>, <see cref="ProcessNotAllowed"/>, <see cref="QueuePurgesNotInAllowedRange"/>, <see cref="TwinUpdatesNotInAllowedRange"/>, <see cref="UnauthorizedOperationsNotInAllowedRange"/>, <see cref="ActiveConnectionsNotInAllowedRange"/>, <see cref="TimeWindowCustomAlertRule"/> and <see cref="ThresholdCustomAlertRule"/>.
    /// </summary>
    public abstract partial class CustomAlertRule
    {
        /// <summary> Initializes a new instance of CustomAlertRule. </summary>
        /// <param name="isEnabled"> Status of the custom alert. </param>
        protected CustomAlertRule(bool isEnabled)
        {
            IsEnabled = isEnabled;
        }

        /// <summary> Initializes a new instance of CustomAlertRule. </summary>
        /// <param name="displayName"> The display name of the custom alert. </param>
        /// <param name="description"> The description of the custom alert. </param>
        /// <param name="isEnabled"> Status of the custom alert. </param>
        /// <param name="ruleType"> The type of the custom alert rule. </param>
        internal CustomAlertRule(string displayName, string description, bool isEnabled, string ruleType)
        {
            DisplayName = displayName;
            Description = description;
            IsEnabled = isEnabled;
            RuleType = ruleType;
        }

        /// <summary> The display name of the custom alert. </summary>
        public string DisplayName { get; }
        /// <summary> The description of the custom alert. </summary>
        public string Description { get; }
        /// <summary> Status of the custom alert. </summary>
        public bool IsEnabled { get; set; }
        /// <summary> The type of the custom alert rule. </summary>
        internal string RuleType { get; set; }
    }
}
