// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Submariner.V1Alpha1
{

    [OutputType]
    public sealed class SubmarinerStatusRouteAgentDaemonSetStatusNonReadyContainerStates
    {
        /// <summary>
        /// Details about a running container
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Submariner.V1Alpha1.SubmarinerStatusRouteAgentDaemonSetStatusNonReadyContainerStatesRunning Running;
        /// <summary>
        /// Details about a terminated container
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Submariner.V1Alpha1.SubmarinerStatusRouteAgentDaemonSetStatusNonReadyContainerStatesTerminated Terminated;
        /// <summary>
        /// Details about a waiting container
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Submariner.V1Alpha1.SubmarinerStatusRouteAgentDaemonSetStatusNonReadyContainerStatesWaiting Waiting;

        [OutputConstructor]
        private SubmarinerStatusRouteAgentDaemonSetStatusNonReadyContainerStates(
            Pulumi.Kubernetes.Types.Outputs.Submariner.V1Alpha1.SubmarinerStatusRouteAgentDaemonSetStatusNonReadyContainerStatesRunning running,

            Pulumi.Kubernetes.Types.Outputs.Submariner.V1Alpha1.SubmarinerStatusRouteAgentDaemonSetStatusNonReadyContainerStatesTerminated terminated,

            Pulumi.Kubernetes.Types.Outputs.Submariner.V1Alpha1.SubmarinerStatusRouteAgentDaemonSetStatusNonReadyContainerStatesWaiting waiting)
        {
            Running = running;
            Terminated = terminated;
            Waiting = waiting;
        }
    }
}
