// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1
{

    [OutputType]
    public sealed class APIManagerSpecSystemSidekiqSpecAffinity
    {
        /// <summary>
        /// Describes node affinity scheduling rules for the pod.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecSystemSidekiqSpecAffinityNodeAffinity NodeAffinity;
        /// <summary>
        /// Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecSystemSidekiqSpecAffinityPodAffinity PodAffinity;
        /// <summary>
        /// Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecSystemSidekiqSpecAffinityPodAntiAffinity PodAntiAffinity;

        [OutputConstructor]
        private APIManagerSpecSystemSidekiqSpecAffinity(
            Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecSystemSidekiqSpecAffinityNodeAffinity nodeAffinity,

            Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecSystemSidekiqSpecAffinityPodAffinity podAffinity,

            Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecSystemSidekiqSpecAffinityPodAntiAffinity podAntiAffinity)
        {
            NodeAffinity = nodeAffinity;
            PodAffinity = podAffinity;
            PodAntiAffinity = podAntiAffinity;
        }
    }
}
