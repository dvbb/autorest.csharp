// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using System.Globalization;

namespace _Type.Property.Optionality.Models
{
    /// <summary> The FloatLiteralProperty_property. </summary>
    public readonly partial struct FloatLiteralPropertyProperty : IEquatable<FloatLiteralPropertyProperty>
    {
        private readonly float _value;

        /// <summary> Initializes a new instance of <see cref="FloatLiteralPropertyProperty"/>. </summary>
        public FloatLiteralPropertyProperty(float value)
        {
            _value = value;
        }

        private const float _12Value = 1.2F;

        /// <summary> 1.2. </summary>
        public static FloatLiteralPropertyProperty _12 { get; } = new FloatLiteralPropertyProperty(_12Value);

        internal float ToSerialSingle() => _value;

        /// <summary> Determines if two <see cref="FloatLiteralPropertyProperty"/> values are the same. </summary>
        public static bool operator ==(FloatLiteralPropertyProperty left, FloatLiteralPropertyProperty right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FloatLiteralPropertyProperty"/> values are not the same. </summary>
        public static bool operator !=(FloatLiteralPropertyProperty left, FloatLiteralPropertyProperty right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FloatLiteralPropertyProperty"/>. </summary>
        public static implicit operator FloatLiteralPropertyProperty(float value) => new FloatLiteralPropertyProperty(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FloatLiteralPropertyProperty other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FloatLiteralPropertyProperty other) => Equals(_value, other._value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value.GetHashCode();
        /// <inheritdoc />
        public override string ToString() => _value.ToString(CultureInfo.InvariantCulture);
    }
}
