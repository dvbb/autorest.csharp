// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sample.Models
{
    internal static partial class ResourceIdentityTypeExtensions
    {
        public static string ToSerialString(this ResourceIdentityType value) => value switch
        {
            ResourceIdentityType.None => "None",
            ResourceIdentityType.SystemAssigned => "SystemAssigned",
            ResourceIdentityType.UserAssigned => "UserAssigned",
            ResourceIdentityType.SystemAssignedUserAssigned => "SystemAssigned, UserAssigned",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ResourceIdentityType value.")
        };

        public static ResourceIdentityType ToResourceIdentityType(this string value)
        {
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return ResourceIdentityType.None;
            if (string.Equals(value, "SystemAssigned", StringComparison.InvariantCultureIgnoreCase)) return ResourceIdentityType.SystemAssigned;
            if (string.Equals(value, "UserAssigned", StringComparison.InvariantCultureIgnoreCase)) return ResourceIdentityType.UserAssigned;
            if (string.Equals(value, "SystemAssigned, UserAssigned", StringComparison.InvariantCultureIgnoreCase)) return ResourceIdentityType.SystemAssignedUserAssigned;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ResourceIdentityType value.");
        }
    }
}
