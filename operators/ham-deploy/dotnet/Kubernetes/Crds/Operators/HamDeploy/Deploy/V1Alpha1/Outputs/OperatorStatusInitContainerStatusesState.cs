// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1
{

    [OutputType]
    public sealed class OperatorStatusInitContainerStatusesState
    {
        /// <summary>
        /// Details about a running container
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorStatusInitContainerStatusesStateRunning Running;
        /// <summary>
        /// Details about a terminated container
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorStatusInitContainerStatusesStateTerminated Terminated;
        /// <summary>
        /// Details about a waiting container
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorStatusInitContainerStatusesStateWaiting Waiting;

        [OutputConstructor]
        private OperatorStatusInitContainerStatusesState(
            Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorStatusInitContainerStatusesStateRunning running,

            Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorStatusInitContainerStatusesStateTerminated terminated,

            Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorStatusInitContainerStatusesStateWaiting waiting)
        {
            Running = running;
            Terminated = terminated;
            Waiting = waiting;
        }
    }
}
