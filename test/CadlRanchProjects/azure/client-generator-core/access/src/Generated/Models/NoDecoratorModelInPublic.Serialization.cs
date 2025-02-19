// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace _Specs_.Azure.ClientGenerator.Core.Access.Models
{
    public partial class NoDecoratorModelInPublic
    {
        internal static NoDecoratorModelInPublic DeserializeNoDecoratorModelInPublic(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new NoDecoratorModelInPublic(name);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static NoDecoratorModelInPublic FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeNoDecoratorModelInPublic(document.RootElement);
        }
    }
}
