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
    public sealed class KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions> MatchExpressions;
        public readonly ImmutableDictionary<string, object> MatchLabels;

        [OutputConstructor]
        private KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaExporterTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions> matchExpressions,

            ImmutableDictionary<string, object> matchLabels)
        {
            MatchExpressions = matchExpressions;
            MatchLabels = matchLabels;
        }
    }
}