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
    public sealed class KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm;
        public readonly int Weight;

        [OutputConstructor]
        private KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution(
            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm podAffinityTerm,

            int weight)
        {
            PodAffinityTerm = podAffinityTerm;
            Weight = weight;
        }
    }
}
