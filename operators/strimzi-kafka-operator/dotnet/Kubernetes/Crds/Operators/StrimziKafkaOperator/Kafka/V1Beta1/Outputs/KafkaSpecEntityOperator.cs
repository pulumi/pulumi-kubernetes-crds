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
    public sealed class KafkaSpecEntityOperator
    {
        /// <summary>
        /// The pod's affinity rules.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecEntityOperatorAffinity Affinity;
        /// <summary>
        /// Template for Entity Operator resources. The template allows users to specify how is the `Deployment` and `Pods` generated.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecEntityOperatorTemplate Template;
        /// <summary>
        /// TLS sidecar configuration.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecEntityOperatorTlsSidecar TlsSidecar;
        /// <summary>
        /// The pod's tolerations.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecEntityOperatorTolerations> Tolerations;
        /// <summary>
        /// Configuration of the Topic Operator.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecEntityOperatorTopicOperator TopicOperator;
        /// <summary>
        /// Configuration of the User Operator.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecEntityOperatorUserOperator UserOperator;

        [OutputConstructor]
        private KafkaSpecEntityOperator(
            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecEntityOperatorAffinity affinity,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecEntityOperatorTemplate template,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecEntityOperatorTlsSidecar tlsSidecar,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecEntityOperatorTolerations> tolerations,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecEntityOperatorTopicOperator topicOperator,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecEntityOperatorUserOperator userOperator)
        {
            Affinity = affinity;
            Template = template;
            TlsSidecar = tlsSidecar;
            Tolerations = tolerations;
            TopicOperator = topicOperator;
            UserOperator = userOperator;
        }
    }
}
