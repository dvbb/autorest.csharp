// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace _Type.Property.ValueTypes.Models
{
    /// <summary> Model with collection string properties. </summary>
    public partial class CollectionsStringProperty
    {
        /// <summary> Initializes a new instance of <see cref="CollectionsStringProperty"/>. </summary>
        /// <param name="property"> Property. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="property"/> is null. </exception>
        public CollectionsStringProperty(IEnumerable<string> property)
        {
            Argument.AssertNotNull(property, nameof(property));

            Property = property.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="CollectionsStringProperty"/>. </summary>
        /// <param name="property"> Property. </param>
        internal CollectionsStringProperty(IList<string> property)
        {
            Property = property;
        }

        /// <summary> Property. </summary>
        public IList<string> Property { get; }
    }
}
