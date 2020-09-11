// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Crds.Apm.V1Alpha1
{
    /// <summary>
    /// ApmServer represents an APM Server resource in a Kubernetes cluster.
    /// </summary>
    public partial class ApmServer : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// ApmServerSpec holds the specification of an APM Server.
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Apm.V1Alpha1.ApmServerSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// ApmServerStatus defines the observed state of ApmServer
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Apm.V1Alpha1.ApmServerStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a ApmServer resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ApmServer(string name, Pulumi.Kubernetes.Types.Inputs.Apm.V1Alpha1.ApmServerArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:apm.k8s.elastic.co/v1alpha1:ApmServer", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal ApmServer(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:apm.k8s.elastic.co/v1alpha1:ApmServer", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private ApmServer(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:apm.k8s.elastic.co/v1alpha1:ApmServer", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Apm.V1Alpha1.ApmServerArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Apm.V1Alpha1.ApmServerArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Apm.V1Alpha1.ApmServerArgs();
            args.ApiVersion = "apm.k8s.elastic.co/v1alpha1";
            args.Kind = "ApmServer";
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
        /// Get an existing ApmServer resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ApmServer Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ApmServer(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Apm.V1Alpha1
{

    public class ApmServerArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// ApmServerSpec holds the specification of an APM Server.
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apm.V1Alpha1.ApmServerSpecArgs>? Spec { get; set; }

        /// <summary>
        /// ApmServerStatus defines the observed state of ApmServer
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apm.V1Alpha1.ApmServerStatusArgs>? Status { get; set; }

        public ApmServerArgs()
        {
        }
    }
}
