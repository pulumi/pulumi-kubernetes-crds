// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.3scaleCommunityOperator.Capabilities.V1Alpha1
{
    public partial class Binding : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Capabilities.V1Alpha1.BindingSpec> Spec { get; private set; } = null!;

        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Capabilities.V1Alpha1.BindingStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a Binding resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Binding(string name, Pulumi.Kubernetes.Types.Inputs.Capabilities.V1Alpha1.BindingArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:capabilities.3scale.net/v1alpha1:Binding", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal Binding(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:capabilities.3scale.net/v1alpha1:Binding", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private Binding(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:capabilities.3scale.net/v1alpha1:Binding", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Capabilities.V1Alpha1.BindingArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Capabilities.V1Alpha1.BindingArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Capabilities.V1Alpha1.BindingArgs();
            args.ApiVersion = "capabilities.3scale.net/v1alpha1";
            args.Kind = "Binding";
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
        /// Get an existing Binding resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Binding Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Binding(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Capabilities.V1Alpha1
{

    public class BindingArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Capabilities.V1Alpha1.BindingSpecArgs>? Spec { get; set; }

        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Capabilities.V1Alpha1.BindingStatusArgs>? Status { get; set; }

        public BindingArgs()
        {
        }
    }
}