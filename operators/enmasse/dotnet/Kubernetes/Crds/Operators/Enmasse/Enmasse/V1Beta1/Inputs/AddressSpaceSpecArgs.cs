// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1
{

    public class AddressSpaceSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The authentication service to use for authenticating messaging clients.
        /// </summary>
        [Input("authenticationService")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1.AddressSpaceSpecAuthenticationServiceArgs>? AuthenticationService { get; set; }

        [Input("connectors")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1.AddressSpaceSpecConnectorsArgs>? _connectors;

        /// <summary>
        /// External AMQP connections.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1.AddressSpaceSpecConnectorsArgs> Connectors
        {
            get => _connectors ?? (_connectors = new InputList<Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1.AddressSpaceSpecConnectorsArgs>());
            set => _connectors = value;
        }

        [Input("endpoints")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1.AddressSpaceSpecEndpointsArgs>? _endpoints;

        /// <summary>
        /// Endpoints configured for this address space.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1.AddressSpaceSpecEndpointsArgs> Endpoints
        {
            get => _endpoints ?? (_endpoints = new InputList<Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1.AddressSpaceSpecEndpointsArgs>());
            set => _endpoints = value;
        }

        /// <summary>
        /// Define NetworkPolicy for this address space.
        /// </summary>
        [Input("networkPolicy")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1.AddressSpaceSpecNetworkPolicyArgs>? NetworkPolicy { get; set; }

        /// <summary>
        /// The name of the address space plan to apply.
        /// </summary>
        [Input("plan", required: true)]
        public Input<string> Plan { get; set; } = null!;

        /// <summary>
        /// The type of address space.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public AddressSpaceSpecArgs()
        {
        }
    }
}