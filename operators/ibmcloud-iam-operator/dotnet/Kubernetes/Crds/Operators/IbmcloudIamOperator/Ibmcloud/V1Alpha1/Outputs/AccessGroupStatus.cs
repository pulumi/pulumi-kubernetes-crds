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
    public sealed class AccessGroupStatus
    {
        public readonly string GroupID;
        public readonly string Description;
        public readonly string Message;
        public readonly string Name;
        public readonly ImmutableArray<string> ServiceIDs;
        public readonly string State;
        public readonly ImmutableArray<string> UserEmails;

        [OutputConstructor]
        private AccessGroupStatus(
            string GroupID,

            string description,

            string message,

            string name,

            ImmutableArray<string> serviceIDs,

            string state,

            ImmutableArray<string> userEmails)
        {
            this.GroupID = GroupID;
            Description = description;
            Message = message;
            Name = name;
            ServiceIDs = serviceIDs;
            State = state;
            UserEmails = userEmails;
        }
    }
}
