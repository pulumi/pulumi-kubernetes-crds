// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Hive.V1
{

    [OutputType]
    public sealed class ClusterDeploymentStatusClusterVersionStatusConditions
    {
        /// <summary>
        /// lastTransitionTime is the time of the last update to the current status property.
        /// </summary>
        public readonly string LastTransitionTime;
        /// <summary>
        /// message provides additional information about the current condition. This is only to be consumed by humans.
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// reason is the CamelCase reason for the condition's current status.
        /// </summary>
        public readonly string Reason;
        /// <summary>
        /// status of the condition, one of True, False, Unknown.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// type specifies the aspect reported by this condition.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ClusterDeploymentStatusClusterVersionStatusConditions(
            string lastTransitionTime,

            string message,

            string reason,

            string status,

            string type)
        {
            LastTransitionTime = lastTransitionTime;
            Message = message;
            Reason = reason;
            Status = status;
            Type = type;
        }
    }
}
