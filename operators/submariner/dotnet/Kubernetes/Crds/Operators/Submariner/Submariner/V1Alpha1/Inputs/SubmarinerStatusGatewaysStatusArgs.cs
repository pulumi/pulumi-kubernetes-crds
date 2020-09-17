// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Submariner.V1Alpha1
{

    public class SubmarinerStatusGatewaysStatusArgs : Pulumi.ResourceArgs
    {
        [Input("connections", required: true)]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Submariner.V1Alpha1.SubmarinerStatusGatewaysStatusConnectionsArgs>? _connections;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Submariner.V1Alpha1.SubmarinerStatusGatewaysStatusConnectionsArgs> Connections
        {
            get => _connections ?? (_connections = new InputList<Pulumi.Kubernetes.Types.Inputs.Submariner.V1Alpha1.SubmarinerStatusGatewaysStatusConnectionsArgs>());
            set => _connections = value;
        }

        [Input("haStatus", required: true)]
        public Input<string> HaStatus { get; set; } = null!;

        [Input("localEndpoint", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Submariner.V1Alpha1.SubmarinerStatusGatewaysStatusLocalEndpointArgs> LocalEndpoint { get; set; } = null!;

        [Input("statusFailure", required: true)]
        public Input<string> StatusFailure { get; set; } = null!;

        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        public SubmarinerStatusGatewaysStatusArgs()
        {
        }
    }
}
