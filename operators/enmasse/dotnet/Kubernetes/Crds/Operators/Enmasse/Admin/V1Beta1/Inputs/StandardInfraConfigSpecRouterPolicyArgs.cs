// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta1
{

    public class StandardInfraConfigSpecRouterPolicyArgs : Pulumi.ResourceArgs
    {
        [Input("maxConnections")]
        public Input<int>? MaxConnections { get; set; }

        [Input("maxConnectionsPerHost")]
        public Input<int>? MaxConnectionsPerHost { get; set; }

        [Input("maxConnectionsPerUser")]
        public Input<int>? MaxConnectionsPerUser { get; set; }

        [Input("maxReceiversPerConnection")]
        public Input<int>? MaxReceiversPerConnection { get; set; }

        [Input("maxSendersPerConnection")]
        public Input<int>? MaxSendersPerConnection { get; set; }

        [Input("maxSessionsPerConnection")]
        public Input<int>? MaxSessionsPerConnection { get; set; }

        public StandardInfraConfigSpecRouterPolicyArgs()
        {
        }
    }
}