// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1
{

    [OutputType]
    public sealed class DatadogAgentSpecClusterChecksRunnerConfigVolumesProjectedSources
    {
        /// <summary>
        /// information about the configMap data to project
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecClusterChecksRunnerConfigVolumesProjectedSourcesConfigMap ConfigMap;
        /// <summary>
        /// information about the downwardAPI data to project
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecClusterChecksRunnerConfigVolumesProjectedSourcesDownwardAPI DownwardAPI;
        /// <summary>
        /// information about the secret data to project
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecClusterChecksRunnerConfigVolumesProjectedSourcesSecret Secret;
        /// <summary>
        /// information about the serviceAccountToken data to project
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecClusterChecksRunnerConfigVolumesProjectedSourcesServiceAccountToken ServiceAccountToken;

        [OutputConstructor]
        private DatadogAgentSpecClusterChecksRunnerConfigVolumesProjectedSources(
            Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecClusterChecksRunnerConfigVolumesProjectedSourcesConfigMap configMap,

            Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecClusterChecksRunnerConfigVolumesProjectedSourcesDownwardAPI downwardAPI,

            Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecClusterChecksRunnerConfigVolumesProjectedSourcesSecret secret,

            Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecClusterChecksRunnerConfigVolumesProjectedSourcesServiceAccountToken serviceAccountToken)
        {
            ConfigMap = configMap;
            DownwardAPI = downwardAPI;
            Secret = secret;
            ServiceAccountToken = serviceAccountToken;
        }
    }
}