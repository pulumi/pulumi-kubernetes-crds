// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.ComposableOperator.Ibmcloud.V1Alpha1
{
    /// <summary>
    /// Composable represents a composable resource that can wrap any resource (native kubernetes or CRDs) to allow it to be dynamically configurable
    /// </summary>
    public partial class Composable : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// ComposableSpec defines the desired state of Composable
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Ibmcloud.V1Alpha1.ComposableSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// ComposableStatus defines the observed state of Composable
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Ibmcloud.V1Alpha1.ComposableStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a Composable resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Composable(string name, Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1.ComposableArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:ibmcloud.ibm.com/v1alpha1:Composable", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal Composable(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:ibmcloud.ibm.com/v1alpha1:Composable", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private Composable(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:ibmcloud.ibm.com/v1alpha1:Composable", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1.ComposableArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1.ComposableArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1.ComposableArgs();
            args.ApiVersion = "ibmcloud.ibm.com/v1alpha1";
            args.Kind = "Composable";
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
        /// Get an existing Composable resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Composable Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Composable(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1
{

    public class ComposableArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// ComposableSpec defines the desired state of Composable
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1.ComposableSpecArgs>? Spec { get; set; }

        /// <summary>
        /// ComposableStatus defines the observed state of Composable
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1.ComposableStatusArgs>? Status { get; set; }

        public ComposableArgs()
        {
        }
    }
}
