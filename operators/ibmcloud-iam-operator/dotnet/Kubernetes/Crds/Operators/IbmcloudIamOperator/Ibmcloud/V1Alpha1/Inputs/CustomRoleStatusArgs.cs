// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1
{

    /// <summary>
    /// CustomRoleStatus defines the observed state of CustomRole
    /// </summary>
    public class CustomRoleStatusArgs : Pulumi.ResourceArgs
    {
        [Input("actions")]
        private InputList<string>? _actions;
        public InputList<string> Actions
        {
            get => _actions ?? (_actions = new InputList<string>());
            set => _actions = value;
        }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        [Input("message")]
        public Input<string>? Message { get; set; }

        [Input("roleCRN")]
        public Input<string>? RoleCRN { get; set; }

        [Input("roleID")]
        public Input<string>? RoleID { get; set; }

        [Input("roleName")]
        public Input<string>? RoleName { get; set; }

        [Input("serviceClass")]
        public Input<string>? ServiceClass { get; set; }

        [Input("state")]
        public Input<string>? State { get; set; }

        public CustomRoleStatusArgs()
        {
        }
    }
}
