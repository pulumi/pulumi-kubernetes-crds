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
    public sealed class JaegerSpecStorageDependenciesAffinity
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageDependenciesAffinityNodeAffinity NodeAffinity;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageDependenciesAffinityPodAffinity PodAffinity;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageDependenciesAffinityPodAntiAffinity PodAntiAffinity;

        [OutputConstructor]
        private JaegerSpecStorageDependenciesAffinity(
            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageDependenciesAffinityNodeAffinity nodeAffinity,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageDependenciesAffinityPodAffinity podAffinity,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageDependenciesAffinityPodAntiAffinity podAntiAffinity)
        {
            NodeAffinity = nodeAffinity;
            PodAffinity = podAffinity;
            PodAntiAffinity = podAntiAffinity;
        }
    }
}
