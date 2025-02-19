// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace body_complex.Models
{
    /// <summary> The ByteWrapper. </summary>
    public partial class ByteWrapper
    {
        /// <summary> Initializes a new instance of <see cref="ByteWrapper"/>. </summary>
        public ByteWrapper()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ByteWrapper"/>. </summary>
        /// <param name="field"></param>
        internal ByteWrapper(byte[] field)
        {
            Field = field;
        }

        /// <summary> Gets or sets the field. </summary>
        public byte[] Field { get; set; }
    }
}
