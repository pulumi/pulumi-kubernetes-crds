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
    public sealed class AccessPolicyStatusSubjectAccessGroupDef
    {
        public readonly string AccessGroupName;
        public readonly string AccessGroupNamespace;

        [OutputConstructor]
        private AccessPolicyStatusSubjectAccessGroupDef(
            string accessGroupName,

            string accessGroupNamespace)
        {
            AccessGroupName = accessGroupName;
            AccessGroupNamespace = accessGroupNamespace;
        }
    }
}