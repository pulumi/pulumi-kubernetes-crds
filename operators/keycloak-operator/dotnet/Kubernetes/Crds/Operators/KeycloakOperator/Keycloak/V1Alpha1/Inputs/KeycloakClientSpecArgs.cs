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
    /// KeycloakClientSpec defines the desired state of KeycloakClient.
    /// </summary>
    public class KeycloakClientSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Keycloak Client REST object.
        /// </summary>
        [Input("client", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Keycloak.V1Alpha1.KeycloakClientSpecClientArgs> Client { get; set; } = null!;

        /// <summary>
        /// Selector for looking up KeycloakRealm Custom Resources.
        /// </summary>
        [Input("realmSelector", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Keycloak.V1Alpha1.KeycloakClientSpecRealmSelectorArgs> RealmSelector { get; set; } = null!;

        public KeycloakClientSpecArgs()
        {
        }
    }
}
