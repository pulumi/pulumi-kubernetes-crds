// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1
{

    public class KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorArgs : Pulumi.ResourceArgs
    {
        [Input("matchExpressions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressionsArgs>? _matchExpressions;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressionsArgs> MatchExpressions
        {
            get => _matchExpressions ?? (_matchExpressions = new InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressionsArgs>());
            set => _matchExpressions = value;
        }

        [Input("matchLabels")]
        private InputMap<object>? _matchLabels;
        public InputMap<object> MatchLabels
        {
            get => _matchLabels ?? (_matchLabels = new InputMap<object>());
            set => _matchLabels = value;
        }

        public KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorArgs()
        {
        }
    }
}
