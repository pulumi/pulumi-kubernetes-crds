// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.Kubefed.Core.V1Alpha1
{
    public partial class PropagatedVersion : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.PropagatedVersionStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a PropagatedVersion resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public PropagatedVersion(string name, Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha1.PropagatedVersionArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:core.kubefed.io/v1alpha1:PropagatedVersion", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal PropagatedVersion(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:core.kubefed.io/v1alpha1:PropagatedVersion", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private PropagatedVersion(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:core.kubefed.io/v1alpha1:PropagatedVersion", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha1.PropagatedVersionArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha1.PropagatedVersionArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha1.PropagatedVersionArgs();
            args.ApiVersion = "core.kubefed.io/v1alpha1";
            args.Kind = "PropagatedVersion";
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
        /// Get an existing PropagatedVersion resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static PropagatedVersion Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new PropagatedVersion(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha1
{

    public class PropagatedVersionArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha1.PropagatedVersionStatusArgs>? Status { get; set; }

        public PropagatedVersionArgs()
        {
        }
    }
}
