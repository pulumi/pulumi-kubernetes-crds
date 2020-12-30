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
    public sealed class KafkaConnectS2ISpecTemplate
    {
        /// <summary>
        /// Template for Kafka Connect API `Service`.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectS2ISpecTemplateApiService ApiService;
        /// <summary>
        /// Template for the Kafka Connect container.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectS2ISpecTemplateConnectContainer ConnectContainer;
        /// <summary>
        /// Template for Kafka Connect `Deployment`.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectS2ISpecTemplateDeployment Deployment;
        /// <summary>
        /// Template for the Kafka init container.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectS2ISpecTemplateInitContainer InitContainer;
        /// <summary>
        /// Template for Kafka Connect `Pods`.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectS2ISpecTemplatePod Pod;
        /// <summary>
        /// Template for Kafka Connect `PodDisruptionBudget`.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectS2ISpecTemplatePodDisruptionBudget PodDisruptionBudget;

        [OutputConstructor]
        private KafkaConnectS2ISpecTemplate(
            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectS2ISpecTemplateApiService apiService,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectS2ISpecTemplateConnectContainer connectContainer,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectS2ISpecTemplateDeployment deployment,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectS2ISpecTemplateInitContainer initContainer,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectS2ISpecTemplatePod pod,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectS2ISpecTemplatePodDisruptionBudget podDisruptionBudget)
        {
            ApiService = apiService;
            ConnectContainer = connectContainer;
            Deployment = deployment;
            InitContainer = initContainer;
            Pod = pod;
            PodDisruptionBudget = podDisruptionBudget;
        }
    }
}
