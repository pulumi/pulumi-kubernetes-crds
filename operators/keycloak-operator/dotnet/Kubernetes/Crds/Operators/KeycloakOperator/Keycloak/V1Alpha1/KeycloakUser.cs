// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.KeycloakOperator.Keycloak.V1Alpha1
{
    /// <summary>
    /// KeycloakUser is the Schema for the keycloakusers API.
    /// </summary>
    public partial class KeycloakUser : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// KeycloakUserSpec defines the desired state of KeycloakUser.
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Keycloak.V1Alpha1.KeycloakUserSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// KeycloakUserStatus defines the observed state of KeycloakUser.
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Keycloak.V1Alpha1.KeycloakUserStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a KeycloakUser resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public KeycloakUser(string name, Pulumi.Kubernetes.Types.Inputs.Keycloak.V1Alpha1.KeycloakUserArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:keycloak.org/v1alpha1:KeycloakUser", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal KeycloakUser(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:keycloak.org/v1alpha1:KeycloakUser", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private KeycloakUser(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:keycloak.org/v1alpha1:KeycloakUser", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Keycloak.V1Alpha1.KeycloakUserArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Keycloak.V1Alpha1.KeycloakUserArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Keycloak.V1Alpha1.KeycloakUserArgs();
            args.ApiVersion = "keycloak.org/v1alpha1";
            args.Kind = "KeycloakUser";
            return args;
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing KeycloakUser resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static KeycloakUser Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new KeycloakUser(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Keycloak.V1Alpha1
{

    public class KeycloakUserArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// KeycloakUserSpec defines the desired state of KeycloakUser.
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Keycloak.V1Alpha1.KeycloakUserSpecArgs>? Spec { get; set; }

        /// <summary>
        /// KeycloakUserStatus defines the observed state of KeycloakUser.
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Keycloak.V1Alpha1.KeycloakUserStatusArgs>? Status { get; set; }

        public KeycloakUserArgs()
        {
        }
    }
}
