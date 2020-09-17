// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.DellCsiOperator.Storage.V1
{
    /// <summary>
    /// CSIPowerMax is the Schema for the csipowermaxes API
    /// </summary>
    public partial class CSIPowerMax : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// CSIPowerMaxSpec defines the desired state of CSIPowerMax
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIPowerMaxSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// DriverStatus defines the observed state of CSIDriver
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIPowerMaxStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a CSIPowerMax resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CSIPowerMax(string name, Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:storage.dell.com/v1:CSIPowerMax", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal CSIPowerMax(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:storage.dell.com/v1:CSIPowerMax", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private CSIPowerMax(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:storage.dell.com/v1:CSIPowerMax", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxArgs();
            args.ApiVersion = "storage.dell.com/v1";
            args.Kind = "CSIPowerMax";
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
        /// Get an existing CSIPowerMax resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CSIPowerMax Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new CSIPowerMax(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Storage.V1
{

    public class CSIPowerMaxArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// CSIPowerMaxSpec defines the desired state of CSIPowerMax
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxSpecArgs>? Spec { get; set; }

        /// <summary>
        /// DriverStatus defines the observed state of CSIDriver
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxStatusArgs>? Status { get; set; }

        public CSIPowerMaxArgs()
        {
        }
    }
}