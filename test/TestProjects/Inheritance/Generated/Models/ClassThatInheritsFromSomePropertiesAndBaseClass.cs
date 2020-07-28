// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Inheritance.Models
{
    /// <summary> The ClassThatInheritsFromSomePropertiesAndBaseClass. </summary>
    public partial class ClassThatInheritsFromSomePropertiesAndBaseClass : SomeProperties
    {
        /// <summary> Initializes a new instance of ClassThatInheritsFromSomePropertiesAndBaseClass. </summary>
        public ClassThatInheritsFromSomePropertiesAndBaseClass()
        {
        }

        /// <summary> Initializes a new instance of ClassThatInheritsFromSomePropertiesAndBaseClass. </summary>
        /// <param name="someProperty"> . </param>
        /// <param name="someOtherProperty"> . </param>
        /// <param name="baseClassProperty"> . </param>
        internal ClassThatInheritsFromSomePropertiesAndBaseClass(string someProperty, string someOtherProperty, string baseClassProperty) : base(someProperty, someOtherProperty)
        {
            BaseClassProperty = baseClassProperty;
        }

        public string BaseClassProperty { get; set; }
    }
}
