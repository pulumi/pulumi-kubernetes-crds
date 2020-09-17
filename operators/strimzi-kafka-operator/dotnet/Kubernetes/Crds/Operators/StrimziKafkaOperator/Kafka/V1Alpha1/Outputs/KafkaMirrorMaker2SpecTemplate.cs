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
    public sealed class KafkaMirrorMaker2SpecTemplate
    {
        /// <summary>
        /// Template for Kafka Connect API `Service`.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplateApiService ApiService;
        /// <summary>
        /// Template for the Kafka Connect container.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplateConnectContainer ConnectContainer;
        /// <summary>
        /// Template for Kafka Connect `Deployment`.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplateDeployment Deployment;
        /// <summary>
        /// Template for Kafka Connect `Pods`.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplatePod Pod;
        /// <summary>
        /// Template for Kafka Connect `PodDisruptionBudget`.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplatePodDisruptionBudget PodDisruptionBudget;

        [OutputConstructor]
        private KafkaMirrorMaker2SpecTemplate(
            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplateApiService apiService,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplateConnectContainer connectContainer,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplateDeployment deployment,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplatePod pod,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplatePodDisruptionBudget podDisruptionBudget)
        {
            ApiService = apiService;
            ConnectContainer = connectContainer;
            Deployment = deployment;
            Pod = pod;
            PodDisruptionBudget = podDisruptionBudget;
        }
    }
}
