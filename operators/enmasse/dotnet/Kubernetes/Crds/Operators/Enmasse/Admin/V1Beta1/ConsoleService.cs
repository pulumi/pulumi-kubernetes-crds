// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.Enmasse.Admin.V1Beta1
{
    /// <summary>
    /// ConsoleService creates a console that can be used by messaging tenants to manage EnMasse. This resource is created by the service administrator.
    /// </summary>
    public partial class ConsoleService : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.ConsoleServiceSpec> Spec { get; private set; } = null!;

        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.ConsoleServiceStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a ConsoleService resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ConsoleService(string name, Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta1.ConsoleServiceArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:admin.enmasse.io/v1beta1:ConsoleService", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal ConsoleService(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:admin.enmasse.io/v1beta1:ConsoleService", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private ConsoleService(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:admin.enmasse.io/v1beta1:ConsoleService", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta1.ConsoleServiceArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta1.ConsoleServiceArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta1.ConsoleServiceArgs();
            args.ApiVersion = "admin.enmasse.io/v1beta1";
            args.Kind = "ConsoleService";
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
        /// Get an existing ConsoleService resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ConsoleService Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ConsoleService(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta1
{

    public class ConsoleServiceArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta1.ConsoleServiceSpecArgs>? Spec { get; set; }

        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta1.ConsoleServiceStatusArgs>? Status { get; set; }

        public ConsoleServiceArgs()
        {
        }
    }
}
