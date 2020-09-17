// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.ApiOperator.Wso2.V1Alpha1
{
    public partial class API : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Wso2.V1Alpha1.APISpec> Spec { get; private set; } = null!;

        [Output("status")]
        public Output<ImmutableDictionary<string, object>> Status { get; private set; } = null!;


        /// <summary>
        /// Create a API resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public API(string name, Pulumi.Kubernetes.Types.Inputs.Wso2.V1Alpha1.APIArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:wso2.com/v1alpha1:API", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal API(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:wso2.com/v1alpha1:API", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private API(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:wso2.com/v1alpha1:API", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Wso2.V1Alpha1.APIArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Wso2.V1Alpha1.APIArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Wso2.V1Alpha1.APIArgs();
            args.ApiVersion = "wso2.com/v1alpha1";
            args.Kind = "API";
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
        /// Get an existing API resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static API Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new API(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Wso2.V1Alpha1
{

    public class APIArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Wso2.V1Alpha1.APISpecArgs>? Spec { get; set; }

        [Input("status")]
        private InputMap<object>? _status;
        public InputMap<object> Status
        {
            get => _status ?? (_status = new InputMap<object>());
            set => _status = value;
        }

        public APIArgs()
        {
        }
    }
}
