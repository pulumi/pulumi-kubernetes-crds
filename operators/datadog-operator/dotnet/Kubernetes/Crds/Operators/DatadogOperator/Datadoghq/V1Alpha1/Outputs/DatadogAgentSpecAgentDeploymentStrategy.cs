// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1
{

    [OutputType]
    public sealed class DatadogAgentSpecAgentDeploymentStrategy
    {
        /// <summary>
        /// Configure the canary deployment configuration using ExtendedDaemonSet
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentDeploymentStrategyCanary Canary;
        /// <summary>
        /// The reconcile frequency of the ExtendDaemonSet
        /// </summary>
        public readonly string ReconcileFrequency;
        /// <summary>
        /// Configure the rolling updater strategy of the DaemonSet or the ExtendedDaemonSet
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentDeploymentStrategyRollingUpdate RollingUpdate;
        /// <summary>
        /// The update strategy used for the DaemonSet
        /// </summary>
        public readonly string UpdateStrategyType;

        [OutputConstructor]
        private DatadogAgentSpecAgentDeploymentStrategy(
            Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentDeploymentStrategyCanary canary,

            string reconcileFrequency,

            Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentDeploymentStrategyRollingUpdate rollingUpdate,

            string updateStrategyType)
        {
            Canary = canary;
            ReconcileFrequency = reconcileFrequency;
            RollingUpdate = rollingUpdate;
            UpdateStrategyType = updateStrategyType;
        }
    }
}