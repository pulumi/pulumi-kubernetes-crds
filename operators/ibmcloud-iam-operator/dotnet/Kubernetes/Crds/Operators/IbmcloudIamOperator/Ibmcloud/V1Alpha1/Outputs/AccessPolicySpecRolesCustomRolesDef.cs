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
    public sealed class AccessPolicySpecRolesCustomRolesDef
    {
        public readonly string CustomRoleName;
        public readonly string CustomRoleNamespace;

        [OutputConstructor]
        private AccessPolicySpecRolesCustomRolesDef(
            string customRoleName,

            string customRoleNamespace)
        {
            CustomRoleName = customRoleName;
            CustomRoleNamespace = customRoleNamespace;
        }
    }
}