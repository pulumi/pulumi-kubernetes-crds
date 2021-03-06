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
    /// Update strategy configuration for the DaemonSet
    /// </summary>
    public class DatadogAgentSpecAgentDeploymentStrategyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configure the canary deployment configuration using ExtendedDaemonSet
        /// </summary>
        [Input("canary")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentDeploymentStrategyCanaryArgs>? Canary { get; set; }

        /// <summary>
        /// The reconcile frequency of the ExtendDaemonSet
        /// </summary>
        [Input("reconcileFrequency")]
        public Input<string>? ReconcileFrequency { get; set; }

        /// <summary>
        /// Configure the rolling updater strategy of the DaemonSet or the ExtendedDaemonSet
        /// </summary>
        [Input("rollingUpdate")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentDeploymentStrategyRollingUpdateArgs>? RollingUpdate { get; set; }

        /// <summary>
        /// The update strategy used for the DaemonSet
        /// </summary>
        [Input("updateStrategyType")]
        public Input<string>? UpdateStrategyType { get; set; }

        public DatadogAgentSpecAgentDeploymentStrategyArgs()
        {
        }
    }
}
