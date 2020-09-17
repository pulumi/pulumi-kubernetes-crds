// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1
{

    [OutputType]
    public sealed class KogitoMgmtConsoleStatusDeploymentConditions
    {
        /// <summary>
        /// Last time the condition transitioned from one status to another.
        /// </summary>
        public readonly string LastTransitionTime;
        /// <summary>
        /// The last time this condition was updated.
        /// </summary>
        public readonly string LastUpdateTime;
        /// <summary>
        /// A human readable message indicating details about the transition.
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// The reason for the condition's last transition.
        /// </summary>
        public readonly string Reason;
        /// <summary>
        /// Status of the condition, one of True, False, Unknown.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// Type of deployment condition.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private KogitoMgmtConsoleStatusDeploymentConditions(
            string lastTransitionTime,

            string lastUpdateTime,

            string message,

            string reason,

            string status,

            string type)
        {
            LastTransitionTime = lastTransitionTime;
            LastUpdateTime = lastUpdateTime;
            Message = message;
            Reason = reason;
            Status = status;
            Type = type;
        }
    }
}
