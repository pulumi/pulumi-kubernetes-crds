// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Keycloak.V1Alpha1
{

    public class KeycloakRealmSpecRealmUsersCredentialsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// True if this credential object is temporary.
        /// </summary>
        [Input("temporary")]
        public Input<bool>? Temporary { get; set; }

        /// <summary>
        /// Credential Type.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// Credential Value.
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public KeycloakRealmSpecRealmUsersCredentialsArgs()
        {
        }
    }
}
