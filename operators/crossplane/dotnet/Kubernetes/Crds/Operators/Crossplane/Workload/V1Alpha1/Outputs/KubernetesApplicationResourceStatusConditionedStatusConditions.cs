// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Workload.V1Alpha1
{

    [OutputType]
    public sealed class KubernetesApplicationResourceStatusConditionedStatusConditions
    {
        /// <summary>
        /// LastTransitionTime is the last time this condition transitioned from one status to another.
        /// </summary>
        public readonly string LastTransitionTime;
        /// <summary>
        /// A Message containing details about this condition's last transition from one status to another, if any.
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// A Reason for this condition's last transition from one status to another.
        /// </summary>
        public readonly string Reason;
        /// <summary>
        /// Status of this condition; is it currently True, False, or Unknown?
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// Type of this condition. At most one of each condition type may apply to a resource at any point in time.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private KubernetesApplicationResourceStatusConditionedStatusConditions(
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
