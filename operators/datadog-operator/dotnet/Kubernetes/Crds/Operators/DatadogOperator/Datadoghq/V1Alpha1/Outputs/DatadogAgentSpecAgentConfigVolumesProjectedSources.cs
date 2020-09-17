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
    public sealed class DatadogAgentSpecAgentConfigVolumesProjectedSources
    {
        /// <summary>
        /// information about the configMap data to project
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigVolumesProjectedSourcesConfigMap ConfigMap;
        /// <summary>
        /// information about the downwardAPI data to project
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigVolumesProjectedSourcesDownwardAPI DownwardAPI;
        /// <summary>
        /// information about the secret data to project
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigVolumesProjectedSourcesSecret Secret;
        /// <summary>
        /// information about the serviceAccountToken data to project
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigVolumesProjectedSourcesServiceAccountToken ServiceAccountToken;

        [OutputConstructor]
        private DatadogAgentSpecAgentConfigVolumesProjectedSources(
            Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigVolumesProjectedSourcesConfigMap configMap,

            Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigVolumesProjectedSourcesDownwardAPI downwardAPI,

            Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigVolumesProjectedSourcesSecret secret,

            Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigVolumesProjectedSourcesServiceAccountToken serviceAccountToken)
        {
            ConfigMap = configMap;
            DownwardAPI = downwardAPI;
            Secret = secret;
            ServiceAccountToken = serviceAccountToken;
        }
    }
}