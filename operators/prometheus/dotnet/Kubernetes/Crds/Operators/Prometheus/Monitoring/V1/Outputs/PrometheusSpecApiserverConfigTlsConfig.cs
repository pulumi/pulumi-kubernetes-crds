// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1
{

    [OutputType]
    public sealed class PrometheusSpecApiserverConfigTlsConfig
    {
        /// <summary>
        /// Stuct containing the CA cert to use for the targets.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecApiserverConfigTlsConfigCa Ca;
        /// <summary>
        /// Path to the CA cert in the Prometheus container to use for the targets.
        /// </summary>
        public readonly string CaFile;
        /// <summary>
        /// Struct containing the client cert file for the targets.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecApiserverConfigTlsConfigCert Cert;
        /// <summary>
        /// Path to the client cert file in the Prometheus container for the targets.
        /// </summary>
        public readonly string CertFile;
        /// <summary>
        /// Disable target certificate validation.
        /// </summary>
        public readonly bool InsecureSkipVerify;
        /// <summary>
        /// Path to the client key file in the Prometheus container for the targets.
        /// </summary>
        public readonly string KeyFile;
        /// <summary>
        /// Secret containing the client key file for the targets.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecApiserverConfigTlsConfigKeySecret KeySecret;
        /// <summary>
        /// Used to verify the hostname for the targets.
        /// </summary>
        public readonly string ServerName;

        [OutputConstructor]
        private PrometheusSpecApiserverConfigTlsConfig(
            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecApiserverConfigTlsConfigCa ca,

            string caFile,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecApiserverConfigTlsConfigCert cert,

            string certFile,

            bool insecureSkipVerify,

            string keyFile,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecApiserverConfigTlsConfigKeySecret keySecret,

            string serverName)
        {
            Ca = ca;
            CaFile = caFile;
            Cert = cert;
            CertFile = certFile;
            InsecureSkipVerify = insecureSkipVerify;
            KeyFile = keyFile;
            KeySecret = keySecret;
            ServerName = serverName;
        }
    }
}
