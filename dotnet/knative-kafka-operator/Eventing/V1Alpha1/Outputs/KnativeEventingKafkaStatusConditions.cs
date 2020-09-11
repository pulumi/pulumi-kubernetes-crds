// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Eventing.V1Alpha1
{

    [OutputType]
    public sealed class KnativeEventingKafkaStatusConditions
    {
        /// <summary>
        /// LastTransitionTime is the last time the condition transitioned from one status to another. We use VolatileTime in place of metav1.Time to exclude this from creating equality.Semantic differences (all other things held constant).
        /// </summary>
        public readonly string LastTransitionTime;
        /// <summary>
        /// A human readable message indicating details about the transition.
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// The reason for the condition's last transition.
        /// </summary>
        public readonly string Reason;
        /// <summary>
        /// Severity with which to treat failures of this type of condition. When this is not specified, it defaults to Error.
        /// </summary>
        public readonly string Severity;
        /// <summary>
        /// Status of the condition, one of True, False, Unknown. +required
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// Type of condition. +required
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private KnativeEventingKafkaStatusConditions(
            string lastTransitionTime,

            string message,

            string reason,

            string severity,

            string status,

            string type)
        {
            LastTransitionTime = lastTransitionTime;
            Message = message;
            Reason = reason;
            Severity = severity;
            Status = status;
            Type = type;
        }
    }
}
