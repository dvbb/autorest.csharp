// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ModelWithConverterUsage.Models
{
    /// <summary> The product documentation. </summary>
    public partial class Product
    {
        /// <summary> Initializes a new instance of <see cref="Product"/>. </summary>
        public Product()
        {
        }

        /// <summary> Initializes a new instance of <see cref="Product"/>. </summary>
        /// <param name="constProperty"> Constant string. </param>
        internal Product(string constProperty)
        {
            ConstProperty = constProperty;
        }

        /// <summary> Constant string. </summary>
        public string ConstProperty { get; set; }
    }
}
