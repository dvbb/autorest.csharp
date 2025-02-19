// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The storage account blob inventory policy rules. </summary>
    public partial class BlobInventoryPolicySchema
    {
        /// <summary> Initializes a new instance of <see cref="BlobInventoryPolicySchema"/>. </summary>
        /// <param name="enabled"> Policy is enabled if set to true. </param>
        /// <param name="inventoryRuleType"> The valid value is Inventory. </param>
        /// <param name="rules"> The storage account blob inventory policy rules. The rule is applied when it is enabled. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="rules"/> is null. </exception>
        public BlobInventoryPolicySchema(bool enabled, InventoryRuleType inventoryRuleType, IEnumerable<BlobInventoryPolicyRule> rules)
        {
            Argument.AssertNotNull(rules, nameof(rules));

            Enabled = enabled;
            InventoryRuleType = inventoryRuleType;
            Rules = rules.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="BlobInventoryPolicySchema"/>. </summary>
        /// <param name="enabled"> Policy is enabled if set to true. </param>
        /// <param name="inventoryRuleType"> The valid value is Inventory. </param>
        /// <param name="rules"> The storage account blob inventory policy rules. The rule is applied when it is enabled. </param>
        internal BlobInventoryPolicySchema(bool enabled, InventoryRuleType inventoryRuleType, IList<BlobInventoryPolicyRule> rules)
        {
            Enabled = enabled;
            InventoryRuleType = inventoryRuleType;
            Rules = rules;
        }

        /// <summary> Policy is enabled if set to true. </summary>
        public bool Enabled { get; set; }
        /// <summary> The valid value is Inventory. </summary>
        public InventoryRuleType InventoryRuleType { get; set; }
        /// <summary> The storage account blob inventory policy rules. The rule is applied when it is enabled. </summary>
        public IList<BlobInventoryPolicyRule> Rules { get; }
    }
}
