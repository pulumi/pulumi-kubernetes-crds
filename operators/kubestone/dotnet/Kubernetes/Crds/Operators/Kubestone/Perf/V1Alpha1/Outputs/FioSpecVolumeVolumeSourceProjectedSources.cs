// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1
{

    [OutputType]
    public sealed class FioSpecVolumeVolumeSourceProjectedSources
    {
        /// <summary>
        /// information about the configMap data to project
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceProjectedSourcesConfigMap ConfigMap;
        /// <summary>
        /// information about the downwardAPI data to project
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceProjectedSourcesDownwardAPI DownwardAPI;
        /// <summary>
        /// information about the secret data to project
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceProjectedSourcesSecret Secret;
        /// <summary>
        /// information about the serviceAccountToken data to project
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceProjectedSourcesServiceAccountToken ServiceAccountToken;

        [OutputConstructor]
        private FioSpecVolumeVolumeSourceProjectedSources(
            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceProjectedSourcesConfigMap configMap,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceProjectedSourcesDownwardAPI downwardAPI,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceProjectedSourcesSecret secret,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceProjectedSourcesServiceAccountToken serviceAccountToken)
        {
            ConfigMap = configMap;
            DownwardAPI = downwardAPI;
            Secret = secret;
            ServiceAccountToken = serviceAccountToken;
        }
    }
}
