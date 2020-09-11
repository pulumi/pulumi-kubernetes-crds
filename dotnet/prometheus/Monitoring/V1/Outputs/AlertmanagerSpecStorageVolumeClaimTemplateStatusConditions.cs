// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1
{

    [OutputType]
    public sealed class AlertmanagerSpecStorageVolumeClaimTemplateStatusConditions
    {
        /// <summary>
        /// Last time we probed the condition.
        /// </summary>
        public readonly string LastProbeTime;
        /// <summary>
        /// Last time the condition transitioned from one status to another.
        /// </summary>
        public readonly string LastTransitionTime;
        /// <summary>
        /// Human-readable message indicating details about last transition.
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// Unique, this should be a short, machine understandable string that gives the reason for condition's last transition. If it reports "ResizeStarted" that means the underlying persistent volume is being resized.
        /// </summary>
        public readonly string Reason;
        public readonly string Status;
        /// <summary>
        /// PersistentVolumeClaimConditionType is a valid value of PersistentVolumeClaimCondition.Type
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private AlertmanagerSpecStorageVolumeClaimTemplateStatusConditions(
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
