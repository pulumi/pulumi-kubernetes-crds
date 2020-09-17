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
    /// ClusterPoolCondition contains details for the current condition of a cluster pool
    /// </summary>
    public class ClusterPoolStatusConditionsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// LastProbeTime is the last time we probed the condition.
        /// </summary>
        [Input("lastProbeTime")]
        public Input<string>? LastProbeTime { get; set; }

        /// <summary>
        /// LastTransitionTime is the last time the condition transitioned from one status to another.
        /// </summary>
        [Input("lastTransitionTime")]
        public Input<string>? LastTransitionTime { get; set; }

        /// <summary>
        /// Message is a human-readable message indicating details about last transition.
        /// </summary>
        [Input("message")]
        public Input<string>? Message { get; set; }

        /// <summary>
        /// Reason is a unique, one-word, CamelCase reason for the condition's last transition.
        /// </summary>
        [Input("reason")]
        public Input<string>? Reason { get; set; }

        /// <summary>
        /// Status is the status of the condition.
        /// </summary>
        [Input("status", required: true)]
        public Input<string> Status { get; set; } = null!;

        /// <summary>
        /// Type is the type of the condition.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ClusterPoolStatusConditionsArgs()
        {
        }
    }
}