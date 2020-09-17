// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1
{

    [OutputType]
    public sealed class FioSpecPodConfigPodSchedulingAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
    {
        /// <summary>
        /// Required. A list of node selector terms. The terms are ORed.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecPodConfigPodSchedulingAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms;

        [OutputConstructor]
        private FioSpecPodConfigPodSchedulingAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution(ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecPodConfigPodSchedulingAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> nodeSelectorTerms)
        {
            NodeSelectorTerms = nodeSelectorTerms;
        }
    }
}