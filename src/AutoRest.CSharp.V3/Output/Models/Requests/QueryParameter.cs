﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using AutoRest.CSharp.V3.Output.Models.Serialization;

namespace AutoRest.CSharp.V3.Output.Models.Requests
{
    internal class QueryParameter
    {
        public QueryParameter(string name, RequestParameter value, QuerySerializationStyle serializationStyle, bool escape, SerializationFormat serializationFormat)
        {
            Name = name;
            Value = value;
            SerializationStyle = serializationStyle;
            Escape = escape;
            SerializationFormat = serializationFormat;
        }

        public string Name { get; }
        public RequestParameter Value { get; }
        public QuerySerializationStyle SerializationStyle { get; }
        public SerializationFormat SerializationFormat { get; }
        public bool Escape { get; }
    }
}
