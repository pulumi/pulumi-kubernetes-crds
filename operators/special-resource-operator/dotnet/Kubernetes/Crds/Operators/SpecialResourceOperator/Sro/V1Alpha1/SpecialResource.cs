// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.SpecialResourceOperator.Sro.V1Alpha1
{
    /// <summary>
    /// SpecialResource is the Schema for the specialresources API
    /// </summary>
    public partial class SpecialResource : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// SpecialResourceSpec defines the desired state of SpecialResource
        /// </summary>
        [Output("spec")]
        public Output<ImmutableDictionary<string, object>> Spec { get; private set; } = null!;

        /// <summary>
        /// SpecialResourceStatus defines the observed state of SpecialResource
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Sro.V1Alpha1.SpecialResourceStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a SpecialResource resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SpecialResource(string name, Pulumi.Kubernetes.Types.Inputs.Sro.V1Alpha1.SpecialResourceArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:sro.openshift.io/v1alpha1:SpecialResource", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal SpecialResource(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:sro.openshift.io/v1alpha1:SpecialResource", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private SpecialResource(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:sro.openshift.io/v1alpha1:SpecialResource", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Sro.V1Alpha1.SpecialResourceArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Sro.V1Alpha1.SpecialResourceArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Sro.V1Alpha1.SpecialResourceArgs();
            args.ApiVersion = "sro.openshift.io/v1alpha1";
            args.Kind = "SpecialResource";
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
        /// Get an existing SpecialResource resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SpecialResource Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new SpecialResource(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Sro.V1Alpha1
{

    public class SpecialResourceArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        [Input("spec")]
        private InputMap<object>? _spec;

        /// <summary>
        /// SpecialResourceSpec defines the desired state of SpecialResource
        /// </summary>
        public InputMap<object> Spec
        {
            get => _spec ?? (_spec = new InputMap<object>());
            set => _spec = value;
        }

        /// <summary>
        /// SpecialResourceStatus defines the observed state of SpecialResource
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Sro.V1Alpha1.SpecialResourceStatusArgs>? Status { get; set; }

        public SpecialResourceArgs()
        {
        }
    }
}
