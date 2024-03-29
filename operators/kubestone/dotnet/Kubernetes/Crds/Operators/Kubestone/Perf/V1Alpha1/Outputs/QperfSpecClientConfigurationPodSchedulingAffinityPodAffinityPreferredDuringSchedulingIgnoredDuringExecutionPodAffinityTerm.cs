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
    public sealed class QperfSpecClientConfigurationPodSchedulingAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
    {
        /// <summary>
        /// A label query over a set of resources, in this case pods.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.QperfSpecClientConfigurationPodSchedulingAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector LabelSelector;
        /// <summary>
        /// namespaces specifies which namespaces the labelSelector applies to (matches against); null or empty list means "this pod's namespace"
        /// </summary>
        public readonly ImmutableArray<string> Namespaces;
        /// <summary>
        /// This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.
        /// </summary>
        public readonly string TopologyKey;

        [OutputConstructor]
        private QperfSpecClientConfigurationPodSchedulingAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm(
            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.QperfSpecClientConfigurationPodSchedulingAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector labelSelector,

            ImmutableArray<string> namespaces,

            string topologyKey)
        {
            LabelSelector = labelSelector;
            Namespaces = namespaces;
            TopologyKey = topologyKey;
        }
    }
}
