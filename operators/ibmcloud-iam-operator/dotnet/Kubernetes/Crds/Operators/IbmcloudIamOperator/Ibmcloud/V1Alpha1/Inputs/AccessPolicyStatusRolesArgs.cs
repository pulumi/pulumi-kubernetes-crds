// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1
{

    public class AccessPolicyStatusRolesArgs : Pulumi.ResourceArgs
    {
        [Input("customRolesDName")]
        private InputList<string>? _customRolesDName;
        public InputList<string> CustomRolesDName
        {
            get => _customRolesDName ?? (_customRolesDName = new InputList<string>());
            set => _customRolesDName = value;
        }

        [Input("customRolesDef")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1.AccessPolicyStatusRolesCustomRolesDefArgs>? _customRolesDef;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1.AccessPolicyStatusRolesCustomRolesDefArgs> CustomRolesDef
        {
            get => _customRolesDef ?? (_customRolesDef = new InputList<Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1.AccessPolicyStatusRolesCustomRolesDefArgs>());
            set => _customRolesDef = value;
        }

        [Input("definedRoles")]
        private InputList<string>? _definedRoles;
        public InputList<string> DefinedRoles
        {
            get => _definedRoles ?? (_definedRoles = new InputList<string>());
            set => _definedRoles = value;
        }

        public AccessPolicyStatusRolesArgs()
        {
        }
    }
}