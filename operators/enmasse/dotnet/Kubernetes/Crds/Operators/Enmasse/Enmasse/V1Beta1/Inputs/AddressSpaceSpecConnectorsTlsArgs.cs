// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1
{

    /// <summary>
    /// TLS configuration for the connector. If not specified, TLS will not be used.
    /// </summary>
    public class AddressSpaceSpecConnectorsTlsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// CA certificate to be used by the connector.
        /// </summary>
        [Input("caCert")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1.AddressSpaceSpecConnectorsTlsCaCertArgs>? CaCert { get; set; }

        /// <summary>
        /// Client certificate to be used by the connector.
        /// </summary>
        [Input("clientCert")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1.AddressSpaceSpecConnectorsTlsClientCertArgs>? ClientCert { get; set; }

        /// <summary>
        /// Client key to be used by the connector.
        /// </summary>
        [Input("clientKey")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1.AddressSpaceSpecConnectorsTlsClientKeyArgs>? ClientKey { get; set; }

        public AddressSpaceSpecConnectorsTlsArgs()
        {
        }
    }
}
