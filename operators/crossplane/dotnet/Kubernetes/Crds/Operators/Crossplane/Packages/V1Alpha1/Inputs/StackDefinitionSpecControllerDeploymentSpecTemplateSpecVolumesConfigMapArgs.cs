// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1
{

    public class StackDefinitionSpecControllerDeploymentSpecTemplateSpecVolumesConfigMapArgs : Pulumi.ResourceArgs
    {
        [Input("defaultMode")]
        public Input<int>? DefaultMode { get; set; }

        [Input("items")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecVolumesConfigMapItemsArgs>? _items;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecVolumesConfigMapItemsArgs> Items
        {
            get => _items ?? (_items = new InputList<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecVolumesConfigMapItemsArgs>());
            set => _items = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("optional")]
        public Input<bool>? Optional { get; set; }

        public StackDefinitionSpecControllerDeploymentSpecTemplateSpecVolumesConfigMapArgs()
        {
        }
    }
}
