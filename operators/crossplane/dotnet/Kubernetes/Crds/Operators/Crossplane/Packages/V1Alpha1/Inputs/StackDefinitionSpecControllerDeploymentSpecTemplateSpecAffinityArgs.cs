// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1
{

    public class StackDefinitionSpecControllerDeploymentSpecTemplateSpecAffinityArgs : Pulumi.ResourceArgs
    {
        [Input("nodeAffinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecAffinityNodeAffinityArgs>? NodeAffinity { get; set; }

        [Input("podAffinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecAffinityPodAffinityArgs>? PodAffinity { get; set; }

        [Input("podAntiAffinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecAffinityPodAntiAffinityArgs>? PodAntiAffinity { get; set; }

        public StackDefinitionSpecControllerDeploymentSpecTemplateSpecAffinityArgs()
        {
        }
    }
}
