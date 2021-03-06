// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1
{

    /// <summary>
    /// Condition represents an observation of an object's state. Conditions are an extension mechanism intended to be used when the details of an observation are not a priori known or would not apply to all instances of a given Kind. 
    ///  Conditions should be added to explicitly convey properties that users and components care about rather than requiring those properties to be inferred from other observations. Once defined, the meaning of a Condition can not be changed arbitrarily - it becomes part of the API, and has the same backwards- and forwards-compatibility concerns of any other part of the API.
    /// </summary>
    public class ResourceLockerStatusLockedResourceStatusesArgs : Pulumi.ResourceArgs
    {
        [Input("lastTransitionTime")]
        public Input<string>? LastTransitionTime { get; set; }

        [Input("message")]
        public Input<string>? Message { get; set; }

        /// <summary>
        /// ConditionReason is intended to be a one-word, CamelCase representation of the category of cause of the current status. It is intended to be used in concise output, such as one-line kubectl get output, and in summarizing occurrences of causes.
        /// </summary>
        [Input("reason")]
        public Input<string>? Reason { get; set; }

        [Input("status", required: true)]
        public Input<string> Status { get; set; } = null!;

        /// <summary>
        /// ConditionType is the type of the condition and is typically a CamelCased word or short phrase. 
        ///  Condition types should indicate state in the "abnormal-true" polarity. For example, if the condition indicates when a policy is invalid, the "is valid" case is probably the norm, so the condition should be called "Invalid".
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ResourceLockerStatusLockedResourceStatusesArgs()
        {
        }
    }
}
