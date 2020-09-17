// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.ClusterManager.Operator.V1
{
    /// <summary>
    /// ClusterManager configures the controllers on the hub that govern registration and work distribution for attached Klusterlets. ClusterManager will be only deployed in open-cluster-management-hub namespace.
    /// </summary>
    public partial class ClusterManager : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// Spec represents a desired deployment configuration of controllers that govern registration and work distribution for attached Klusterlets.
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Operator.V1.ClusterManagerSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// Status represents the current status of controllers that govern the lifecycle of managed clusters.
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Operator.V1.ClusterManagerStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a ClusterManager resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ClusterManager(string name, Pulumi.Kubernetes.Types.Inputs.Operator.V1.ClusterManagerArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:operator.open-cluster-management.io/v1:ClusterManager", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal ClusterManager(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:operator.open-cluster-management.io/v1:ClusterManager", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private ClusterManager(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:operator.open-cluster-management.io/v1:ClusterManager", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Operator.V1.ClusterManagerArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Operator.V1.ClusterManagerArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Operator.V1.ClusterManagerArgs();
            args.ApiVersion = "operator.open-cluster-management.io/v1";
            args.Kind = "ClusterManager";
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
        /// Get an existing ClusterManager resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ClusterManager Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ClusterManager(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Operator.V1
{

    public class ClusterManagerArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// Spec represents a desired deployment configuration of controllers that govern registration and work distribution for attached Klusterlets.
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Operator.V1.ClusterManagerSpecArgs>? Spec { get; set; }

        /// <summary>
        /// Status represents the current status of controllers that govern the lifecycle of managed clusters.
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Operator.V1.ClusterManagerStatusArgs>? Status { get; set; }

        public ClusterManagerArgs()
        {
        }
    }
}