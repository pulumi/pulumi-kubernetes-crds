// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1
{

    public class KafkaConnectS2ISpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionArgs : Pulumi.ResourceArgs
    {
        [Input("podAffinityTerm")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaConnectS2ISpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermArgs>? PodAffinityTerm { get; set; }

        [Input("weight")]
        public Input<int>? Weight { get; set; }

        public KafkaConnectS2ISpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionArgs()
        {
        }
    }
}
