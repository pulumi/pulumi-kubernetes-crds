// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1
{

    public class StackDefinitionSpecBehaviorCrdArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion", required: true)]
        public Input<string> ApiVersion { get; set; } = null!;

        [Input("kind", required: true)]
        public Input<string> Kind { get; set; } = null!;

        public StackDefinitionSpecBehaviorCrdArgs()
        {
        }
    }
}
