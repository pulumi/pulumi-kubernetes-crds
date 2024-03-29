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
    /// AlertmanagerEndpoints defines a selection of a single Endpoints object containing alertmanager IPs to fire alerts against.
    /// </summary>
    public class PrometheusSpecAlertingAlertmanagersArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Version of the Alertmanager API that Prometheus uses to send alerts. It can be "v1" or "v2".
        /// </summary>
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        /// <summary>
        /// BearerTokenFile to read from filesystem to use when authenticating to Alertmanager.
        /// </summary>
        [Input("bearerTokenFile")]
        public Input<string>? BearerTokenFile { get; set; }

        /// <summary>
        /// Name of Endpoints object in Namespace.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Namespace of Endpoints object.
        /// </summary>
        [Input("namespace", required: true)]
        public Input<string> Namespace { get; set; } = null!;

        /// <summary>
        /// Prefix for the HTTP path alerts are pushed to.
        /// </summary>
        [Input("pathPrefix")]
        public Input<string>? PathPrefix { get; set; }

        /// <summary>
        /// Port the Alertmanager API is exposed on.
        /// </summary>
        [Input("port", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.PrometheusSpecAlertingAlertmanagersPortArgs> Port { get; set; } = null!;

        /// <summary>
        /// Scheme to use when firing alerts.
        /// </summary>
        [Input("scheme")]
        public Input<string>? Scheme { get; set; }

        /// <summary>
        /// TLS Config to use for alertmanager connection.
        /// </summary>
        [Input("tlsConfig")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.PrometheusSpecAlertingAlertmanagersTlsConfigArgs>? TlsConfig { get; set; }

        public PrometheusSpecAlertingAlertmanagersArgs()
        {
        }
    }
}
