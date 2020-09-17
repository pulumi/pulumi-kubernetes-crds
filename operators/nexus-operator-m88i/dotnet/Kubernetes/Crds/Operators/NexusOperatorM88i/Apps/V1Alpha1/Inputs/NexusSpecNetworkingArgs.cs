// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1
{

    /// <summary>
    /// Networking definition
    /// </summary>
    public class NexusSpecNetworkingArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Set to `true` to expose the Nexus application. Default to false.
        /// </summary>
        [Input("expose")]
        public Input<bool>? Expose { get; set; }

        /// <summary>
        /// Type of networking exposure: NodePort, Route or Ingress. Default to Route on OpenShift and Ingress on Kubernetes.
        /// </summary>
        [Input("exposeAs")]
        public Input<string>? ExposeAs { get; set; }

        /// <summary>
        /// Host where the Nexus service is exposed. This attribute is required if the service is exposed via Ingress.
        /// </summary>
        [Input("host")]
        public Input<string>? Host { get; set; }

        /// <summary>
        /// NodePort defined in the exposed service. Required if exposed via NodePort.
        /// </summary>
        [Input("nodePort")]
        public Input<int>? NodePort { get; set; }

        /// <summary>
        /// TLS/SSL-related configuration
        /// </summary>
        [Input("tls")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.NexusSpecNetworkingTlsArgs>? Tls { get; set; }

        public NexusSpecNetworkingArgs()
        {
        }
    }
}