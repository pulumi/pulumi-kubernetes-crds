// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1
{

    [OutputType]
    public sealed class KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector LabelSelector;
        public readonly ImmutableArray<string> Namespaces;
        public readonly string TopologyKey;

        [OutputConstructor]
        private KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm(
            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaExporterTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector labelSelector,

            ImmutableArray<string> namespaces,

            string topologyKey)
        {
            LabelSelector = labelSelector;
            Namespaces = namespaces;
            TopologyKey = topologyKey;
        }
    }
}