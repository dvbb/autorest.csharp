// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace MgmtAcronymMapping.Models
{
    /// <summary>
    /// The Virtual Machine Scale Set List Skus operation response.
    /// Serialized Name: VirtualMachineScaleSetListSkusResult
    /// </summary>
    internal partial class VirtualMachineScaleSetListSkusResult
    {
        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetListSkusResult"/>. </summary>
        /// <param name="value">
        /// The list of skus available for the virtual machine scale set.
        /// Serialized Name: VirtualMachineScaleSetListSkusResult.value
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal VirtualMachineScaleSetListSkusResult(IEnumerable<VirtualMachineScaleSetSku> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetListSkusResult"/>. </summary>
        /// <param name="value">
        /// The list of skus available for the virtual machine scale set.
        /// Serialized Name: VirtualMachineScaleSetListSkusResult.value
        /// </param>
        /// <param name="nextLink">
        /// The uri to fetch the next page of Virtual Machine Scale Set Skus. Call ListNext() with this to fetch the next page of VMSS Skus.
        /// Serialized Name: VirtualMachineScaleSetListSkusResult.nextLink
        /// </param>
        internal VirtualMachineScaleSetListSkusResult(IReadOnlyList<VirtualMachineScaleSetSku> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// The list of skus available for the virtual machine scale set.
        /// Serialized Name: VirtualMachineScaleSetListSkusResult.value
        /// </summary>
        public IReadOnlyList<VirtualMachineScaleSetSku> Value { get; }
        /// <summary>
        /// The uri to fetch the next page of Virtual Machine Scale Set Skus. Call ListNext() with this to fetch the next page of VMSS Skus.
        /// Serialized Name: VirtualMachineScaleSetListSkusResult.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
