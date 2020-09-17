// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Deploy.V1Alpha1
{

    /// <summary>
    /// Details about a terminated container
    /// </summary>
    public class OperatorStatusContainerStatusesStateTerminatedArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Container's ID in the format 'docker://&lt;container_id&gt;'
        /// </summary>
        [Input("containerID")]
        public Input<string>? ContainerID { get; set; }

        /// <summary>
        /// Exit status from the last termination of the container
        /// </summary>
        [Input("exitCode", required: true)]
        public Input<int> ExitCode { get; set; } = null!;

        /// <summary>
        /// Time at which the container last terminated
        /// </summary>
        [Input("finishedAt")]
        public Input<string>? FinishedAt { get; set; }

        /// <summary>
        /// Message regarding the last termination of the container
        /// </summary>
        [Input("message")]
        public Input<string>? Message { get; set; }

        /// <summary>
        /// (brief) reason from the last termination of the container
        /// </summary>
        [Input("reason")]
        public Input<string>? Reason { get; set; }

        /// <summary>
        /// Signal from the last termination of the container
        /// </summary>
        [Input("signal")]
        public Input<int>? Signal { get; set; }

        /// <summary>
        /// Time at which previous execution of the container started
        /// </summary>
        [Input("startedAt")]
        public Input<string>? StartedAt { get; set; }

        public OperatorStatusContainerStatusesStateTerminatedArgs()
        {
        }
    }
}
