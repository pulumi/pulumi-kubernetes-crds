// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1
{

    public class AddressSpaceSpecConnectorsArgs : Pulumi.ResourceArgs
    {
        [Input("addresses")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1.AddressSpaceSpecConnectorsAddressesArgs>? _addresses;

        /// <summary>
        /// Addresses to make be accessible via this address space.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1.AddressSpaceSpecConnectorsAddressesArgs> Addresses
        {
            get => _addresses ?? (_addresses = new InputList<Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1.AddressSpaceSpecConnectorsAddressesArgs>());
            set => _addresses = value;
        }

        /// <summary>
        /// Credentials used when connecting to endpoints.
        /// </summary>
        [Input("credentials")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1.AddressSpaceSpecConnectorsCredentialsArgs>? Credentials { get; set; }

        [Input("endpointHosts", required: true)]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1.AddressSpaceSpecConnectorsEndpointHostsArgs>? _endpointHosts;

        /// <summary>
        /// Endpoints to connect to. First entry is used as primary, additional entries are considered failovers.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1.AddressSpaceSpecConnectorsEndpointHostsArgs> EndpointHosts
        {
            get => _endpointHosts ?? (_endpointHosts = new InputList<Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1.AddressSpaceSpecConnectorsEndpointHostsArgs>());
            set => _endpointHosts = value;
        }

        /// <summary>
        /// Idle timeout of AMQP connection (seconds). 0 disables the idle timeout.
        /// </summary>
        [Input("idleTimeout")]
        public Input<int>? IdleTimeout { get; set; }

        /// <summary>
        /// Max frame size of AMQP connection.
        /// </summary>
        [Input("maxFrameSize")]
        public Input<int>? MaxFrameSize { get; set; }

        /// <summary>
        /// Connector name. Used to uniquely identify a connector.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Role of connector. Defaults to 'route-container'.
        /// </summary>
        [Input("role")]
        public Input<string>? Role { get; set; }

        /// <summary>
        /// TLS configuration for the connector. If not specified, TLS will not be used.
        /// </summary>
        [Input("tls")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1.AddressSpaceSpecConnectorsTlsArgs>? Tls { get; set; }

        public AddressSpaceSpecConnectorsArgs()
        {
        }
    }
}
