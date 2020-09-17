// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    /// <summary>
    /// ProjectRole represents a role that has access to a project
    /// </summary>
    public class AppProjectSpecRolesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description is a description of the role
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("groups")]
        private InputList<string>? _groups;

        /// <summary>
        /// Groups are a list of OIDC group claims bound to this role
        /// </summary>
        public InputList<string> Groups
        {
            get => _groups ?? (_groups = new InputList<string>());
            set => _groups = value;
        }

        [Input("jwtTokens")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.AppProjectSpecRolesJwtTokensArgs>? _jwtTokens;

        /// <summary>
        /// JWTTokens are a list of generated JWT tokens bound to this role
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.AppProjectSpecRolesJwtTokensArgs> JwtTokens
        {
            get => _jwtTokens ?? (_jwtTokens = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.AppProjectSpecRolesJwtTokensArgs>());
            set => _jwtTokens = value;
        }

        /// <summary>
        /// Name is a name for this role
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("policies")]
        private InputList<string>? _policies;

        /// <summary>
        /// Policies Stores a list of casbin formated strings that define access policies for the role in the project
        /// </summary>
        public InputList<string> Policies
        {
            get => _policies ?? (_policies = new InputList<string>());
            set => _policies = value;
        }

        public AppProjectSpecRolesArgs()
        {
        }
    }
}