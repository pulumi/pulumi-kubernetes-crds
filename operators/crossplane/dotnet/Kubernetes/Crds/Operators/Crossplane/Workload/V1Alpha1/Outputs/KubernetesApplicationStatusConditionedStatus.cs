// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Workload.V1Alpha1
{

    [OutputType]
    public sealed class KubernetesApplicationStatusConditionedStatus
    {
        /// <summary>
        /// Conditions of the resource.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Workload.V1Alpha1.KubernetesApplicationStatusConditionedStatusConditions> Conditions;

        [OutputConstructor]
        private KubernetesApplicationStatusConditionedStatus(ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Workload.V1Alpha1.KubernetesApplicationStatusConditionedStatusConditions> conditions)
        {
            Conditions = conditions;
        }
    }
}