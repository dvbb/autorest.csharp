// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Pagination.Models
{
    /// <summary> The DimensionValueListItem. </summary>
    public partial class DimensionValueListItem
    {
        /// <summary> Initializes a new instance of <see cref="DimensionValueListItem"/>. </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DimensionValueListItem(IEnumerable<string> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DimensionValueListItem"/>. </summary>
        /// <param name="value"></param>
        internal DimensionValueListItem(IReadOnlyList<string> value)
        {
            Value = value;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<string> Value { get; }
    }
}
