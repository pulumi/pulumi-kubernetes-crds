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
    public sealed class JaegerSpecAgent
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentAffinity Affinity;
        public readonly ImmutableDictionary<string, string> Annotations;
        public readonly ImmutableDictionary<string, object> Config;
        public readonly string Image;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentImagePullSecrets> ImagePullSecrets;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly ImmutableDictionary<string, object> Options;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentResources Resources;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentSecurityContext SecurityContext;
        public readonly string ServiceAccount;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentSidecarSecurityContext SidecarSecurityContext;
        public readonly string Strategy;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentTolerations> Tolerations;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumeMounts> VolumeMounts;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumes> Volumes;

        [OutputConstructor]
        private JaegerSpecAgent(
            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentAffinity affinity,

            ImmutableDictionary<string, string> annotations,

            ImmutableDictionary<string, object> config,

            string image,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentImagePullSecrets> imagePullSecrets,

            ImmutableDictionary<string, string> labels,

            ImmutableDictionary<string, object> options,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentResources resources,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentSecurityContext securityContext,

            string serviceAccount,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentSidecarSecurityContext sidecarSecurityContext,

            string strategy,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentTolerations> tolerations,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumeMounts> volumeMounts,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumes> volumes)
        {
            Affinity = affinity;
            Annotations = annotations;
            Config = config;
            Image = image;
            ImagePullSecrets = imagePullSecrets;
            Labels = labels;
            Options = options;
            Resources = resources;
            SecurityContext = securityContext;
            ServiceAccount = serviceAccount;
            SidecarSecurityContext = sidecarSecurityContext;
            Strategy = strategy;
            Tolerations = tolerations;
            VolumeMounts = volumeMounts;
            Volumes = volumes;
        }
    }
}
