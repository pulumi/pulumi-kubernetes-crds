// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.AzureServiceOperator.Azure.V1Alpha1
{
    /// <summary>
    /// KeyVault is the Schema for the keyvaults API
    /// </summary>
    public partial class KeyVault : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// KeyVaultSpec defines the desired state of KeyVault
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Azure.V1Alpha1.KeyVaultSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Azure.V1Alpha1.KeyVaultStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a KeyVault resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public KeyVault(string name, Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1.KeyVaultArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:azure.microsoft.com/v1alpha1:KeyVault", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal KeyVault(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:azure.microsoft.com/v1alpha1:KeyVault", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private KeyVault(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:azure.microsoft.com/v1alpha1:KeyVault", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1.KeyVaultArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1.KeyVaultArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1.KeyVaultArgs();
            args.ApiVersion = "azure.microsoft.com/v1alpha1";
            args.Kind = "KeyVault";
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
        /// Get an existing KeyVault resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static KeyVault Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new KeyVault(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1
{

    public class KeyVaultArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// KeyVaultSpec defines the desired state of KeyVault
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1.KeyVaultSpecArgs>? Spec { get; set; }

        /// <summary>
        /// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1.KeyVaultStatusArgs>? Status { get; set; }

        public KeyVaultArgs()
        {
        }
    }
}