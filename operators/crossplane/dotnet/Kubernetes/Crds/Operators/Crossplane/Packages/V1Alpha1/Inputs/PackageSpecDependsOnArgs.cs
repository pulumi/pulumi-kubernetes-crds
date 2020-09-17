// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1
{

    public class PackageSpecDependsOnArgs : Pulumi.ResourceArgs
    {
        [Input("crd")]
        public Input<string>? Crd { get; set; }

        [Input("imagePullPolicy")]
        public Input<string>? ImagePullPolicy { get; set; }

        [Input("imagePullSecrets")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecDependsOnImagePullSecretsArgs>? _imagePullSecrets;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecDependsOnImagePullSecretsArgs> ImagePullSecrets
        {
            get => _imagePullSecrets ?? (_imagePullSecrets = new InputList<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecDependsOnImagePullSecretsArgs>());
            set => _imagePullSecrets = value;
        }

        [Input("package")]
        public Input<string>? Package { get; set; }

        [Input("serviceAccount")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecDependsOnServiceAccountArgs>? ServiceAccount { get; set; }

        [Input("source")]
        public Input<string>? Source { get; set; }

        public PackageSpecDependsOnArgs()
        {
        }
    }
}
