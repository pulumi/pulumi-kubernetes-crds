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
    /// Template to specify how Cruise Control resources, `Deployments` and `Pods`, are generated.
    /// </summary>
    public class KafkaSpecCruiseControlTemplateArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Template for Cruise Control API `Service`.
        /// </summary>
        [Input("apiService")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplateApiServiceArgs>? ApiService { get; set; }

        /// <summary>
        /// Template for the Cruise Control container.
        /// </summary>
        [Input("cruiseControlContainer")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplateCruiseControlContainerArgs>? CruiseControlContainer { get; set; }

        /// <summary>
        /// Template for Cruise Control `Deployment`.
        /// </summary>
        [Input("deployment")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplateDeploymentArgs>? Deployment { get; set; }

        /// <summary>
        /// Template for Cruise Control `Pods`.
        /// </summary>
        [Input("pod")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplatePodArgs>? Pod { get; set; }

        /// <summary>
        /// Template for Cruise Control `PodDisruptionBudget`.
        /// </summary>
        [Input("podDisruptionBudget")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplatePodDisruptionBudgetArgs>? PodDisruptionBudget { get; set; }

        /// <summary>
        /// Template for the Cruise Control TLS sidecar container.
        /// </summary>
        [Input("tlsSidecarContainer")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplateTlsSidecarContainerArgs>? TlsSidecarContainer { get; set; }

        public KafkaSpecCruiseControlTemplateArgs()
        {
        }
    }
}