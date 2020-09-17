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
    public sealed class PodMonitorSpec
    {
        /// <summary>
        /// The label to use to retrieve the job name from.
        /// </summary>
        public readonly string JobLabel;
        /// <summary>
        /// Selector to select which namespaces the Endpoints objects are discovered from.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecNamespaceSelector NamespaceSelector;
        /// <summary>
        /// A list of endpoints allowed as part of this PodMonitor.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecPodMetricsEndpoints> PodMetricsEndpoints;
        /// <summary>
        /// PodTargetLabels transfers labels on the Kubernetes Pod onto the target.
        /// </summary>
        public readonly ImmutableArray<string> PodTargetLabels;
        /// <summary>
        /// SampleLimit defines per-scrape limit on number of scraped samples that will be accepted.
        /// </summary>
        public readonly int SampleLimit;
        /// <summary>
        /// Selector to select Pod objects.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecSelector Selector;

        [OutputConstructor]
        private PodMonitorSpec(
            string jobLabel,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecNamespaceSelector namespaceSelector,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecPodMetricsEndpoints> podMetricsEndpoints,

            ImmutableArray<string> podTargetLabels,

            int sampleLimit,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecSelector selector)
        {
            JobLabel = jobLabel;
            NamespaceSelector = namespaceSelector;
            PodMetricsEndpoints = podMetricsEndpoints;
            PodTargetLabels = podTargetLabels;
            SampleLimit = sampleLimit;
            Selector = selector;
        }
    }
}
