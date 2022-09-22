// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> DNS Service log level. </summary>
    public readonly partial struct DnsServiceLogLevel : IEquatable<DnsServiceLogLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DnsServiceLogLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DnsServiceLogLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DebugValue = "DEBUG";
        private const string InfoValue = "INFO";
        private const string WarningValue = "WARNING";
        private const string ErrorValue = "ERROR";
        private const string FatalValue = "FATAL";

        /// <summary> DEBUG. </summary>
        public static DnsServiceLogLevel Debug { get; } = new DnsServiceLogLevel(DebugValue);
        /// <summary> INFO. </summary>
        public static DnsServiceLogLevel Info { get; } = new DnsServiceLogLevel(InfoValue);
        /// <summary> WARNING. </summary>
        public static DnsServiceLogLevel Warning { get; } = new DnsServiceLogLevel(WarningValue);
        /// <summary> ERROR. </summary>
        public static DnsServiceLogLevel Error { get; } = new DnsServiceLogLevel(ErrorValue);
        /// <summary> FATAL. </summary>
        public static DnsServiceLogLevel Fatal { get; } = new DnsServiceLogLevel(FatalValue);
        /// <summary> Determines if two <see cref="DnsServiceLogLevel"/> values are the same. </summary>
        public static bool operator ==(DnsServiceLogLevel left, DnsServiceLogLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DnsServiceLogLevel"/> values are not the same. </summary>
        public static bool operator !=(DnsServiceLogLevel left, DnsServiceLogLevel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DnsServiceLogLevel"/>. </summary>
        public static implicit operator DnsServiceLogLevel(string value) => new DnsServiceLogLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DnsServiceLogLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DnsServiceLogLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
