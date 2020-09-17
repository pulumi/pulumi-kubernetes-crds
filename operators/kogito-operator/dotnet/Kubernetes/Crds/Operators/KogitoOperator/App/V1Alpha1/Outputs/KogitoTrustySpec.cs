// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1
{

    [OutputType]
    public sealed class KogitoTrustySpec
    {
        /// <summary>
        /// Additional labels to be added to the Deployment and Pods managed by the operator.
        /// </summary>
        public readonly ImmutableDictionary<string, string> DeploymentLabels;
        /// <summary>
        /// Environment variables to be added to the runtime container. Keys must be a C_IDENTIFIER.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoTrustySpecEnvs> Envs;
        /// <summary>
        /// HttpPort will set the environment env HTTP_PORT to define which port service will listen internally.
        /// </summary>
        public readonly int HttpPort;
        /// <summary>
        /// Image definition for the service. Example: Domain: quay.io, Namespace: kiegroup, Name: kogito-service, Tag: latest. On OpenShift an ImageStream will be created in the current namespace pointing to the given image.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoTrustySpecImage Image;
        /// <summary>
        /// Has the data used by the service to connect to the Infinispan cluster.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoTrustySpecInfinispan Infinispan;
        /// <summary>
        /// A flag indicating that image streams created by Kogito Operator should be configured to allow pulling from insecure registries. Usable just on OpenShift. Defaults to 'false'.
        /// </summary>
        public readonly bool InsecureImageRegistry;
        /// <summary>
        /// Has the data used by the service to connect to the Kafka cluster.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoTrustySpecKafka Kafka;
        /// <summary>
        /// Number of replicas that the service will have deployed in the cluster. Default value: 1.
        /// </summary>
        public readonly int Replicas;
        /// <summary>
        /// Defined compute resource requirements for the deployed service.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoTrustySpecResources Resources;
        /// <summary>
        /// Additional labels to be added to the Service managed by the operator.
        /// </summary>
        public readonly ImmutableDictionary<string, string> ServiceLabels;

        [OutputConstructor]
        private KogitoTrustySpec(
            ImmutableDictionary<string, string> deploymentLabels,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoTrustySpecEnvs> envs,

            int httpPort,

            Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoTrustySpecImage image,

            Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoTrustySpecInfinispan infinispan,

            bool insecureImageRegistry,

            Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoTrustySpecKafka kafka,

            int replicas,

            Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoTrustySpecResources resources,

            ImmutableDictionary<string, string> serviceLabels)
        {
            DeploymentLabels = deploymentLabels;
            Envs = envs;
            HttpPort = httpPort;
            Image = image;
            Infinispan = infinispan;
            InsecureImageRegistry = insecureImageRegistry;
            Kafka = kafka;
            Replicas = replicas;
            Resources = resources;
            ServiceLabels = serviceLabels;
        }
    }
}