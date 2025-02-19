// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace FlattenedParameters.Models
{
    /// <summary> The PathsPv53C7OperationnotnullPatchRequestbodyContentApplicationJsonSchema. </summary>
    internal partial class PathsPv53C7OperationnotnullPatchRequestbodyContentApplicationJsonSchema
    {
        /// <summary> Initializes a new instance of <see cref="PathsPv53C7OperationnotnullPatchRequestbodyContentApplicationJsonSchema"/>. </summary>
        public PathsPv53C7OperationnotnullPatchRequestbodyContentApplicationJsonSchema()
        {
            Items = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="PathsPv53C7OperationnotnullPatchRequestbodyContentApplicationJsonSchema"/>. </summary>
        /// <param name="items"></param>
        internal PathsPv53C7OperationnotnullPatchRequestbodyContentApplicationJsonSchema(IList<string> items)
        {
            Items = items;
        }

        /// <summary> Gets the items. </summary>
        public IList<string> Items { get; }
    }
}
