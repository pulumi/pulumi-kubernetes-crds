// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1
{

    /// <summary>
    /// The pod's affinity rules.
    /// </summary>
    public class KafkaMirrorMaker2SpecTemplatePodAffinityArgs : Pulumi.ResourceArgs
    {
        [Input("nodeAffinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityArgs>? NodeAffinity { get; set; }

        [Input("podAffinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityArgs>? PodAffinity { get; set; }

        [Input("podAntiAffinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityArgs>? PodAntiAffinity { get; set; }

        public KafkaMirrorMaker2SpecTemplatePodAffinityArgs()
        {
        }
    }
}
