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
    public sealed class OperatorStatusContainerStatusesState
    {
        /// <summary>
        /// Details about a running container
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorStatusContainerStatusesStateRunning Running;
        /// <summary>
        /// Details about a terminated container
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorStatusContainerStatusesStateTerminated Terminated;
        /// <summary>
        /// Details about a waiting container
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorStatusContainerStatusesStateWaiting Waiting;

        [OutputConstructor]
        private OperatorStatusContainerStatusesState(
            Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorStatusContainerStatusesStateRunning running,

            Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorStatusContainerStatusesStateTerminated terminated,

            Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorStatusContainerStatusesStateWaiting waiting)
        {
            Running = running;
            Terminated = terminated;
            Waiting = waiting;
        }
    }
}
