// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayAvailableWafRuleSetsResult
    {
        internal static ApplicationGatewayAvailableWafRuleSetsResult DeserializeApplicationGatewayAvailableWafRuleSetsResult(JsonElement element)
        {
            Optional<IReadOnlyList<ApplicationGatewayFirewallRuleSet>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<ApplicationGatewayFirewallRuleSet> array = new List<ApplicationGatewayFirewallRuleSet>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationGatewayFirewallRuleSet.DeserializeApplicationGatewayFirewallRuleSet(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ApplicationGatewayAvailableWafRuleSetsResult(Optional.ToList(value));
        }
    }
}
