// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1
{

    /// <summary>
    /// Configure the rolling updater strategy of the DaemonSet or the ExtendedDaemonSet
    /// </summary>
    public class DatadogAgentSpecAgentDeploymentStrategyRollingUpdateArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The maxium number of pods created in parallel. Default value is 250.
        /// </summary>
        [Input("maxParallelPodCreation")]
        public Input<int>? MaxParallelPodCreation { get; set; }

        /// <summary>
        /// MaxPodSchedulerFailure the maxinum number of not scheduled on its Node due to a scheduler failure: resource constraints. Value can be an absolute number (ex: 5) or a percentage of total number of DaemonSet pods at the start of the update (ex: 10%). Absolute
        /// </summary>
        [Input("maxPodSchedulerFailure")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentDeploymentStrategyRollingUpdateMaxPodSchedulerFailureArgs>? MaxPodSchedulerFailure { get; set; }

        /// <summary>
        /// The maximum number of DaemonSet pods that can be unavailable during the update. Value can be an absolute number (ex: 5) or a percentage of total number of DaemonSet pods at the start of the update (ex: 10%). Absolute number is calculated from percentage by rounding up. This cannot be 0. Default value is 1.
        /// </summary>
        [Input("maxUnavailable")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentDeploymentStrategyRollingUpdateMaxUnavailableArgs>? MaxUnavailable { get; set; }

        /// <summary>
        /// SlowStartAdditiveIncrease Value can be an absolute number (ex: 5) or a percentage of total number of DaemonSet pods at the start of the update (ex: 10%). Default value is 5.
        /// </summary>
        [Input("slowStartAdditiveIncrease")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentDeploymentStrategyRollingUpdateSlowStartAdditiveIncreaseArgs>? SlowStartAdditiveIncrease { get; set; }

        /// <summary>
        /// SlowStartIntervalDuration the duration between to 2 Default value is 1min.
        /// </summary>
        [Input("slowStartIntervalDuration")]
        public Input<string>? SlowStartIntervalDuration { get; set; }

        public DatadogAgentSpecAgentDeploymentStrategyRollingUpdateArgs()
        {
        }
    }
}
