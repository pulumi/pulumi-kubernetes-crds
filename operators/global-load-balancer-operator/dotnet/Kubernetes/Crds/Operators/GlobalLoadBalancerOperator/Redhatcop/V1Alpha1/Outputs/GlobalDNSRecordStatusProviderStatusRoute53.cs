// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1
{

    [OutputType]
    public sealed class GlobalDNSRecordStatusProviderStatusRoute53
    {
        /// <summary>
        /// HealthCheckID represents the route53 healthcheck created for this record
        /// </summary>
        public readonly ImmutableDictionary<string, string> HealthCheckID;
        /// <summary>
        /// PolicyID represents the route53 routing policy created for this record
        /// </summary>
        public readonly string PolicyID;
        /// <summary>
        /// PolicyInstanceID represents the ID of the DNSRecord
        /// </summary>
        public readonly string PolicyInstanceID;

        [OutputConstructor]
        private GlobalDNSRecordStatusProviderStatusRoute53(
            ImmutableDictionary<string, string> healthCheckID,

            string policyID,

            string policyInstanceID)
        {
            HealthCheckID = healthCheckID;
            PolicyID = policyID;
            PolicyInstanceID = policyInstanceID;
        }
    }
}