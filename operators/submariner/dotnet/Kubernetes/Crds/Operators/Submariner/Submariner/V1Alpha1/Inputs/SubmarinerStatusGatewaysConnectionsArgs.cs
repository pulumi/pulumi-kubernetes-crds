// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Submariner.V1Alpha1
{

    public class SubmarinerStatusGatewaysConnectionsArgs : Pulumi.ResourceArgs
    {
        [Input("endpoint", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Submariner.V1Alpha1.SubmarinerStatusGatewaysConnectionsEndpointArgs> Endpoint { get; set; } = null!;

        /// <summary>
        /// LatencySpec describes the round trip time information for a packet between the gateway pods of two clusters.
        /// </summary>
        [Input("latencyRTT")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Submariner.V1Alpha1.SubmarinerStatusGatewaysConnectionsLatencyRTTArgs>? LatencyRTT { get; set; }

        [Input("status", required: true)]
        public Input<string> Status { get; set; } = null!;

        [Input("statusMessage", required: true)]
        public Input<string> StatusMessage { get; set; } = null!;

        public SubmarinerStatusGatewaysConnectionsArgs()
        {
        }
    }
}
