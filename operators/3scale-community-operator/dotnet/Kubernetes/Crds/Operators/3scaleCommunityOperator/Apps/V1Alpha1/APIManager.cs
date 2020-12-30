// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.3scaleCommunityOperator.Apps.V1Alpha1
{
    /// <summary>
    /// APIManager is the Schema for the apimanagers API
    /// </summary>
    public partial class APIManager : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// APIManagerSpec defines the desired state of APIManager
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// APIManagerStatus defines the observed state of APIManager
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a APIManager resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public APIManager(string name, Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:apps.3scale.net/v1alpha1:APIManager", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal APIManager(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:apps.3scale.net/v1alpha1:APIManager", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private APIManager(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:apps.3scale.net/v1alpha1:APIManager", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerArgs();
            args.ApiVersion = "apps.3scale.net/v1alpha1";
            args.Kind = "APIManager";
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
        /// Get an existing APIManager resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static APIManager Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new APIManager(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1
{

    public class APIManagerArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// APIManagerSpec defines the desired state of APIManager
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecArgs>? Spec { get; set; }

        /// <summary>
        /// APIManagerStatus defines the observed state of APIManager
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerStatusArgs>? Status { get; set; }

        public APIManagerArgs()
        {
        }
    }
}
