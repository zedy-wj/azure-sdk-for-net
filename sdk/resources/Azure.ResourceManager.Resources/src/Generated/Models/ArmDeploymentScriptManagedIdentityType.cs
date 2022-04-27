// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Type of the managed identity. </summary>
    public readonly partial struct ArmDeploymentScriptManagedIdentityType : IEquatable<ArmDeploymentScriptManagedIdentityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ArmDeploymentScriptManagedIdentityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ArmDeploymentScriptManagedIdentityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UserAssignedValue = "UserAssigned";

        /// <summary> UserAssigned. </summary>
        public static ArmDeploymentScriptManagedIdentityType UserAssigned { get; } = new ArmDeploymentScriptManagedIdentityType(UserAssignedValue);
        /// <summary> Determines if two <see cref="ArmDeploymentScriptManagedIdentityType"/> values are the same. </summary>
        public static bool operator ==(ArmDeploymentScriptManagedIdentityType left, ArmDeploymentScriptManagedIdentityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ArmDeploymentScriptManagedIdentityType"/> values are not the same. </summary>
        public static bool operator !=(ArmDeploymentScriptManagedIdentityType left, ArmDeploymentScriptManagedIdentityType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ArmDeploymentScriptManagedIdentityType"/>. </summary>
        public static implicit operator ArmDeploymentScriptManagedIdentityType(string value) => new ArmDeploymentScriptManagedIdentityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ArmDeploymentScriptManagedIdentityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ArmDeploymentScriptManagedIdentityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
