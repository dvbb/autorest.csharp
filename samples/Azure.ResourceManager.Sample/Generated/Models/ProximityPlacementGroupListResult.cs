// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Sample;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary>
    /// The List Proximity Placement Group operation response.
    /// Serialized Name: ProximityPlacementGroupListResult
    /// </summary>
    internal partial class ProximityPlacementGroupListResult
    {
        /// <summary> Initializes a new instance of <see cref="ProximityPlacementGroupListResult"/>. </summary>
        /// <param name="value">
        /// The list of proximity placement groups
        /// Serialized Name: ProximityPlacementGroupListResult.value
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ProximityPlacementGroupListResult(IEnumerable<ProximityPlacementGroupData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ProximityPlacementGroupListResult"/>. </summary>
        /// <param name="value">
        /// The list of proximity placement groups
        /// Serialized Name: ProximityPlacementGroupListResult.value
        /// </param>
        /// <param name="nextLink">
        /// The URI to fetch the next page of proximity placement groups.
        /// Serialized Name: ProximityPlacementGroupListResult.nextLink
        /// </param>
        internal ProximityPlacementGroupListResult(IReadOnlyList<ProximityPlacementGroupData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// The list of proximity placement groups
        /// Serialized Name: ProximityPlacementGroupListResult.value
        /// </summary>
        public IReadOnlyList<ProximityPlacementGroupData> Value { get; }
        /// <summary>
        /// The URI to fetch the next page of proximity placement groups.
        /// Serialized Name: ProximityPlacementGroupListResult.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
