// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta2
{

    public class AddressPlanSpecResourcesArgs : Pulumi.ResourceArgs
    {
        [Input("broker")]
        public Input<double>? Broker { get; set; }

        [Input("router")]
        public Input<double>? Router { get; set; }

        public AddressPlanSpecResourcesArgs()
        {
        }
    }
}
