// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.Crossplane.Database.V1Alpha1
{
    /// <summary>
    /// A NoSQLInstance is a portable resource claim that may be satisfied by binding to a NoSQL managed resource such as an AWS DynamoDB or an Azure CosmosDB instance.
    /// </summary>
    public partial class NoSQLInstance : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// NoSQLInstanceSpec specifies the desired state of a NoSQLInstance.
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Database.V1Alpha1.NoSQLInstanceSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// A ResourceClaimStatus represents the observed status of a resource claim.
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Database.V1Alpha1.NoSQLInstanceStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a NoSQLInstance resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public NoSQLInstance(string name, Pulumi.Kubernetes.Types.Inputs.Database.V1Alpha1.NoSQLInstanceArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:database.crossplane.io/v1alpha1:NoSQLInstance", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal NoSQLInstance(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:database.crossplane.io/v1alpha1:NoSQLInstance", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private NoSQLInstance(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:database.crossplane.io/v1alpha1:NoSQLInstance", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Database.V1Alpha1.NoSQLInstanceArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Database.V1Alpha1.NoSQLInstanceArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Database.V1Alpha1.NoSQLInstanceArgs();
            args.ApiVersion = "database.crossplane.io/v1alpha1";
            args.Kind = "NoSQLInstance";
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
        /// Get an existing NoSQLInstance resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static NoSQLInstance Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new NoSQLInstance(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Database.V1Alpha1
{

    public class NoSQLInstanceArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// NoSQLInstanceSpec specifies the desired state of a NoSQLInstance.
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Database.V1Alpha1.NoSQLInstanceSpecArgs>? Spec { get; set; }

        /// <summary>
        /// A ResourceClaimStatus represents the observed status of a resource claim.
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Database.V1Alpha1.NoSQLInstanceStatusArgs>? Status { get; set; }

        public NoSQLInstanceArgs()
        {
        }
    }
}