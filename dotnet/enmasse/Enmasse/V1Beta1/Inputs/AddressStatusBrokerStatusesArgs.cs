// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1
{

    public class AddressStatusBrokerStatusesArgs : Pulumi.ResourceArgs
    {
        [Input("brokerId")]
        public Input<string>? BrokerId { get; set; }

        [Input("clusterId")]
        public Input<string>? ClusterId { get; set; }

        [Input("state")]
        public Input<string>? State { get; set; }

        public AddressStatusBrokerStatusesArgs()
        {
        }
    }
}
