// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.MustGatherOperator.Redhatcop.V1Alpha1
{
    /// <summary>
    /// MustGather is the Schema for the mustgathers API
    /// </summary>
    public partial class MustGather : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// MustGatherSpec defines the desired state of MustGather
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.MustGatherSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// MustGatherStatus defines the observed state of MustGather
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.MustGatherStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a MustGather resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MustGather(string name, Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.MustGatherArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:redhatcop.redhat.io/v1alpha1:MustGather", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal MustGather(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:redhatcop.redhat.io/v1alpha1:MustGather", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private MustGather(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:redhatcop.redhat.io/v1alpha1:MustGather", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.MustGatherArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.MustGatherArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.MustGatherArgs();
            args.ApiVersion = "redhatcop.redhat.io/v1alpha1";
            args.Kind = "MustGather";
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
        /// Get an existing MustGather resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MustGather Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new MustGather(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1
{

    public class MustGatherArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// MustGatherSpec defines the desired state of MustGather
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.MustGatherSpecArgs>? Spec { get; set; }

        /// <summary>
        /// MustGatherStatus defines the observed state of MustGather
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.MustGatherStatusArgs>? Status { get; set; }

        public MustGatherArgs()
        {
        }
    }
}
