// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1
{

    public class PackageSpecControllerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartHttpGetArgs : Pulumi.ResourceArgs
    {
        [Input("host")]
        public Input<string>? Host { get; set; }

        [Input("httpHeaders")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartHttpGetHttpHeadersArgs>? _httpHeaders;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartHttpGetHttpHeadersArgs> HttpHeaders
        {
            get => _httpHeaders ?? (_httpHeaders = new InputList<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartHttpGetHttpHeadersArgs>());
            set => _httpHeaders = value;
        }

        [Input("path")]
        public Input<string>? Path { get; set; }

        [Input("port", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartHttpGetPortArgs> Port { get; set; } = null!;

        [Input("scheme")]
        public Input<string>? Scheme { get; set; }

        public PackageSpecControllerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartHttpGetArgs()
        {
        }
    }
}