// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Crds.Camel.V1
{
    /// <summary>
    /// Build is the Schema for the builds API
    /// </summary>
    public partial class Build : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// BuildSpec defines the desired state of Build
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Camel.V1.BuildSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// BuildStatus defines the observed state of Build
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Camel.V1.BuildStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a Build resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Build(string name, Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:camel.apache.org/v1:Build", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal Build(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:camel.apache.org/v1:Build", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private Build(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:camel.apache.org/v1:Build", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildArgs();
            args.ApiVersion = "camel.apache.org/v1";
            args.Kind = "Build";
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
        /// Get an existing Build resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Build Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Build(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Camel.V1
{

    public class BuildArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// BuildSpec defines the desired state of Build
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecArgs>? Spec { get; set; }

        /// <summary>
        /// BuildStatus defines the observed state of Build
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildStatusArgs>? Status { get; set; }

        public BuildArgs()
        {
        }
    }
}