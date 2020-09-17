// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Hive.V1
{

    [OutputType]
    public sealed class ClusterProvisionSpecPodSpecHostAliases
    {
        /// <summary>
        /// Hostnames for the above IP address.
        /// </summary>
        public readonly ImmutableArray<string> Hostnames;
        /// <summary>
        /// IP address of the host file entry.
        /// </summary>
        public readonly string Ip;

        [OutputConstructor]
        private ClusterProvisionSpecPodSpecHostAliases(
            ImmutableArray<string> hostnames,

            string ip)
        {
            Hostnames = hostnames;
            Ip = ip;
        }
    }
}