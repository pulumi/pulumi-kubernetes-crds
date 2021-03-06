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
    public sealed class PrometheusSpecVolumesProjectedSources
    {
        /// <summary>
        /// information about the configMap data to project
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecVolumesProjectedSourcesConfigMap ConfigMap;
        /// <summary>
        /// information about the downwardAPI data to project
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecVolumesProjectedSourcesDownwardAPI DownwardAPI;
        /// <summary>
        /// information about the secret data to project
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecVolumesProjectedSourcesSecret Secret;
        /// <summary>
        /// information about the serviceAccountToken data to project
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecVolumesProjectedSourcesServiceAccountToken ServiceAccountToken;

        [OutputConstructor]
        private PrometheusSpecVolumesProjectedSources(
            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecVolumesProjectedSourcesConfigMap configMap,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecVolumesProjectedSourcesDownwardAPI downwardAPI,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecVolumesProjectedSourcesSecret secret,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecVolumesProjectedSourcesServiceAccountToken serviceAccountToken)
        {
            ConfigMap = configMap;
            DownwardAPI = downwardAPI;
            Secret = secret;
            ServiceAccountToken = serviceAccountToken;
        }
    }
}
