// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtPropertyChooser.Models
{
    /// <summary> The type of identity used for the virtual machine. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the virtual machine. </summary>
    public enum ResourceIdentityType
    {
        /// <summary> None. </summary>
        None,
        /// <summary> SystemAssigned. </summary>
        SystemAssigned,
        /// <summary> UserAssigned. </summary>
        UserAssigned,
        /// <summary> SystemAssigned, UserAssigned. </summary>
        SystemAssignedUserAssigned
    }
}
