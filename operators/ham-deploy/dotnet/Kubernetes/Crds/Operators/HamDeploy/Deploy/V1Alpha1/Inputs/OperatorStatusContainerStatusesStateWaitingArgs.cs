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
    /// Details about a waiting container
    /// </summary>
    public class OperatorStatusContainerStatusesStateWaitingArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Message regarding why the container is not yet running.
        /// </summary>
        [Input("message")]
        public Input<string>? Message { get; set; }

        /// <summary>
        /// (brief) reason the container is not yet running.
        /// </summary>
        [Input("reason")]
        public Input<string>? Reason { get; set; }

        public OperatorStatusContainerStatusesStateWaitingArgs()
        {
        }
    }
}
