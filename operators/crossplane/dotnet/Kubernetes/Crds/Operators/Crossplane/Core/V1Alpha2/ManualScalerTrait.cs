// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.Crossplane.Core.V1Alpha2
{
    /// <summary>
    /// A ManualScalerTrait determines how many replicas a workload should have.
    /// </summary>
    public partial class ManualScalerTrait : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// A ManualScalerTraitSpec defines the desired state of a ManualScalerTrait.
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ManualScalerTraitSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// A ManualScalerTraitStatus represents the observed state of a ManualScalerTrait.
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ManualScalerTraitStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a ManualScalerTrait resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ManualScalerTrait(string name, Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ManualScalerTraitArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:core.oam.dev/v1alpha2:ManualScalerTrait", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal ManualScalerTrait(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:core.oam.dev/v1alpha2:ManualScalerTrait", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private ManualScalerTrait(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:core.oam.dev/v1alpha2:ManualScalerTrait", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ManualScalerTraitArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ManualScalerTraitArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ManualScalerTraitArgs();
            args.ApiVersion = "core.oam.dev/v1alpha2";
            args.Kind = "ManualScalerTrait";
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
        /// Get an existing ManualScalerTrait resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ManualScalerTrait Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ManualScalerTrait(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2
{

    public class ManualScalerTraitArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// A ManualScalerTraitSpec defines the desired state of a ManualScalerTrait.
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ManualScalerTraitSpecArgs>? Spec { get; set; }

        /// <summary>
        /// A ManualScalerTraitStatus represents the observed state of a ManualScalerTrait.
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ManualScalerTraitStatusArgs>? Status { get; set; }

        public ManualScalerTraitArgs()
        {
        }
    }
}