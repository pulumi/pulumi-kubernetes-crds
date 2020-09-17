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
    /// KeycloakRealmSpec defines the desired state of KeycloakRealm.
    /// </summary>
    public class KeycloakRealmSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Selector for looking up Keycloak Custom Resources.
        /// </summary>
        [Input("instanceSelector")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Keycloak.V1Alpha1.KeycloakRealmSpecInstanceSelectorArgs>? InstanceSelector { get; set; }

        /// <summary>
        /// Keycloak Realm REST object.
        /// </summary>
        [Input("realm", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Keycloak.V1Alpha1.KeycloakRealmSpecRealmArgs> Realm { get; set; } = null!;

        [Input("realmOverrides")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Keycloak.V1Alpha1.KeycloakRealmSpecRealmOverridesArgs>? _realmOverrides;

        /// <summary>
        /// A list of overrides to the default Realm behavior.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Keycloak.V1Alpha1.KeycloakRealmSpecRealmOverridesArgs> RealmOverrides
        {
            get => _realmOverrides ?? (_realmOverrides = new InputList<Pulumi.Kubernetes.Types.Inputs.Keycloak.V1Alpha1.KeycloakRealmSpecRealmOverridesArgs>());
            set => _realmOverrides = value;
        }

        public KeycloakRealmSpecArgs()
        {
        }
    }
}