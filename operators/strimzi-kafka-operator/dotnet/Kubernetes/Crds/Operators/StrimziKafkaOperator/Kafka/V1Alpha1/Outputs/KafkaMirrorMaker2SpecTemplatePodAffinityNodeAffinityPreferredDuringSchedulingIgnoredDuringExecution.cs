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
    public sealed class KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference;
        public readonly int Weight;

        [OutputConstructor]
        private KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution(
            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference preference,

            int weight)
        {
            Preference = preference;
            Weight = weight;
        }
    }
}