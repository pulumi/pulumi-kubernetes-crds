// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1
{

    [OutputType]
    public sealed class KafkaMirrorMaker2StatusConditions
    {
        /// <summary>
        /// Last time the condition of a type changed from one status to another. The required format is 'yyyy-MM-ddTHH:mm:ssZ', in the UTC time zone.
        /// </summary>
        public readonly string LastTransitionTime;
        /// <summary>
        /// Human-readable message indicating details about the condition's last transition.
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// The reason for the condition's last transition (a single word in CamelCase).
        /// </summary>
        public readonly string Reason;
        /// <summary>
        /// The status of the condition, either True, False or Unknown.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// The unique identifier of a condition, used to distinguish between other conditions in the resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private KafkaMirrorMaker2StatusConditions(
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
