// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace ModelsTypeSpec.Models
{
    /// <summary> The NumericValuesFacetint32. </summary>
    public partial class NumericValuesFacetint32 : Facet
    {
        /// <summary> Initializes a new instance of <see cref="NumericValuesFacetint32"/>. </summary>
        /// <param name="field"> A field to facet by, where the field is attributed as 'facetable'. </param>
        /// <param name="values"> The facet ranges to produce. The values must be listed in ascending order to get the expected results. For example, values=10,20 produces three buckets: one for base rate 0 up to but not including 10, one for 10 up to but not including 20, and one for 20 and higher. </param>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="field"/> or <paramref name="values"/> is null. </exception>
        internal NumericValuesFacetint32(string field, IEnumerable<int> values, int value) : base(field)
        {
            Argument.AssertNotNull(field, nameof(field));
            Argument.AssertNotNull(values, nameof(values));

            Values = values.ToList();
            Value = value;
        }

        /// <summary> Initializes a new instance of <see cref="NumericValuesFacetint32"/>. </summary>
        /// <param name="field"> A field to facet by, where the field is attributed as 'facetable'. </param>
        /// <param name="values"> The facet ranges to produce. The values must be listed in ascending order to get the expected results. For example, values=10,20 produces three buckets: one for base rate 0 up to but not including 10, one for 10 up to but not including 20, and one for 20 and higher. </param>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="field"/> is null. </exception>
        internal NumericValuesFacetint32(string field, IReadOnlyList<int> values, int value) : base(field)
        {
            Argument.AssertNotNull(field, nameof(field));

            Values = values;
            Value = value;
        }

        /// <summary> The facet ranges to produce. The values must be listed in ascending order to get the expected results. For example, values=10,20 produces three buckets: one for base rate 0 up to but not including 10, one for 10 up to but not including 20, and one for 20 and higher. </summary>
        public IReadOnlyList<int> Values { get; }
        /// <summary> Gets the value. </summary>
        public int Value { get; }
    }
}
