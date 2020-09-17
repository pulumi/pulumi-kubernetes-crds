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
    public sealed class OperatorStatusInitContainerStatusesStateTerminated
    {
        /// <summary>
        /// Container's ID in the format 'docker://&lt;container_id&gt;'
        /// </summary>
        public readonly string ContainerID;
        /// <summary>
        /// Exit status from the last termination of the container
        /// </summary>
        public readonly int ExitCode;
        /// <summary>
        /// Time at which the container last terminated
        /// </summary>
        public readonly string FinishedAt;
        /// <summary>
        /// Message regarding the last termination of the container
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// (brief) reason from the last termination of the container
        /// </summary>
        public readonly string Reason;
        /// <summary>
        /// Signal from the last termination of the container
        /// </summary>
        public readonly int Signal;
        /// <summary>
        /// Time at which previous execution of the container started
        /// </summary>
        public readonly string StartedAt;

        [OutputConstructor]
        private OperatorStatusInitContainerStatusesStateTerminated(
            string containerID,

            int exitCode,

            string finishedAt,

            string message,

            string reason,

            int signal,

            string startedAt)
        {
            ContainerID = containerID;
            ExitCode = exitCode;
            FinishedAt = finishedAt;
            Message = message;
            Reason = reason;
            Signal = signal;
            StartedAt = startedAt;
        }
    }
}
