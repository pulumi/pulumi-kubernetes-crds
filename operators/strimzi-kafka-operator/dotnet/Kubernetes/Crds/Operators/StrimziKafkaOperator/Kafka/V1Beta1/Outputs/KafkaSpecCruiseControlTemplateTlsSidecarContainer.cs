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
    public sealed class KafkaSpecCruiseControlTemplateTlsSidecarContainer
    {
        /// <summary>
        /// Environment variables which should be applied to the container.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplateTlsSidecarContainerEnv> Env;
        /// <summary>
        /// Security context for the container.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplateTlsSidecarContainerSecurityContext SecurityContext;

        [OutputConstructor]
        private KafkaSpecCruiseControlTemplateTlsSidecarContainer(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplateTlsSidecarContainerEnv> env,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplateTlsSidecarContainerSecurityContext securityContext)
        {
            Env = env;
            SecurityContext = securityContext;
        }
    }
}
