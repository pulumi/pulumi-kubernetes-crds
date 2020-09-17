// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2
{

    [OutputType]
    public sealed class ManualScalerTraitSpec
    {
        /// <summary>
        /// ReplicaCount of the workload this trait applies to.
        /// </summary>
        public readonly int ReplicaCount;
        /// <summary>
        /// WorkloadReference to the workload this trait applies to.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ManualScalerTraitSpecWorkloadRef WorkloadRef;

        [OutputConstructor]
        private ManualScalerTraitSpec(
            int replicaCount,

            Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ManualScalerTraitSpecWorkloadRef workloadRef)
        {
            ReplicaCount = replicaCount;
            WorkloadRef = workloadRef;
        }
    }
}