// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1
{

    public class KafkaSpecZookeeperTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceArgs : Pulumi.ResourceArgs
    {
        [Input("matchExpressions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecZookeeperTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressionsArgs>? _matchExpressions;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecZookeeperTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressionsArgs> MatchExpressions
        {
            get => _matchExpressions ?? (_matchExpressions = new InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecZookeeperTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressionsArgs>());
            set => _matchExpressions = value;
        }

        [Input("matchFields")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecZookeeperTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFieldsArgs>? _matchFields;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecZookeeperTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFieldsArgs> MatchFields
        {
            get => _matchFields ?? (_matchFields = new InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecZookeeperTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFieldsArgs>());
            set => _matchFields = value;
        }

        public KafkaSpecZookeeperTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceArgs()
        {
        }
    }
}
