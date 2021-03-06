// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.HamDeploy.Deploy.V1Alpha1
{
    /// <summary>
    /// Operator is the Schema for the operators API
    /// </summary>
    public partial class Operator : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// OperatorSpec defines the desired state of Operator
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// OperatorStatus defines the observed state of Operator
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a Operator resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Operator(string name, Pulumi.Kubernetes.Types.Inputs.Deploy.V1Alpha1.OperatorArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:deploy.hybridapp.io/v1alpha1:Operator", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal Operator(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:deploy.hybridapp.io/v1alpha1:Operator", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private Operator(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:deploy.hybridapp.io/v1alpha1:Operator", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Deploy.V1Alpha1.OperatorArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Deploy.V1Alpha1.OperatorArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Deploy.V1Alpha1.OperatorArgs();
            args.ApiVersion = "deploy.hybridapp.io/v1alpha1";
            args.Kind = "Operator";
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
        /// Get an existing Operator resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Operator Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Operator(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Deploy.V1Alpha1
{

    public class OperatorArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// OperatorSpec defines the desired state of Operator
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Deploy.V1Alpha1.OperatorSpecArgs>? Spec { get; set; }

        /// <summary>
        /// OperatorStatus defines the observed state of Operator
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Deploy.V1Alpha1.OperatorStatusArgs>? Status { get; set; }

        public OperatorArgs()
        {
        }
    }
}
