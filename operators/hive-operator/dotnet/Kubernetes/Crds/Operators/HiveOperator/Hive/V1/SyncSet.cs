// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.HiveOperator.Hive.V1
{
    /// <summary>
    /// SyncSet is the Schema for the SyncSet API
    /// </summary>
    public partial class SyncSet : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// SyncSetSpec defines the SyncSetCommonSpec resources and patches to sync along with ClusterDeploymentRefs indicating which clusters the SyncSet applies to in the SyncSet's namespace.
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncSetSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// SyncSetStatus defines the observed state of a SyncSet
        /// </summary>
        [Output("status")]
        public Output<ImmutableDictionary<string, object>> Status { get; private set; } = null!;


        /// <summary>
        /// Create a SyncSet resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SyncSet(string name, Pulumi.Kubernetes.Types.Inputs.Hive.V1.SyncSetArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:hive.openshift.io/v1:SyncSet", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal SyncSet(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:hive.openshift.io/v1:SyncSet", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private SyncSet(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:hive.openshift.io/v1:SyncSet", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Hive.V1.SyncSetArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Hive.V1.SyncSetArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Hive.V1.SyncSetArgs();
            args.ApiVersion = "hive.openshift.io/v1";
            args.Kind = "SyncSet";
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
        /// Get an existing SyncSet resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SyncSet Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new SyncSet(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Hive.V1
{

    public class SyncSetArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// SyncSetSpec defines the SyncSetCommonSpec resources and patches to sync along with ClusterDeploymentRefs indicating which clusters the SyncSet applies to in the SyncSet's namespace.
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.SyncSetSpecArgs>? Spec { get; set; }

        [Input("status")]
        private InputMap<object>? _status;

        /// <summary>
        /// SyncSetStatus defines the observed state of a SyncSet
        /// </summary>
        public InputMap<object> Status
        {
            get => _status ?? (_status = new InputMap<object>());
            set => _status = value;
        }

        public SyncSetArgs()
        {
        }
    }
}