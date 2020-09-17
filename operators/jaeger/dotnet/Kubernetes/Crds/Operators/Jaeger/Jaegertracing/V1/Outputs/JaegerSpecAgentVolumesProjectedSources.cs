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
    public sealed class JaegerSpecAgentVolumesProjectedSources
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesProjectedSourcesConfigMap ConfigMap;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesProjectedSourcesDownwardAPI DownwardAPI;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesProjectedSourcesSecret Secret;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesProjectedSourcesServiceAccountToken ServiceAccountToken;

        [OutputConstructor]
        private JaegerSpecAgentVolumesProjectedSources(
            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesProjectedSourcesConfigMap configMap,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesProjectedSourcesDownwardAPI downwardAPI,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesProjectedSourcesSecret secret,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesProjectedSourcesServiceAccountToken serviceAccountToken)
        {
            ConfigMap = configMap;
            DownwardAPI = downwardAPI;
            Secret = secret;
            ServiceAccountToken = serviceAccountToken;
        }
    }
}