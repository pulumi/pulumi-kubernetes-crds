// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Maistra.V2
{

    public class ServiceMeshControlPlaneStatusAppliedSpecProxyNetworkingInitializationInitContainerRuntimeArgs : Pulumi.ResourceArgs
    {
        [Input("env")]
        private InputMap<string>? _env;
        public InputMap<string> Env
        {
            get => _env ?? (_env = new InputMap<string>());
            set => _env = value;
        }

        [Input("imageName")]
        public Input<string>? ImageName { get; set; }

        [Input("imagePullPolicy")]
        public Input<string>? ImagePullPolicy { get; set; }

        [Input("imagePullSecrets")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecProxyNetworkingInitializationInitContainerRuntimeImagePullSecretsArgs>? _imagePullSecrets;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecProxyNetworkingInitializationInitContainerRuntimeImagePullSecretsArgs> ImagePullSecrets
        {
            get => _imagePullSecrets ?? (_imagePullSecrets = new InputList<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecProxyNetworkingInitializationInitContainerRuntimeImagePullSecretsArgs>());
            set => _imagePullSecrets = value;
        }

        [Input("imageRegistry")]
        public Input<string>? ImageRegistry { get; set; }

        [Input("imageTag")]
        public Input<string>? ImageTag { get; set; }

        [Input("resources")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecProxyNetworkingInitializationInitContainerRuntimeResourcesArgs>? Resources { get; set; }

        public ServiceMeshControlPlaneStatusAppliedSpecProxyNetworkingInitializationInitContainerRuntimeArgs()
        {
        }
    }
}
