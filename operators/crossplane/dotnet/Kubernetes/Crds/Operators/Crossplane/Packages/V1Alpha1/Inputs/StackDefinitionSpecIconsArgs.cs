// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1
{

    public class StackDefinitionSpecIconsArgs : Pulumi.ResourceArgs
    {
        [Input("base64Data", required: true)]
        public Input<string> Base64Data { get; set; } = null!;

        [Input("mediatype", required: true)]
        public Input<string> Mediatype { get; set; } = null!;

        public StackDefinitionSpecIconsArgs()
        {
        }
    }
}
