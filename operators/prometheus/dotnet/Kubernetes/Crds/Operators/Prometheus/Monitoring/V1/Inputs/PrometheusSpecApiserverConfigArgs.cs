// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1
{

    /// <summary>
    /// APIServerConfig allows specifying a host and auth methods to access apiserver. If left empty, Prometheus is assumed to run inside of the cluster and will discover API servers automatically and use the pod's CA certificate and bearer token file at /var/run/secrets/kubernetes.io/serviceaccount/.
    /// </summary>
    public class PrometheusSpecApiserverConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// BasicAuth allow an endpoint to authenticate over basic authentication
        /// </summary>
        [Input("basicAuth")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.PrometheusSpecApiserverConfigBasicAuthArgs>? BasicAuth { get; set; }

        /// <summary>
        /// Bearer token for accessing apiserver.
        /// </summary>
        [Input("bearerToken")]
        public Input<string>? BearerToken { get; set; }

        /// <summary>
        /// File to read bearer token for accessing apiserver.
        /// </summary>
        [Input("bearerTokenFile")]
        public Input<string>? BearerTokenFile { get; set; }

        /// <summary>
        /// Host of apiserver. A valid string consisting of a hostname or IP followed by an optional port number
        /// </summary>
        [Input("host", required: true)]
        public Input<string> Host { get; set; } = null!;

        /// <summary>
        /// TLS Config to use for accessing apiserver.
        /// </summary>
        [Input("tlsConfig")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.PrometheusSpecApiserverConfigTlsConfigArgs>? TlsConfig { get; set; }

        public PrometheusSpecApiserverConfigArgs()
        {
        }
    }
}