// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> Public network access to the cluster is enabled by default. When disabled, only private endpoint connection to the cluster is allowed. </summary>
    public readonly partial struct KustoClusterPublicNetworkAccess : IEquatable<KustoClusterPublicNetworkAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KustoClusterPublicNetworkAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KustoClusterPublicNetworkAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static KustoClusterPublicNetworkAccess Enabled { get; } = new KustoClusterPublicNetworkAccess(EnabledValue);
        /// <summary> Disabled. </summary>
        public static KustoClusterPublicNetworkAccess Disabled { get; } = new KustoClusterPublicNetworkAccess(DisabledValue);
        /// <summary> Determines if two <see cref="KustoClusterPublicNetworkAccess"/> values are the same. </summary>
        public static bool operator ==(KustoClusterPublicNetworkAccess left, KustoClusterPublicNetworkAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KustoClusterPublicNetworkAccess"/> values are not the same. </summary>
        public static bool operator !=(KustoClusterPublicNetworkAccess left, KustoClusterPublicNetworkAccess right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KustoClusterPublicNetworkAccess"/>. </summary>
        public static implicit operator KustoClusterPublicNetworkAccess(string value) => new KustoClusterPublicNetworkAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KustoClusterPublicNetworkAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KustoClusterPublicNetworkAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
