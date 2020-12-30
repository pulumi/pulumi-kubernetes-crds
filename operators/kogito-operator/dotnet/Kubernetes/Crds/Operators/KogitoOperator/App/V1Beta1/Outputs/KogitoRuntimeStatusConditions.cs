// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.App.V1Beta1
{

    [OutputType]
    public sealed class KogitoRuntimeStatusConditions
    {
        public readonly string LastTransitionTime;
        public readonly string Message;
        /// <summary>
        /// KogitoServiceConditionReason is the type of reason
        /// </summary>
        public readonly string Reason;
        public readonly string Status;
        /// <summary>
        /// ConditionType is the type of condition
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private KogitoRuntimeStatusConditions(
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
