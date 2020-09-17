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
    public sealed class GlobalDNSRecordSpec
    {
        /// <summary>
        /// Enpoints is the list of the cluster endpoitns that need to be considered for this dns record
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GlobalDNSRecordSpecEndpoints> Endpoints;
        /// <summary>
        /// GlobalZoneRef represents the global zone that will be used to host this record
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GlobalDNSRecordSpecGlobalZoneRef GlobalZoneRef;
        /// <summary>
        /// Probe is the health check used to probe the health of the applications and decide which IPs to return Only HttpAction is supported
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GlobalDNSRecordSpecHealthCheck HealthCheck;
        /// <summary>
        /// LoadBalancingPolicy describes the policy used to loadbalance the results of the DNS queries.
        /// </summary>
        public readonly string LoadBalancingPolicy;
        /// <summary>
        /// Name is the fqdn that will be used for this record.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// TTL is the TTL for this dns record kubebuilder:default:60
        /// </summary>
        public readonly int Ttl;

        [OutputConstructor]
        private GlobalDNSRecordSpec(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GlobalDNSRecordSpecEndpoints> endpoints,

            Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GlobalDNSRecordSpecGlobalZoneRef globalZoneRef,

            Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GlobalDNSRecordSpecHealthCheck healthCheck,

            string loadBalancingPolicy,

            string name,

            int ttl)
        {
            Endpoints = endpoints;
            GlobalZoneRef = globalZoneRef;
            HealthCheck = healthCheck;
            LoadBalancingPolicy = loadBalancingPolicy;
            Name = name;
            Ttl = ttl;
        }
    }
}
