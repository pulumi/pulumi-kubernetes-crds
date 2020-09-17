// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.Crossplane.Core.V1Alpha2
{
    /// <summary>
    /// A WorkloadDefinition registers a kind of Kubernetes custom resource as a valid OAM workload kind by referencing its CustomResourceDefinition. The CRD is used to validate the schema of the workload when it is embedded in an OAM Component.
    /// </summary>
    public partial class WorkloadDefinition : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// A WorkloadDefinitionSpec defines the desired state of a WorkloadDefinition.
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.WorkloadDefinitionSpec> Spec { get; private set; } = null!;


        /// <summary>
        /// Create a WorkloadDefinition resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WorkloadDefinition(string name, Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.WorkloadDefinitionArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:core.oam.dev/v1alpha2:WorkloadDefinition", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal WorkloadDefinition(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:core.oam.dev/v1alpha2:WorkloadDefinition", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private WorkloadDefinition(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:core.oam.dev/v1alpha2:WorkloadDefinition", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.WorkloadDefinitionArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.WorkloadDefinitionArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.WorkloadDefinitionArgs();
            args.ApiVersion = "core.oam.dev/v1alpha2";
            args.Kind = "WorkloadDefinition";
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
        /// Get an existing WorkloadDefinition resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WorkloadDefinition Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new WorkloadDefinition(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2
{

    public class WorkloadDefinitionArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// A WorkloadDefinitionSpec defines the desired state of a WorkloadDefinition.
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.WorkloadDefinitionSpecArgs>? Spec { get; set; }

        public WorkloadDefinitionArgs()
        {
        }
    }
}