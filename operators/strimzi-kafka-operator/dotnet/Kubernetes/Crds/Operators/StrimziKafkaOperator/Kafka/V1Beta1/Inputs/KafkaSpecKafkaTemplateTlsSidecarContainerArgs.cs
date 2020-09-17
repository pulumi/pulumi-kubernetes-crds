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
    /// Template for the Kafka broker TLS sidecar container.
    /// </summary>
    public class KafkaSpecKafkaTemplateTlsSidecarContainerArgs : Pulumi.ResourceArgs
    {
        [Input("env")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaTemplateTlsSidecarContainerEnvArgs>? _env;

        /// <summary>
        /// Environment variables which should be applied to the container.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaTemplateTlsSidecarContainerEnvArgs> Env
        {
            get => _env ?? (_env = new InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaTemplateTlsSidecarContainerEnvArgs>());
            set => _env = value;
        }

        /// <summary>
        /// Security context for the container.
        /// </summary>
        [Input("securityContext")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaTemplateTlsSidecarContainerSecurityContextArgs>? SecurityContext { get; set; }

        public KafkaSpecKafkaTemplateTlsSidecarContainerArgs()
        {
        }
    }
}