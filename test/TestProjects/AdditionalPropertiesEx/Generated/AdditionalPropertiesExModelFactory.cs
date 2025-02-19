// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace AdditionalPropertiesEx.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class AdditionalPropertiesExModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.OutputAdditionalPropertiesModel"/>. </summary>
        /// <param name="id"></param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <returns> A new <see cref="Models.OutputAdditionalPropertiesModel"/> instance for mocking. </returns>
        public static OutputAdditionalPropertiesModel OutputAdditionalPropertiesModel(int id = default, IReadOnlyDictionary<string, string> additionalProperties = null)
        {
            additionalProperties ??= new Dictionary<string, string>();

            return new OutputAdditionalPropertiesModel(id, additionalProperties);
        }

        /// <summary> Initializes a new instance of <see cref="Models.OutputAdditionalPropertiesModelStruct"/>. </summary>
        /// <param name="id"></param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="additionalProperties"/> is null. </exception>
        /// <returns> A new <see cref="Models.OutputAdditionalPropertiesModelStruct"/> instance for mocking. </returns>
        public static OutputAdditionalPropertiesModelStruct OutputAdditionalPropertiesModelStruct(int id = default, IReadOnlyDictionary<string, string> additionalProperties = null)
        {
            additionalProperties ??= new Dictionary<string, string>();

            return new OutputAdditionalPropertiesModelStruct(id, additionalProperties);
        }
    }
}
