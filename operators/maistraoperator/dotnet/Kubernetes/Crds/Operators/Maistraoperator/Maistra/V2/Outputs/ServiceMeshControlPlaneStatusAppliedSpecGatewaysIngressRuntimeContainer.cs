// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Maistra.V2
{

    [OutputType]
    public sealed class ServiceMeshControlPlaneStatusAppliedSpecGatewaysIngressRuntimeContainer
    {
        public readonly ImmutableDictionary<string, string> Env;
        public readonly string ImageName;
        public readonly string ImagePullPolicy;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysIngressRuntimeContainerImagePullSecrets> ImagePullSecrets;
        public readonly string ImageRegistry;
        public readonly string ImageTag;
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysIngressRuntimeContainerResources Resources;

        [OutputConstructor]
        private ServiceMeshControlPlaneStatusAppliedSpecGatewaysIngressRuntimeContainer(
            ImmutableDictionary<string, string> env,

            string imageName,

            string imagePullPolicy,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysIngressRuntimeContainerImagePullSecrets> imagePullSecrets,

            string imageRegistry,

            string imageTag,

            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysIngressRuntimeContainerResources resources)
        {
            Env = env;
            ImageName = imageName;
            ImagePullPolicy = imagePullPolicy;
            ImagePullSecrets = imagePullSecrets;
            ImageRegistry = imageRegistry;
            ImageTag = imageTag;
            Resources = resources;
        }
    }
}
