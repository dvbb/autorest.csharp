// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace body_complex.Models
{
    /// <summary> The DictionaryWrapper. </summary>
    public partial class DictionaryWrapper
    {
        /// <summary> Initializes a new instance of <see cref="DictionaryWrapper"/>. </summary>
        public DictionaryWrapper()
        {
            DefaultProgram = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DictionaryWrapper"/>. </summary>
        /// <param name="defaultProgram"> Dictionary of &lt;string&gt;. </param>
        internal DictionaryWrapper(IDictionary<string, string> defaultProgram)
        {
            DefaultProgram = defaultProgram;
        }

        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> DefaultProgram { get; set; }
    }
}
