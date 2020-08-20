// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ServiceObjectiveCapability
    {
        internal static ServiceObjectiveCapability DeserializeServiceObjectiveCapability(JsonElement element)
        {
            Optional<Guid> id = default;
            Optional<string> name = default;
            Optional<IReadOnlyList<MaxSizeRangeCapability>> supportedMaxSizes = default;
            Optional<PerformanceLevelCapability> performanceLevel = default;
            Optional<Sku> sku = default;
            Optional<IReadOnlyList<LicenseTypeCapability>> supportedLicenseTypes = default;
            Optional<MaxSizeCapability> includedMaxSize = default;
            Optional<bool> zoneRedundant = default;
            Optional<AutoPauseDelayTimeRange> supportedAutoPauseDelay = default;
            Optional<IReadOnlyList<MinCapacityCapability>> supportedMinCapacities = default;
            Optional<string> computeModel = default;
            Optional<CapabilityStatus> status = default;
            Optional<string> reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedMaxSizes"))
                {
                    List<MaxSizeRangeCapability> array = new List<MaxSizeRangeCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MaxSizeRangeCapability.DeserializeMaxSizeRangeCapability(item));
                    }
                    supportedMaxSizes = array;
                    continue;
                }
                if (property.NameEquals("performanceLevel"))
                {
                    performanceLevel = PerformanceLevelCapability.DeserializePerformanceLevelCapability(property.Value);
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    sku = Sku.DeserializeSku(property.Value);
                    continue;
                }
                if (property.NameEquals("supportedLicenseTypes"))
                {
                    List<LicenseTypeCapability> array = new List<LicenseTypeCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LicenseTypeCapability.DeserializeLicenseTypeCapability(item));
                    }
                    supportedLicenseTypes = array;
                    continue;
                }
                if (property.NameEquals("includedMaxSize"))
                {
                    includedMaxSize = MaxSizeCapability.DeserializeMaxSizeCapability(property.Value);
                    continue;
                }
                if (property.NameEquals("zoneRedundant"))
                {
                    zoneRedundant = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("supportedAutoPauseDelay"))
                {
                    supportedAutoPauseDelay = AutoPauseDelayTimeRange.DeserializeAutoPauseDelayTimeRange(property.Value);
                    continue;
                }
                if (property.NameEquals("supportedMinCapacities"))
                {
                    List<MinCapacityCapability> array = new List<MinCapacityCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MinCapacityCapability.DeserializeMinCapacityCapability(item));
                    }
                    supportedMinCapacities = array;
                    continue;
                }
                if (property.NameEquals("computeModel"))
                {
                    computeModel = property.Value.GetString();
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
            return new ServiceObjectiveCapability(Optional.ToNullable(id), name.Value, Optional.ToList(supportedMaxSizes), performanceLevel.Value, sku.Value, Optional.ToList(supportedLicenseTypes), includedMaxSize.Value, Optional.ToNullable(zoneRedundant), supportedAutoPauseDelay.Value, Optional.ToList(supportedMinCapacities), computeModel.Value, Optional.ToNullable(status), reason.Value);
        }
    }
}
