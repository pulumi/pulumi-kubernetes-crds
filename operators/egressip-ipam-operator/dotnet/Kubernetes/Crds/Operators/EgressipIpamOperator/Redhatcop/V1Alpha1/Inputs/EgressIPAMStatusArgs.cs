// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1
{

    /// <summary>
    /// EgressIPAMStatus defines the observed state of EgressIPAM
    /// </summary>
    public class EgressIPAMStatusArgs : Pulumi.ResourceArgs
    {
        [Input("lastUpdate")]
        public Input<string>? LastUpdate { get; set; }

        [Input("reason")]
        public Input<string>? Reason { get; set; }

        [Input("status")]
        public Input<string>? Status { get; set; }

        public EgressIPAMStatusArgs()
        {
        }
    }
}
