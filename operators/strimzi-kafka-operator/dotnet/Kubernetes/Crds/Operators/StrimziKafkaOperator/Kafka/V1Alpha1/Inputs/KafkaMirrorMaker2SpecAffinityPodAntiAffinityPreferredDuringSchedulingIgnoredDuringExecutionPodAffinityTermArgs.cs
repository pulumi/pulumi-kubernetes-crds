// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1
{

    public class KafkaMirrorMaker2SpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermArgs : Pulumi.ResourceArgs
    {
        [Input("labelSelector")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorArgs>? LabelSelector { get; set; }

        [Input("namespaces")]
        private InputList<string>? _namespaces;
        public InputList<string> Namespaces
        {
            get => _namespaces ?? (_namespaces = new InputList<string>());
            set => _namespaces = value;
        }

        [Input("topologyKey")]
        public Input<string>? TopologyKey { get; set; }

        public KafkaMirrorMaker2SpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermArgs()
        {
        }
    }
}
