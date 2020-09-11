// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Crds.App.V1Alpha1
{
    /// <summary>
    /// KogitoBuild handles how to build a custom Kogito service in a Kubernetes/OpenShift cluster.
    /// </summary>
    public partial class KogitoBuild : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// KogitoBuildSpec defines the desired state of KogitoBuild.
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoBuildSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// KogitoBuildStatus defines the observed state of KogitoBuild.
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoBuildStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a KogitoBuild resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public KogitoBuild(string name, Pulumi.Kubernetes.Types.Inputs.App.V1Alpha1.KogitoBuildArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:app.kiegroup.org/v1alpha1:KogitoBuild", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal KogitoBuild(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:app.kiegroup.org/v1alpha1:KogitoBuild", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private KogitoBuild(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:app.kiegroup.org/v1alpha1:KogitoBuild", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.App.V1Alpha1.KogitoBuildArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.App.V1Alpha1.KogitoBuildArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.App.V1Alpha1.KogitoBuildArgs();
            args.ApiVersion = "app.kiegroup.org/v1alpha1";
            args.Kind = "KogitoBuild";
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
        /// Get an existing KogitoBuild resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static KogitoBuild Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new KogitoBuild(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.App.V1Alpha1
{

    public class KogitoBuildArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// KogitoBuildSpec defines the desired state of KogitoBuild.
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.App.V1Alpha1.KogitoBuildSpecArgs>? Spec { get; set; }

        /// <summary>
        /// KogitoBuildStatus defines the observed state of KogitoBuild.
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.App.V1Alpha1.KogitoBuildStatusArgs>? Status { get; set; }

        public KogitoBuildArgs()
        {
        }
    }
}
