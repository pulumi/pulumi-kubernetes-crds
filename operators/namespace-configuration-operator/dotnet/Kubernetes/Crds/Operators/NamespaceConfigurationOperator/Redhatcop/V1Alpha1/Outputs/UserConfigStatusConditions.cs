// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1
{

    [OutputType]
    public sealed class UserConfigStatusConditions
    {
        public readonly string LastTransitionTime;
        public readonly string Message;
        /// <summary>
        /// ConditionReason is intended to be a one-word, CamelCase representation of the category of cause of the current status. It is intended to be used in concise output, such as one-line kubectl get output, and in summarizing occurrences of causes.
        /// </summary>
        public readonly string Reason;
        public readonly string Status;
        /// <summary>
        /// ConditionType is the type of the condition and is typically a CamelCased word or short phrase. 
        ///  Condition types should indicate state in the "abnormal-true" polarity. For example, if the condition indicates when a policy is invalid, the "is valid" case is probably the norm, so the condition should be called "Invalid".
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private UserConfigStatusConditions(
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
