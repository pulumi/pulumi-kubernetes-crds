// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1
{

    [OutputType]
    public sealed class Iperf3SpecServerConfiguration
    {
        /// <summary>
        /// CmdLineArgs are appended to the predefined iperf3 parameters
        /// </summary>
        public readonly string CmdLineArgs;
        /// <summary>
        /// HostNetwork requested for the iperf3 pod, if enabled the hosts network namespace is used. Default to false.
        /// </summary>
        public readonly bool HostNetwork;
        /// <summary>
        /// PodLabels are added to the pod as labels.
        /// </summary>
        public readonly ImmutableDictionary<string, string> PodLabels;
        /// <summary>
        /// PodScheduling contains options to determine which node the pod should be scheduled on
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.Iperf3SpecServerConfigurationPodScheduling PodScheduling;
        /// <summary>
        /// Resources required by the benchmark pod container More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.Iperf3SpecServerConfigurationResources Resources;

        [OutputConstructor]
        private Iperf3SpecServerConfiguration(
            string cmdLineArgs,

            bool hostNetwork,

            ImmutableDictionary<string, string> podLabels,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.Iperf3SpecServerConfigurationPodScheduling podScheduling,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.Iperf3SpecServerConfigurationResources resources)
        {
            CmdLineArgs = cmdLineArgs;
            HostNetwork = hostNetwork;
            PodLabels = podLabels;
            PodScheduling = podScheduling;
            Resources = resources;
        }
    }
}