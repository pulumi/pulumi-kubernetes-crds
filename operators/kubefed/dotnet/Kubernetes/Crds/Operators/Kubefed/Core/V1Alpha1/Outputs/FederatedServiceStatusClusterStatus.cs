// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1
{

    [OutputType]
    public sealed class FederatedServiceStatusClusterStatus
    {
        public readonly string ClusterName;
        public readonly ImmutableDictionary<string, object> Status;

        [OutputConstructor]
        private FederatedServiceStatusClusterStatus(
            string clusterName,

            ImmutableDictionary<string, object> status)
        {
            ClusterName = clusterName;
            Status = status;
        }
    }
}
