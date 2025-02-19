// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace _Type.Model.Inheritance.EnumDiscriminator.Models
{
    /// <summary>
    /// Test extensible enum type for discriminator
    /// Please note <see cref="Dog"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="Golden"/>.
    /// </summary>
    public abstract partial class Dog
    {
        /// <summary> Initializes a new instance of <see cref="Dog"/>. </summary>
        /// <param name="weight"> Weight of the dog. </param>
        protected Dog(int weight)
        {
            Weight = weight;
        }

        /// <summary> Initializes a new instance of <see cref="Dog"/>. </summary>
        /// <param name="kind"> discriminator property. </param>
        /// <param name="weight"> Weight of the dog. </param>
        internal Dog(DogKind kind, int weight)
        {
            Kind = kind;
            Weight = weight;
        }

        /// <summary> discriminator property. </summary>
        internal DogKind Kind { get; set; }
        /// <summary> Weight of the dog. </summary>
        public int Weight { get; set; }
    }
}
