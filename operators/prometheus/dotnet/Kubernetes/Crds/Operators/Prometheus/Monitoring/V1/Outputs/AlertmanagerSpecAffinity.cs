// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1
{

    [OutputType]
    public sealed class AlertmanagerSpecAffinity
    {
        /// <summary>
        /// Describes node affinity scheduling rules for the pod.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.AlertmanagerSpecAffinityNodeAffinity NodeAffinity;
        /// <summary>
        /// Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.AlertmanagerSpecAffinityPodAffinity PodAffinity;
        /// <summary>
        /// Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.AlertmanagerSpecAffinityPodAntiAffinity PodAntiAffinity;

        [OutputConstructor]
        private AlertmanagerSpecAffinity(
            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.AlertmanagerSpecAffinityNodeAffinity nodeAffinity,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.AlertmanagerSpecAffinityPodAffinity podAffinity,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.AlertmanagerSpecAffinityPodAntiAffinity podAntiAffinity)
        {
            NodeAffinity = nodeAffinity;
            PodAffinity = podAffinity;
            PodAntiAffinity = podAntiAffinity;
        }
    }
}
