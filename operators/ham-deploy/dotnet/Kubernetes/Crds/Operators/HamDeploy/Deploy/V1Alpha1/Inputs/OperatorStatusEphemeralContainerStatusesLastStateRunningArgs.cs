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
    /// Details about a running container
    /// </summary>
    public class OperatorStatusEphemeralContainerStatusesLastStateRunningArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Time at which the container was last (re-)started
        /// </summary>
        [Input("startedAt")]
        public Input<string>? StartedAt { get; set; }

        public OperatorStatusEphemeralContainerStatusesLastStateRunningArgs()
        {
        }
    }
}
