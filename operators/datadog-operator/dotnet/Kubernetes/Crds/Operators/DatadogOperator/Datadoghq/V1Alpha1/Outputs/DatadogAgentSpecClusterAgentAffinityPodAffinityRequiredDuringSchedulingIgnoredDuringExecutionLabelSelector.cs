// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1
{

    [OutputType]
    public sealed class DatadogAgentSpecClusterAgentAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
    {
        /// <summary>
        /// matchExpressions is a list of label selector requirements. The requirements are ANDed.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecClusterAgentAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions> MatchExpressions;
        /// <summary>
        /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.
        /// </summary>
        public readonly ImmutableDictionary<string, string> MatchLabels;

        [OutputConstructor]
        private DatadogAgentSpecClusterAgentAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecClusterAgentAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions> matchExpressions,

            ImmutableDictionary<string, string> matchLabels)
        {
            MatchExpressions = matchExpressions;
            MatchLabels = matchLabels;
        }
    }
}
