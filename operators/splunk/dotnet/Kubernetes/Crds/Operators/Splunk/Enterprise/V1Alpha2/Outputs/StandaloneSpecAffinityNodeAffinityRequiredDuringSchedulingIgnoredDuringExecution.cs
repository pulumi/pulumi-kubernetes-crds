// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2
{

    [OutputType]
    public sealed class StandaloneSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
    {
        /// <summary>
        /// Required. A list of node selector terms. The terms are ORed.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.StandaloneSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms;

        [OutputConstructor]
        private StandaloneSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution(ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.StandaloneSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> nodeSelectorTerms)
        {
            NodeSelectorTerms = nodeSelectorTerms;
        }
    }
}