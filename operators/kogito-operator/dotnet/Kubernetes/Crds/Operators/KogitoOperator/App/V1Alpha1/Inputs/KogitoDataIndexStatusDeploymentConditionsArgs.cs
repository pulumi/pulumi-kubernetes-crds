// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.App.V1Alpha1
{

    /// <summary>
    /// DeploymentCondition describes the state of a deployment at a certain point.
    /// </summary>
    public class KogitoDataIndexStatusDeploymentConditionsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Last time the condition transitioned from one status to another.
        /// </summary>
        [Input("lastTransitionTime")]
        public Input<string>? LastTransitionTime { get; set; }

        /// <summary>
        /// The last time this condition was updated.
        /// </summary>
        [Input("lastUpdateTime")]
        public Input<string>? LastUpdateTime { get; set; }

        /// <summary>
        /// A human readable message indicating details about the transition.
        /// </summary>
        [Input("message")]
        public Input<string>? Message { get; set; }

        /// <summary>
        /// The reason for the condition's last transition.
        /// </summary>
        [Input("reason")]
        public Input<string>? Reason { get; set; }

        /// <summary>
        /// Status of the condition, one of True, False, Unknown.
        /// </summary>
        [Input("status", required: true)]
        public Input<string> Status { get; set; } = null!;

        /// <summary>
        /// Type of deployment condition.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public KogitoDataIndexStatusDeploymentConditionsArgs()
        {
        }
    }
}
