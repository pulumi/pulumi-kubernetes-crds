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
    public sealed class MachinePoolSpecAutoscaling
    {
        /// <summary>
        /// MaxReplicas is the maximum number of replicas for the machine pool.
        /// </summary>
        public readonly int MaxReplicas;
        /// <summary>
        /// MinReplicas is the minimum number of replicas for the machine pool.
        /// </summary>
        public readonly int MinReplicas;

        [OutputConstructor]
        private MachinePoolSpecAutoscaling(
            int maxReplicas,

            int minReplicas)
        {
            MaxReplicas = maxReplicas;
            MinReplicas = minReplicas;
        }
    }
}