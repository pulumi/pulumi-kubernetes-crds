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
    public sealed class KafkaMirrorMakerSpecTemplateMirrorMakerContainer
    {
        /// <summary>
        /// Environment variables which should be applied to the container.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaMirrorMakerSpecTemplateMirrorMakerContainerEnv> Env;
        /// <summary>
        /// Security context for the container.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaMirrorMakerSpecTemplateMirrorMakerContainerSecurityContext SecurityContext;

        [OutputConstructor]
        private KafkaMirrorMakerSpecTemplateMirrorMakerContainer(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaMirrorMakerSpecTemplateMirrorMakerContainerEnv> env,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaMirrorMakerSpecTemplateMirrorMakerContainerSecurityContext securityContext)
        {
            Env = env;
            SecurityContext = securityContext;
        }
    }
}
