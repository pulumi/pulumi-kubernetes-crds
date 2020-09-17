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
    public sealed class JaegerSpecStorageEsIndexCleanerAffinity
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageEsIndexCleanerAffinityNodeAffinity NodeAffinity;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageEsIndexCleanerAffinityPodAffinity PodAffinity;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageEsIndexCleanerAffinityPodAntiAffinity PodAntiAffinity;

        [OutputConstructor]
        private JaegerSpecStorageEsIndexCleanerAffinity(
            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageEsIndexCleanerAffinityNodeAffinity nodeAffinity,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageEsIndexCleanerAffinityPodAffinity podAffinity,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageEsIndexCleanerAffinityPodAntiAffinity podAntiAffinity)
        {
            NodeAffinity = nodeAffinity;
            PodAffinity = podAffinity;
            PodAntiAffinity = podAntiAffinity;
        }
    }
}