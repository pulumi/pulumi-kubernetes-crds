// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1
{

    /// <summary>
    /// The pod's affinity rules.
    /// </summary>
    public class KafkaSpecZookeeperAffinityArgs : Pulumi.ResourceArgs
    {
        [Input("nodeAffinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecZookeeperAffinityNodeAffinityArgs>? NodeAffinity { get; set; }

        [Input("podAffinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecZookeeperAffinityPodAffinityArgs>? PodAffinity { get; set; }

        [Input("podAntiAffinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecZookeeperAffinityPodAntiAffinityArgs>? PodAntiAffinity { get; set; }

        public KafkaSpecZookeeperAffinityArgs()
        {
        }
    }
}
