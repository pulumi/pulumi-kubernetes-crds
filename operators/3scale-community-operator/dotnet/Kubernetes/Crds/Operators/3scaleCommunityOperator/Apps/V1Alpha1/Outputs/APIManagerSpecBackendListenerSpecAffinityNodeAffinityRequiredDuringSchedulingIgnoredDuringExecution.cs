// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1
{

    [OutputType]
    public sealed class APIManagerSpecBackendListenerSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
    {
        /// <summary>
        /// Required. A list of node selector terms. The terms are ORed.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecBackendListenerSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms;

        [OutputConstructor]
        private APIManagerSpecBackendListenerSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution(ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecBackendListenerSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> nodeSelectorTerms)
        {
            NodeSelectorTerms = nodeSelectorTerms;
        }
    }
}
