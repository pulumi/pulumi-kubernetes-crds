// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1
{

    public class AddressSpaceSpecEndpointsExposeArgs : Pulumi.ResourceArgs
    {
        [Input("type")]
        public Input<object>? Type { get; set; }

        public AddressSpaceSpecEndpointsExposeArgs()
        {
        }
    }
}
