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
    public sealed class JaegerSpecQueryAffinity
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecQueryAffinityNodeAffinity NodeAffinity;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecQueryAffinityPodAffinity PodAffinity;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecQueryAffinityPodAntiAffinity PodAntiAffinity;

        [OutputConstructor]
        private JaegerSpecQueryAffinity(
            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecQueryAffinityNodeAffinity nodeAffinity,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecQueryAffinityPodAffinity podAffinity,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecQueryAffinityPodAntiAffinity podAntiAffinity)
        {
            NodeAffinity = nodeAffinity;
            PodAffinity = podAffinity;
            PodAntiAffinity = podAntiAffinity;
        }
    }
}
