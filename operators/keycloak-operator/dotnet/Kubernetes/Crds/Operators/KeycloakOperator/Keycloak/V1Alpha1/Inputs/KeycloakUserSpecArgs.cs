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
    /// KeycloakUserSpec defines the desired state of KeycloakUser.
    /// </summary>
    public class KeycloakUserSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Selector for looking up KeycloakRealm Custom Resources.
        /// </summary>
        [Input("realmSelector")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Keycloak.V1Alpha1.KeycloakUserSpecRealmSelectorArgs>? RealmSelector { get; set; }

        /// <summary>
        /// Keycloak User REST object.
        /// </summary>
        [Input("user", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Keycloak.V1Alpha1.KeycloakUserSpecUserArgs> User { get; set; } = null!;

        public KeycloakUserSpecArgs()
        {
        }
    }
}
