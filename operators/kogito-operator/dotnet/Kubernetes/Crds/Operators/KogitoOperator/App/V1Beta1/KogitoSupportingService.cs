// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.KogitoOperator.App.V1Beta1
{
    /// <summary>
    /// KogitoSupportingService deploys the Supporting service in the given namespace.
    /// </summary>
    public partial class KogitoSupportingService : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// KogitoSupportingServiceSpec defines the desired state of KogitoSupportingService.
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoSupportingServiceSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// KogitoSupportingServiceStatus defines the observed state of KogitoSupportingService.
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoSupportingServiceStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a KogitoSupportingService resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public KogitoSupportingService(string name, Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.KogitoSupportingServiceArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:app.kiegroup.org/v1beta1:KogitoSupportingService", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal KogitoSupportingService(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:app.kiegroup.org/v1beta1:KogitoSupportingService", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private KogitoSupportingService(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:app.kiegroup.org/v1beta1:KogitoSupportingService", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.KogitoSupportingServiceArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.KogitoSupportingServiceArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.KogitoSupportingServiceArgs();
            args.ApiVersion = "app.kiegroup.org/v1beta1";
            args.Kind = "KogitoSupportingService";
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
        /// Get an existing KogitoSupportingService resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static KogitoSupportingService Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new KogitoSupportingService(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.App.V1Beta1
{

    public class KogitoSupportingServiceArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// KogitoSupportingServiceSpec defines the desired state of KogitoSupportingService.
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.KogitoSupportingServiceSpecArgs>? Spec { get; set; }

        /// <summary>
        /// KogitoSupportingServiceStatus defines the observed state of KogitoSupportingService.
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.KogitoSupportingServiceStatusArgs>? Status { get; set; }

        public KogitoSupportingServiceArgs()
        {
        }
    }
}
