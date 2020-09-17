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
    public sealed class OperatorStatusContainerStatusesLastState
    {
        /// <summary>
        /// Details about a running container
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorStatusContainerStatusesLastStateRunning Running;
        /// <summary>
        /// Details about a terminated container
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorStatusContainerStatusesLastStateTerminated Terminated;
        /// <summary>
        /// Details about a waiting container
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorStatusContainerStatusesLastStateWaiting Waiting;

        [OutputConstructor]
        private OperatorStatusContainerStatusesLastState(
            Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorStatusContainerStatusesLastStateRunning running,

            Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorStatusContainerStatusesLastStateTerminated terminated,

            Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorStatusContainerStatusesLastStateWaiting waiting)
        {
            Running = running;
            Terminated = terminated;
            Waiting = waiting;
        }
    }
}
