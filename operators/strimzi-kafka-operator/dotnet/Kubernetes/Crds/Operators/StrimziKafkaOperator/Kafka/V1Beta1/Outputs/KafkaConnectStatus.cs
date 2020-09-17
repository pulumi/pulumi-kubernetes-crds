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
    public sealed class KafkaConnectStatus
    {
        /// <summary>
        /// List of status conditions.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectStatusConditions> Conditions;
        /// <summary>
        /// The list of connector plugins available in this Kafka Connect deployment.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectStatusConnectorPlugins> ConnectorPlugins;
        /// <summary>
        /// The generation of the CRD that was last reconciled by the operator.
        /// </summary>
        public readonly int ObservedGeneration;
        /// <summary>
        /// Label selector for pods providing this resource.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectStatusPodSelector PodSelector;
        /// <summary>
        /// The current number of pods being used to provide this resource.
        /// </summary>
        public readonly int Replicas;
        /// <summary>
        /// The URL of the REST API endpoint for managing and monitoring Kafka Connect connectors.
        /// </summary>
        public readonly string Url;

        [OutputConstructor]
        private KafkaConnectStatus(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectStatusConditions> conditions,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectStatusConnectorPlugins> connectorPlugins,

            int observedGeneration,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectStatusPodSelector podSelector,

            int replicas,

            string url)
        {
            Conditions = conditions;
            ConnectorPlugins = connectorPlugins;
            ObservedGeneration = observedGeneration;
            PodSelector = podSelector;
            Replicas = replicas;
            Url = url;
        }
    }
}