// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of server extended auditing settings. </summary>
    public partial class ExtendedServerBlobAuditingPolicyListResult
    {
        /// <summary> Initializes a new instance of ExtendedServerBlobAuditingPolicyListResult. </summary>
        internal ExtendedServerBlobAuditingPolicyListResult()
        {
            Value = new ChangeTrackingList<ExtendedServerBlobAuditingPolicy>();
        }

        /// <summary> Initializes a new instance of ExtendedServerBlobAuditingPolicyListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal ExtendedServerBlobAuditingPolicyListResult(IReadOnlyList<ExtendedServerBlobAuditingPolicy> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ExtendedServerBlobAuditingPolicy> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
