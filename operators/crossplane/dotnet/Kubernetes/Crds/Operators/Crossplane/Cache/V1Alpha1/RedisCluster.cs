// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.Crossplane.Cache.V1Alpha1
{
    /// <summary>
    /// A RedisCluster is a portable resource claim that may be satisfied by binding to a Redis managed resource such as a GCP CloudMemorystore instance or an AWS ReplicationGroup. Despite the name RedisCluster claims may bind to Redis managed resources that are a single node, or not in cluster mode.
    /// </summary>
    public partial class RedisCluster : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// RedisClusterSpec specifies the desired state of a RedisCluster.
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Cache.V1Alpha1.RedisClusterSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// A ResourceClaimStatus represents the observed status of a resource claim.
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Cache.V1Alpha1.RedisClusterStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a RedisCluster resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RedisCluster(string name, Pulumi.Kubernetes.Types.Inputs.Cache.V1Alpha1.RedisClusterArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:cache.crossplane.io/v1alpha1:RedisCluster", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal RedisCluster(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:cache.crossplane.io/v1alpha1:RedisCluster", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private RedisCluster(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:cache.crossplane.io/v1alpha1:RedisCluster", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Cache.V1Alpha1.RedisClusterArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Cache.V1Alpha1.RedisClusterArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Cache.V1Alpha1.RedisClusterArgs();
            args.ApiVersion = "cache.crossplane.io/v1alpha1";
            args.Kind = "RedisCluster";
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
        /// Get an existing RedisCluster resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RedisCluster Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new RedisCluster(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Cache.V1Alpha1
{

    public class RedisClusterArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// RedisClusterSpec specifies the desired state of a RedisCluster.
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Cache.V1Alpha1.RedisClusterSpecArgs>? Spec { get; set; }

        /// <summary>
        /// A ResourceClaimStatus represents the observed status of a resource claim.
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Cache.V1Alpha1.RedisClusterStatusArgs>? Status { get; set; }

        public RedisClusterArgs()
        {
        }
    }
}
