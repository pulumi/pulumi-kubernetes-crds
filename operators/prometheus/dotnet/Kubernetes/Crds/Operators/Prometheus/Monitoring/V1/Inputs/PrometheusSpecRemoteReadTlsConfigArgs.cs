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
    /// TLS Config to use for remote read.
    /// </summary>
    public class PrometheusSpecRemoteReadTlsConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Stuct containing the CA cert to use for the targets.
        /// </summary>
        [Input("ca")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.PrometheusSpecRemoteReadTlsConfigCaArgs>? Ca { get; set; }

        /// <summary>
        /// Path to the CA cert in the Prometheus container to use for the targets.
        /// </summary>
        [Input("caFile")]
        public Input<string>? CaFile { get; set; }

        /// <summary>
        /// Struct containing the client cert file for the targets.
        /// </summary>
        [Input("cert")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.PrometheusSpecRemoteReadTlsConfigCertArgs>? Cert { get; set; }

        /// <summary>
        /// Path to the client cert file in the Prometheus container for the targets.
        /// </summary>
        [Input("certFile")]
        public Input<string>? CertFile { get; set; }

        /// <summary>
        /// Disable target certificate validation.
        /// </summary>
        [Input("insecureSkipVerify")]
        public Input<bool>? InsecureSkipVerify { get; set; }

        /// <summary>
        /// Path to the client key file in the Prometheus container for the targets.
        /// </summary>
        [Input("keyFile")]
        public Input<string>? KeyFile { get; set; }

        /// <summary>
        /// Secret containing the client key file for the targets.
        /// </summary>
        [Input("keySecret")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.PrometheusSpecRemoteReadTlsConfigKeySecretArgs>? KeySecret { get; set; }

        /// <summary>
        /// Used to verify the hostname for the targets.
        /// </summary>
        [Input("serverName")]
        public Input<string>? ServerName { get; set; }

        public PrometheusSpecRemoteReadTlsConfigArgs()
        {
        }
    }
}
