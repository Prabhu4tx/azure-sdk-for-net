// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ElasticPoolEditionCapability
    {
        internal static ElasticPoolEditionCapability DeserializeElasticPoolEditionCapability(JsonElement element)
        {
            Optional<string> name = default;
            Optional<IReadOnlyList<ElasticPoolPerformanceLevelCapability>> supportedElasticPoolPerformanceLevels = default;
            Optional<bool> zoneRedundant = default;
            Optional<CapabilityStatus> status = default;
            Optional<string> reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedElasticPoolPerformanceLevels"))
                {
                    List<ElasticPoolPerformanceLevelCapability> array = new List<ElasticPoolPerformanceLevelCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ElasticPoolPerformanceLevelCapability.DeserializeElasticPoolPerformanceLevelCapability(item));
                    }
                    supportedElasticPoolPerformanceLevels = array;
                    continue;
                }
                if (property.NameEquals("zoneRedundant"))
                {
                    zoneRedundant = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString().ToCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"))
                {
                    reason = property.Value.GetString();
                    continue;
                }
            }
            return new ElasticPoolEditionCapability(name.Value, Optional.ToList(supportedElasticPoolPerformanceLevels), Optional.ToNullable(zoneRedundant), Optional.ToNullable(status), reason.Value);
        }
    }
}
