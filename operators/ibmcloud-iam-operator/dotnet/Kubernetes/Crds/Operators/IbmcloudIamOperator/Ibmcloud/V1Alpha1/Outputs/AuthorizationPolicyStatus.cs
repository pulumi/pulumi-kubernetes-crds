// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Ibmcloud.V1Alpha1
{

    [OutputType]
    public sealed class AuthorizationPolicyStatus
    {
        public readonly string Message;
        public readonly string PolicyID;
        public readonly ImmutableArray<string> Roles;
        public readonly Pulumi.Kubernetes.Types.Outputs.Ibmcloud.V1Alpha1.AuthorizationPolicyStatusSource Source;
        public readonly string State;
        public readonly Pulumi.Kubernetes.Types.Outputs.Ibmcloud.V1Alpha1.AuthorizationPolicyStatusTarget Target;

        [OutputConstructor]
        private AuthorizationPolicyStatus(
            string message,

            string policyID,

            ImmutableArray<string> roles,

            Pulumi.Kubernetes.Types.Outputs.Ibmcloud.V1Alpha1.AuthorizationPolicyStatusSource source,

            string state,

            Pulumi.Kubernetes.Types.Outputs.Ibmcloud.V1Alpha1.AuthorizationPolicyStatusTarget target)
        {
            Message = message;
            PolicyID = policyID;
            Roles = roles;
            Source = source;
            State = state;
            Target = target;
        }
    }
}
