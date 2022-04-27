// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The ProviderOSTypeSelected. </summary>
    public readonly partial struct ProviderOSTypeSelected : IEquatable<ProviderOSTypeSelected>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ProviderOSTypeSelected"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProviderOSTypeSelected(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WindowsValue = "Windows";
        private const string LinuxValue = "Linux";
        private const string WindowsFunctionsValue = "WindowsFunctions";
        private const string LinuxFunctionsValue = "LinuxFunctions";
        private const string AllValue = "All";

        /// <summary> Windows. </summary>
        public static ProviderOSTypeSelected Windows { get; } = new ProviderOSTypeSelected(WindowsValue);
        /// <summary> Linux. </summary>
        public static ProviderOSTypeSelected Linux { get; } = new ProviderOSTypeSelected(LinuxValue);
        /// <summary> WindowsFunctions. </summary>
        public static ProviderOSTypeSelected WindowsFunctions { get; } = new ProviderOSTypeSelected(WindowsFunctionsValue);
        /// <summary> LinuxFunctions. </summary>
        public static ProviderOSTypeSelected LinuxFunctions { get; } = new ProviderOSTypeSelected(LinuxFunctionsValue);
        /// <summary> All. </summary>
        public static ProviderOSTypeSelected All { get; } = new ProviderOSTypeSelected(AllValue);
        /// <summary> Determines if two <see cref="ProviderOSTypeSelected"/> values are the same. </summary>
        public static bool operator ==(ProviderOSTypeSelected left, ProviderOSTypeSelected right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProviderOSTypeSelected"/> values are not the same. </summary>
        public static bool operator !=(ProviderOSTypeSelected left, ProviderOSTypeSelected right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ProviderOSTypeSelected"/>. </summary>
        public static implicit operator ProviderOSTypeSelected(string value) => new ProviderOSTypeSelected(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProviderOSTypeSelected other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProviderOSTypeSelected other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
