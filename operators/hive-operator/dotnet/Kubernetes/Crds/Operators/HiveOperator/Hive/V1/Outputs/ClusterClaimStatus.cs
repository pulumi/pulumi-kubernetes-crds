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
    public sealed class ClusterClaimStatus
    {
        /// <summary>
        /// Conditions includes more detailed status for the cluster pool.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterClaimStatusConditions> Conditions;

        [OutputConstructor]
        private ClusterClaimStatus(ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterClaimStatusConditions> conditions)
        {
            Conditions = conditions;
        }
    }
}