// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Hive.V1
{

    /// <summary>
    /// ClusterOperatorStatusCondition represents the state of the operator's managed and monitored components.
    /// </summary>
    public class ClusterStateStatusClusterOperatorsConditionsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// lastTransitionTime is the time of the last update to the current status property.
        /// </summary>
        [Input("lastTransitionTime", required: true)]
        public Input<string> LastTransitionTime { get; set; } = null!;

        /// <summary>
        /// message provides additional information about the current condition. This is only to be consumed by humans.
        /// </summary>
        [Input("message")]
        public Input<string>? Message { get; set; }

        /// <summary>
        /// reason is the CamelCase reason for the condition's current status.
        /// </summary>
        [Input("reason")]
        public Input<string>? Reason { get; set; }

        /// <summary>
        /// status of the condition, one of True, False, Unknown.
        /// </summary>
        [Input("status", required: true)]
        public Input<string> Status { get; set; } = null!;

        /// <summary>
        /// type specifies the aspect reported by this condition.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ClusterStateStatusClusterOperatorsConditionsArgs()
        {
        }
    }
}
