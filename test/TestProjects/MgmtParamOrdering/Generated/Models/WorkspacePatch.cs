// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace MgmtParamOrdering.Models
{
    /// <summary> The parameters for updating a machine learning workspace. </summary>
    public partial class WorkspacePatch
    {
        /// <summary> Initializes a new instance of <see cref="WorkspacePatch"/>. </summary>
        public WorkspacePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="WorkspacePatch"/>. </summary>
        /// <param name="tags"> The resource tags for the machine learning workspace. </param>
        internal WorkspacePatch(IDictionary<string, string> tags)
        {
            Tags = tags;
        }

        /// <summary> The resource tags for the machine learning workspace. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
