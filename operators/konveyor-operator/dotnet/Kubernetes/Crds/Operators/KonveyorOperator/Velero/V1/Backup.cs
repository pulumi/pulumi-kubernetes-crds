// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.KonveyorOperator.Velero.V1
{
    /// <summary>
    /// Backup is a Velero resource that respresents the capture of Kubernetes cluster state at a point in time (API objects and associated volume state).
    /// </summary>
    public partial class Backup : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// BackupSpec defines the specification for a Velero backup.
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Velero.V1.BackupSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// BackupStatus captures the current status of a Velero backup.
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Velero.V1.BackupStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a Backup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Backup(string name, Pulumi.Kubernetes.Types.Inputs.Velero.V1.BackupArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:velero.io/v1:Backup", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal Backup(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:velero.io/v1:Backup", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private Backup(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:velero.io/v1:Backup", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Velero.V1.BackupArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Velero.V1.BackupArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Velero.V1.BackupArgs();
            args.ApiVersion = "velero.io/v1";
            args.Kind = "Backup";
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
        /// Get an existing Backup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Backup Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Backup(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Velero.V1
{

    public class BackupArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// BackupSpec defines the specification for a Velero backup.
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Velero.V1.BackupSpecArgs>? Spec { get; set; }

        /// <summary>
        /// BackupStatus captures the current status of a Velero backup.
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Velero.V1.BackupStatusArgs>? Status { get; set; }

        public BackupArgs()
        {
        }
    }
}
