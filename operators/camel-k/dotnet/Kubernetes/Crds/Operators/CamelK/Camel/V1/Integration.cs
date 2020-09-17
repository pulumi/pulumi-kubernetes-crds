// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.CamelK.Camel.V1
{
    /// <summary>
    /// Integration is the Schema for the integrations API
    /// </summary>
    public partial class Integration : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// IntegrationSpec defines the desired state of Integration
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Camel.V1.IntegrationSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// IntegrationStatus defines the observed state of Integration
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Camel.V1.IntegrationStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a Integration resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Integration(string name, Pulumi.Kubernetes.Types.Inputs.Camel.V1.IntegrationArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:camel.apache.org/v1:Integration", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal Integration(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:camel.apache.org/v1:Integration", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private Integration(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:camel.apache.org/v1:Integration", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Camel.V1.IntegrationArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Camel.V1.IntegrationArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Camel.V1.IntegrationArgs();
            args.ApiVersion = "camel.apache.org/v1";
            args.Kind = "Integration";
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
        /// Get an existing Integration resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Integration Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Integration(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Camel.V1
{

    public class IntegrationArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// IntegrationSpec defines the desired state of Integration
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.IntegrationSpecArgs>? Spec { get; set; }

        /// <summary>
        /// IntegrationStatus defines the observed state of Integration
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.IntegrationStatusArgs>? Status { get; set; }

        public IntegrationArgs()
        {
        }
    }
}