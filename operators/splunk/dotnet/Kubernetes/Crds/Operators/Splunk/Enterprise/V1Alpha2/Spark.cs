// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.Splunk.Enterprise.V1Alpha2
{
    /// <summary>
    /// Spark is the Schema for a Spark cluster
    /// </summary>
    public partial class Spark : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// SparkSpec defines the desired state of a Spark cluster
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.SparkSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// SparkStatus defines the observed state of a Spark cluster
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.SparkStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a Spark resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Spark(string name, Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.SparkArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:enterprise.splunk.com/v1alpha2:Spark", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal Spark(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:enterprise.splunk.com/v1alpha2:Spark", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private Spark(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:enterprise.splunk.com/v1alpha2:Spark", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.SparkArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.SparkArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.SparkArgs();
            args.ApiVersion = "enterprise.splunk.com/v1alpha2";
            args.Kind = "Spark";
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
        /// Get an existing Spark resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Spark Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Spark(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2
{

    public class SparkArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// SparkSpec defines the desired state of a Spark cluster
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.SparkSpecArgs>? Spec { get; set; }

        /// <summary>
        /// SparkStatus defines the observed state of a Spark cluster
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.SparkStatusArgs>? Status { get; set; }

        public SparkArgs()
        {
        }
    }
}
