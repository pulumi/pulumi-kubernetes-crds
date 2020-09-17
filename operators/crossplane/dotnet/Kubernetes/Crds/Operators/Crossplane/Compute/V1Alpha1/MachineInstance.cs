// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.Crossplane.Compute.V1Alpha1
{
    /// <summary>
    /// A MachineInstance is a portable resource claim that may be satisfied by binding to a machine instance, which may include Virtual Machine managed resources such as an AWS EC2 instance or bare metal managed resources such as a Packet Device.
    /// </summary>
    public partial class MachineInstance : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// MachineInstanceSpec specifies the desired state of a MachineInstance.
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Compute.V1Alpha1.MachineInstanceSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// A ResourceClaimStatus represents the observed status of a resource claim.
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Compute.V1Alpha1.MachineInstanceStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a MachineInstance resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MachineInstance(string name, Pulumi.Kubernetes.Types.Inputs.Compute.V1Alpha1.MachineInstanceArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:compute.crossplane.io/v1alpha1:MachineInstance", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal MachineInstance(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:compute.crossplane.io/v1alpha1:MachineInstance", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private MachineInstance(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:compute.crossplane.io/v1alpha1:MachineInstance", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Compute.V1Alpha1.MachineInstanceArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Compute.V1Alpha1.MachineInstanceArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Compute.V1Alpha1.MachineInstanceArgs();
            args.ApiVersion = "compute.crossplane.io/v1alpha1";
            args.Kind = "MachineInstance";
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
        /// Get an existing MachineInstance resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MachineInstance Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new MachineInstance(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Compute.V1Alpha1
{

    public class MachineInstanceArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// MachineInstanceSpec specifies the desired state of a MachineInstance.
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Compute.V1Alpha1.MachineInstanceSpecArgs>? Spec { get; set; }

        /// <summary>
        /// A ResourceClaimStatus represents the observed status of a resource claim.
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Compute.V1Alpha1.MachineInstanceStatusArgs>? Status { get; set; }

        public MachineInstanceArgs()
        {
        }
    }
}