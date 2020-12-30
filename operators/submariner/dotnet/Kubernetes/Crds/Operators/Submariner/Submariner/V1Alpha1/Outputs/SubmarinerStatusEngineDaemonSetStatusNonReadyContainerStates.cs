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
    public sealed class SubmarinerStatusEngineDaemonSetStatusNonReadyContainerStates
    {
        /// <summary>
        /// Details about a running container
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Submariner.V1Alpha1.SubmarinerStatusEngineDaemonSetStatusNonReadyContainerStatesRunning Running;
        /// <summary>
        /// Details about a terminated container
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Submariner.V1Alpha1.SubmarinerStatusEngineDaemonSetStatusNonReadyContainerStatesTerminated Terminated;
        /// <summary>
        /// Details about a waiting container
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Submariner.V1Alpha1.SubmarinerStatusEngineDaemonSetStatusNonReadyContainerStatesWaiting Waiting;

        [OutputConstructor]
        private SubmarinerStatusEngineDaemonSetStatusNonReadyContainerStates(
            Pulumi.Kubernetes.Types.Outputs.Submariner.V1Alpha1.SubmarinerStatusEngineDaemonSetStatusNonReadyContainerStatesRunning running,

            Pulumi.Kubernetes.Types.Outputs.Submariner.V1Alpha1.SubmarinerStatusEngineDaemonSetStatusNonReadyContainerStatesTerminated terminated,

            Pulumi.Kubernetes.Types.Outputs.Submariner.V1Alpha1.SubmarinerStatusEngineDaemonSetStatusNonReadyContainerStatesWaiting waiting)
        {
            Running = running;
            Terminated = terminated;
            Waiting = waiting;
        }
    }
}