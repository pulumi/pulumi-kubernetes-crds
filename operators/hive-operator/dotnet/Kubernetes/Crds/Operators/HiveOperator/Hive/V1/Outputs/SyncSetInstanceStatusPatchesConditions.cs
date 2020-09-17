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
    public sealed class SyncSetInstanceStatusPatchesConditions
    {
        /// <summary>
        /// LastProbeTime is the last time we probed the condition.
        /// </summary>
        public readonly string LastProbeTime;
        /// <summary>
        /// LastTransitionTime is the last time the condition transitioned from one status to another.
        /// </summary>
        public readonly string LastTransitionTime;
        /// <summary>
        /// Message is a human-readable message indicating details about last transition.
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// Reason is a unique, one-word, CamelCase reason for the condition's last transition.
        /// </summary>
        public readonly string Reason;
        /// <summary>
        /// Status is the status of the condition.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// Type is the type of the condition.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private SyncSetInstanceStatusPatchesConditions(
            string lastProbeTime,

            string lastTransitionTime,

            string message,

            string reason,

            string status,

            string type)
        {
            LastProbeTime = lastProbeTime;
            LastTransitionTime = lastTransitionTime;
            Message = message;
            Reason = reason;
            Status = status;
            Type = type;
        }
    }
}
