// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1
{

    public class PackageSpecControllerDeploymentSpecTemplateSpecContainersEnvValueFromArgs : Pulumi.ResourceArgs
    {
        [Input("configMapKeyRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecContainersEnvValueFromConfigMapKeyRefArgs>? ConfigMapKeyRef { get; set; }

        [Input("fieldRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecContainersEnvValueFromFieldRefArgs>? FieldRef { get; set; }

        [Input("resourceFieldRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecContainersEnvValueFromResourceFieldRefArgs>? ResourceFieldRef { get; set; }

        [Input("secretKeyRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecContainersEnvValueFromSecretKeyRefArgs>? SecretKeyRef { get; set; }

        public PackageSpecControllerDeploymentSpecTemplateSpecContainersEnvValueFromArgs()
        {
        }
    }
}
