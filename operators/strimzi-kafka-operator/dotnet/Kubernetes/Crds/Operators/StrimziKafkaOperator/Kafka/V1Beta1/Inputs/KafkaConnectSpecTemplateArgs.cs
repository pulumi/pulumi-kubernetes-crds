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
    /// Template for Kafka Connect and Kafka Connect S2I resources. The template allows users to specify how the `Deployment`, `Pods` and `Service` are generated.
    /// </summary>
    public class KafkaConnectSpecTemplateArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Template for Kafka Connect API `Service`.
        /// </summary>
        [Input("apiService")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaConnectSpecTemplateApiServiceArgs>? ApiService { get; set; }

        /// <summary>
        /// Template for the Kafka Connect container.
        /// </summary>
        [Input("connectContainer")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaConnectSpecTemplateConnectContainerArgs>? ConnectContainer { get; set; }

        /// <summary>
        /// Template for Kafka Connect `Deployment`.
        /// </summary>
        [Input("deployment")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaConnectSpecTemplateDeploymentArgs>? Deployment { get; set; }

        /// <summary>
        /// Template for Kafka Connect `Pods`.
        /// </summary>
        [Input("pod")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaConnectSpecTemplatePodArgs>? Pod { get; set; }

        /// <summary>
        /// Template for Kafka Connect `PodDisruptionBudget`.
        /// </summary>
        [Input("podDisruptionBudget")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaConnectSpecTemplatePodDisruptionBudgetArgs>? PodDisruptionBudget { get; set; }

        public KafkaConnectSpecTemplateArgs()
        {
        }
    }
}
