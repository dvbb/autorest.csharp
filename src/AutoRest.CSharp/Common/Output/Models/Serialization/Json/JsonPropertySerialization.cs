﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using AutoRest.CSharp.Common.Output.Expressions.ValueExpressions;
using AutoRest.CSharp.Generation.Types;

namespace AutoRest.CSharp.Output.Models.Serialization.Json
{
    internal class JsonPropertySerialization : PropertySerialization
    {
        public JsonPropertySerialization(
            string parameterName,
            TypedValueExpression value,
            string serializedName,
            CSharpType? serializedType,
            JsonSerialization valueSerialization,
            bool isRequired,
            bool shouldSkipSerialization,
            bool shouldSkipDeserialization,
            string? customSerializationMethodName = null,
            string? customDeserializationMethodName = null,
            TypedValueExpression? enumerableExpression = null)
            : base(parameterName, value, serializedName, serializedType, isRequired, shouldSkipSerialization, shouldSkipDeserialization, enumerableExpression)
        {
            ValueSerialization = valueSerialization;
            CustomSerializationMethodName = customSerializationMethodName;
            CustomDeserializationMethodName = customDeserializationMethodName;
        }

        public JsonPropertySerialization(string serializedName, JsonPropertySerialization[] propertySerializations)
            : base(string.Empty, new TypedMemberExpression(null, serializedName, typeof(object)), serializedName, null, false, false)
        {
            PropertySerializations = propertySerializations;
        }

        public JsonSerialization? ValueSerialization { get; }
        /// <summary>
        /// This is not null when the property is flattened in generated client SDK `x-ms-client-flatten: true`
        /// </summary>
        public JsonPropertySerialization[]? PropertySerializations { get; }

        public string? CustomSerializationMethodName { get; }

        public string? CustomDeserializationMethodName { get; }
    }
}
