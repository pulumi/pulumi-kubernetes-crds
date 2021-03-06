// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1
{

    [OutputType]
    public sealed class JaegerSpecStorageDependenciesVolumesProjectedSources
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageDependenciesVolumesProjectedSourcesConfigMap ConfigMap;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageDependenciesVolumesProjectedSourcesDownwardAPI DownwardAPI;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageDependenciesVolumesProjectedSourcesSecret Secret;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageDependenciesVolumesProjectedSourcesServiceAccountToken ServiceAccountToken;

        [OutputConstructor]
        private JaegerSpecStorageDependenciesVolumesProjectedSources(
            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageDependenciesVolumesProjectedSourcesConfigMap configMap,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageDependenciesVolumesProjectedSourcesDownwardAPI downwardAPI,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageDependenciesVolumesProjectedSourcesSecret secret,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageDependenciesVolumesProjectedSourcesServiceAccountToken serviceAccountToken)
        {
            ConfigMap = configMap;
            DownwardAPI = downwardAPI;
            Secret = secret;
            ServiceAccountToken = serviceAccountToken;
        }
    }
}
