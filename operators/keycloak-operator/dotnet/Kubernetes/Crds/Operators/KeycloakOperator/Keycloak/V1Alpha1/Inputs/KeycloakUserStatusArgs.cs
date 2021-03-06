// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Keycloak.V1Alpha1
{

    /// <summary>
    /// KeycloakUserStatus defines the observed state of KeycloakUser.
    /// </summary>
    public class KeycloakUserStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Human-readable message indicating details about current operator phase or error.
        /// </summary>
        [Input("message", required: true)]
        public Input<string> Message { get; set; } = null!;

        /// <summary>
        /// Current phase of the operator.
        /// </summary>
        [Input("phase", required: true)]
        public Input<string> Phase { get; set; } = null!;

        public KeycloakUserStatusArgs()
        {
        }
    }
}
