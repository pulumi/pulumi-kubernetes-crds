// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Multiclusterdns.V1Alpha1
{

    [OutputType]
    public sealed class IngressDNSRecordStatusDns
    {
        /// <summary>
        /// Cluster name
        /// </summary>
        public readonly string Cluster;
        /// <summary>
        /// LoadBalancer for the corresponding ingress controller
        /// </summary>
        public readonly ImmutableDictionary<string, object> LoadBalancer;

        [OutputConstructor]
        private IngressDNSRecordStatusDns(
            string cluster,

            ImmutableDictionary<string, object> loadBalancer)
        {
            Cluster = cluster;
            LoadBalancer = loadBalancer;
        }
    }
}