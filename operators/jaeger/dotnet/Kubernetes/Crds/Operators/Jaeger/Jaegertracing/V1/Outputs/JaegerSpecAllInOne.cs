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
    public sealed class JaegerSpecAllInOne
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAllInOneAffinity Affinity;
        public readonly ImmutableDictionary<string, string> Annotations;
        public readonly ImmutableDictionary<string, object> Config;
        public readonly string Image;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly ImmutableDictionary<string, object> Options;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAllInOneResources Resources;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAllInOneSecurityContext SecurityContext;
        public readonly string ServiceAccount;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAllInOneTolerations> Tolerations;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAllInOneVolumeMounts> VolumeMounts;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAllInOneVolumes> Volumes;

        [OutputConstructor]
        private JaegerSpecAllInOne(
            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAllInOneAffinity affinity,

            ImmutableDictionary<string, string> annotations,

            ImmutableDictionary<string, object> config,

            string image,

            ImmutableDictionary<string, string> labels,

            ImmutableDictionary<string, object> options,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAllInOneResources resources,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAllInOneSecurityContext securityContext,

            string serviceAccount,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAllInOneTolerations> tolerations,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAllInOneVolumeMounts> volumeMounts,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAllInOneVolumes> volumes)
        {
            Affinity = affinity;
            Annotations = annotations;
            Config = config;
            Image = image;
            Labels = labels;
            Options = options;
            Resources = resources;
            SecurityContext = securityContext;
            ServiceAccount = serviceAccount;
            Tolerations = tolerations;
            VolumeMounts = volumeMounts;
            Volumes = volumes;
        }
    }
}
