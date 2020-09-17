// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.NexusOperatorM88i.Apps.V1Alpha1
{
    /// <summary>
    /// Nexus custom resource to deploy the Nexus Server
    /// </summary>
    public partial class Nexus : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// NexusSpec defines the desired state of Nexus
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.NexusSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// NexusStatus defines the observed state of Nexus
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.NexusStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a Nexus resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Nexus(string name, Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.NexusArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:apps.m88i.io/v1alpha1:Nexus", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal Nexus(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:apps.m88i.io/v1alpha1:Nexus", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private Nexus(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:apps.m88i.io/v1alpha1:Nexus", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.NexusArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.NexusArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.NexusArgs();
            args.ApiVersion = "apps.m88i.io/v1alpha1";
            args.Kind = "Nexus";
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
        /// Get an existing Nexus resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Nexus Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Nexus(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1
{

    public class NexusArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// NexusSpec defines the desired state of Nexus
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.NexusSpecArgs>? Spec { get; set; }

        /// <summary>
        /// NexusStatus defines the observed state of Nexus
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.NexusStatusArgs>? Status { get; set; }

        public NexusArgs()
        {
        }
    }
}