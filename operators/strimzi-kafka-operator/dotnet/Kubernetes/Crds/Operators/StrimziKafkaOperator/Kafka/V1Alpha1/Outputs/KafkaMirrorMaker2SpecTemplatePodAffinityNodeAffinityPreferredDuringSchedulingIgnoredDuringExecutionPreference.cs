// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1
{

    [OutputType]
    public sealed class KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions> MatchExpressions;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields> MatchFields;

        [OutputConstructor]
        private KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions> matchExpressions,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields> matchFields)
        {
            MatchExpressions = matchExpressions;
            MatchFields = matchFields;
        }
    }
}