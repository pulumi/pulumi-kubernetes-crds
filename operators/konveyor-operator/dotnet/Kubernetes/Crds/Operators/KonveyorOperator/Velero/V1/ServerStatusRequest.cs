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
    /// ServerStatusRequest is a request to access current status information about the Velero server.
    /// </summary>
    public partial class ServerStatusRequest : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// ServerStatusRequestSpec is the specification for a ServerStatusRequest.
        /// </summary>
        [Output("spec")]
        public Output<ImmutableDictionary<string, object>> Spec { get; private set; } = null!;

        /// <summary>
        /// ServerStatusRequestStatus is the current status of a ServerStatusRequest.
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Velero.V1.ServerStatusRequestStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a ServerStatusRequest resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ServerStatusRequest(string name, Pulumi.Kubernetes.Types.Inputs.Velero.V1.ServerStatusRequestArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:velero.io/v1:ServerStatusRequest", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal ServerStatusRequest(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:velero.io/v1:ServerStatusRequest", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private ServerStatusRequest(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:velero.io/v1:ServerStatusRequest", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Velero.V1.ServerStatusRequestArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Velero.V1.ServerStatusRequestArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Velero.V1.ServerStatusRequestArgs();
            args.ApiVersion = "velero.io/v1";
            args.Kind = "ServerStatusRequest";
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
        /// Get an existing ServerStatusRequest resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ServerStatusRequest Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ServerStatusRequest(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Velero.V1
{

    public class ServerStatusRequestArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        [Input("spec")]
        private InputMap<object>? _spec;

        /// <summary>
        /// ServerStatusRequestSpec is the specification for a ServerStatusRequest.
        /// </summary>
        public InputMap<object> Spec
        {
            get => _spec ?? (_spec = new InputMap<object>());
            set => _spec = value;
        }

        /// <summary>
        /// ServerStatusRequestStatus is the current status of a ServerStatusRequest.
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Velero.V1.ServerStatusRequestStatusArgs>? Status { get; set; }

        public ServerStatusRequestArgs()
        {
        }
    }
}
