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
    public sealed class JaegerSpecIngesterAffinity
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecIngesterAffinityNodeAffinity NodeAffinity;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecIngesterAffinityPodAffinity PodAffinity;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecIngesterAffinityPodAntiAffinity PodAntiAffinity;

        [OutputConstructor]
        private JaegerSpecIngesterAffinity(
            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecIngesterAffinityNodeAffinity nodeAffinity,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecIngesterAffinityPodAffinity podAffinity,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecIngesterAffinityPodAntiAffinity podAntiAffinity)
        {
            NodeAffinity = nodeAffinity;
            PodAffinity = podAffinity;
            PodAntiAffinity = podAntiAffinity;
        }
    }
}
