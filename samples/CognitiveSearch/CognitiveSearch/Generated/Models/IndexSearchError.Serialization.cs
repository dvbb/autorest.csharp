// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class IndexSearchError
    {
        internal static IndexSearchError DeserializeIndexSearchError(JsonElement element)
        {
            string code = default;
            string message = default;
            IReadOnlyList<IndexSearchError> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IndexSearchError> array = new List<IndexSearchError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeIndexSearchError(item));
                    }
                    details = array;
                    continue;
                }
            }
            return new IndexSearchError(code, message, details);
        }
    }
}
