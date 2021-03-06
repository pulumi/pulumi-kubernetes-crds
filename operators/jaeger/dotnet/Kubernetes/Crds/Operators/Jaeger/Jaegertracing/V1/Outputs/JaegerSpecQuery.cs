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
    public sealed class JaegerSpecQuery
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecQueryAffinity Affinity;
        public readonly ImmutableDictionary<string, string> Annotations;
        public readonly string Image;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly ImmutableDictionary<string, object> Options;
        public readonly int Replicas;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecQueryResources Resources;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecQuerySecurityContext SecurityContext;
        public readonly string ServiceAccount;
        public readonly string ServiceType;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecQueryTolerations> Tolerations;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecQueryVolumeMounts> VolumeMounts;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecQueryVolumes> Volumes;

        [OutputConstructor]
        private JaegerSpecQuery(
            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecQueryAffinity affinity,

            ImmutableDictionary<string, string> annotations,

            string image,

            ImmutableDictionary<string, string> labels,

            ImmutableDictionary<string, object> options,

            int replicas,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecQueryResources resources,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecQuerySecurityContext securityContext,

            string serviceAccount,

            string serviceType,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecQueryTolerations> tolerations,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecQueryVolumeMounts> volumeMounts,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecQueryVolumes> volumes)
        {
            Affinity = affinity;
            Annotations = annotations;
            Image = image;
            Labels = labels;
            Options = options;
            Replicas = replicas;
            Resources = resources;
            SecurityContext = securityContext;
            ServiceAccount = serviceAccount;
            ServiceType = serviceType;
            Tolerations = tolerations;
            VolumeMounts = volumeMounts;
            Volumes = volumes;
        }
    }
}
