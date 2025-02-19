// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtNoTypeReplacement.Models
{
    internal partial class MiddleResourceModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Foo))
            {
                writer.WritePropertyName("foo"u8);
                writer.WriteObjectValue(Foo);
            }
            writer.WriteEndObject();
        }

        internal static MiddleResourceModel DeserializeMiddleResourceModel(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NoSubResourceModel2> foo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("foo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    foo = NoSubResourceModel2.DeserializeNoSubResourceModel2(property.Value);
                    continue;
                }
            }
            return new MiddleResourceModel(foo.Value);
        }
    }
}
