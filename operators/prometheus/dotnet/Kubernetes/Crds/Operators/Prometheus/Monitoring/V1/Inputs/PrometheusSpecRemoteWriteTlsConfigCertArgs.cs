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
    /// Struct containing the client cert file for the targets.
    /// </summary>
    public class PrometheusSpecRemoteWriteTlsConfigCertArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ConfigMap containing data to use for the targets.
        /// </summary>
        [Input("configMap")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.PrometheusSpecRemoteWriteTlsConfigCertConfigMapArgs>? ConfigMap { get; set; }

        /// <summary>
        /// Secret containing data to use for the targets.
        /// </summary>
        [Input("secret")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.PrometheusSpecRemoteWriteTlsConfigCertSecretArgs>? Secret { get; set; }

        public PrometheusSpecRemoteWriteTlsConfigCertArgs()
        {
        }
    }
}
