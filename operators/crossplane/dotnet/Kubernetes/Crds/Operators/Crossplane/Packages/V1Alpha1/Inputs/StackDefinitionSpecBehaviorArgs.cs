// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1
{

    public class StackDefinitionSpecBehaviorArgs : Pulumi.ResourceArgs
    {
        [Input("crd")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.StackDefinitionSpecBehaviorCrdArgs>? Crd { get; set; }

        [Input("engine")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.StackDefinitionSpecBehaviorEngineArgs>? Engine { get; set; }

        [Input("source")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.StackDefinitionSpecBehaviorSourceArgs>? Source { get; set; }

        public StackDefinitionSpecBehaviorArgs()
        {
        }
    }
}