// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.ElasticCloudEck.Elasticsearch.V1
{
    /// <summary>
    /// Elasticsearch represents an Elasticsearch resource in a Kubernetes cluster.
    /// </summary>
    public partial class Elasticsearch : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// ElasticsearchSpec holds the specification of an Elasticsearch cluster.
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Elasticsearch.V1.ElasticsearchSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// ElasticsearchStatus defines the observed state of Elasticsearch
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Elasticsearch.V1.ElasticsearchStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a Elasticsearch resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Elasticsearch(string name, Pulumi.Kubernetes.Types.Inputs.Elasticsearch.V1.ElasticsearchArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:elasticsearch.k8s.elastic.co/v1:Elasticsearch", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal Elasticsearch(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:elasticsearch.k8s.elastic.co/v1:Elasticsearch", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private Elasticsearch(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:elasticsearch.k8s.elastic.co/v1:Elasticsearch", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Elasticsearch.V1.ElasticsearchArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Elasticsearch.V1.ElasticsearchArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Elasticsearch.V1.ElasticsearchArgs();
            args.ApiVersion = "elasticsearch.k8s.elastic.co/v1";
            args.Kind = "Elasticsearch";
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
        /// Get an existing Elasticsearch resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Elasticsearch Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Elasticsearch(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Elasticsearch.V1
{

    public class ElasticsearchArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// ElasticsearchSpec holds the specification of an Elasticsearch cluster.
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Elasticsearch.V1.ElasticsearchSpecArgs>? Spec { get; set; }

        /// <summary>
        /// ElasticsearchStatus defines the observed state of Elasticsearch
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Elasticsearch.V1.ElasticsearchStatusArgs>? Status { get; set; }

        public ElasticsearchArgs()
        {
        }
    }
}