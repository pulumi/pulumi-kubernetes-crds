// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.MulticlusterOperatorsSubscription.App.V1Beta1
{
    /// <summary>
    /// Application is the Schema for the applications API
    /// </summary>
    public partial class Application : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// ApplicationSpec defines the specification for an Application.
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.ApplicationSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// ApplicationStatus defines controller's the observed state of Application
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.ApplicationStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a Application resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Application(string name, Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.ApplicationArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:app.k8s.io/v1beta1:Application", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal Application(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:app.k8s.io/v1beta1:Application", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private Application(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:app.k8s.io/v1beta1:Application", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.ApplicationArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.ApplicationArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.ApplicationArgs();
            args.ApiVersion = "app.k8s.io/v1beta1";
            args.Kind = "Application";
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
        /// Get an existing Application resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Application Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Application(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.App.V1Beta1
{

    public class ApplicationArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// ApplicationSpec defines the specification for an Application.
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.ApplicationSpecArgs>? Spec { get; set; }

        /// <summary>
        /// ApplicationStatus defines controller's the observed state of Application
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.ApplicationStatusArgs>? Status { get; set; }

        public ApplicationArgs()
        {
        }
    }
}
