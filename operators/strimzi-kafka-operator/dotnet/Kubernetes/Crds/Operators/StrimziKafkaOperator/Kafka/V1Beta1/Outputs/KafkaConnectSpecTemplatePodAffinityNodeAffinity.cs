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
    public sealed class KafkaConnectSpecTemplatePodAffinityNodeAffinity
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution> PreferredDuringSchedulingIgnoredDuringExecution;
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution RequiredDuringSchedulingIgnoredDuringExecution;

        [OutputConstructor]
        private KafkaConnectSpecTemplatePodAffinityNodeAffinity(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution> preferredDuringSchedulingIgnoredDuringExecution,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution requiredDuringSchedulingIgnoredDuringExecution)
        {
            PreferredDuringSchedulingIgnoredDuringExecution = preferredDuringSchedulingIgnoredDuringExecution;
            RequiredDuringSchedulingIgnoredDuringExecution = requiredDuringSchedulingIgnoredDuringExecution;
        }
    }
}