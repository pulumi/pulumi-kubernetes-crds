// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.McadOperator.Mcad.V1Beta1
{
    public partial class MCADHelmConfig : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;


        /// <summary>
        /// Create a MCADHelmConfig resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MCADHelmConfig(string name, Pulumi.Kubernetes.Types.Inputs.Mcad.V1Beta1.MCADHelmConfigArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:mcad.ibm.com/v1beta1:MCADHelmConfig", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal MCADHelmConfig(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:mcad.ibm.com/v1beta1:MCADHelmConfig", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private MCADHelmConfig(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:mcad.ibm.com/v1beta1:MCADHelmConfig", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Mcad.V1Beta1.MCADHelmConfigArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Mcad.V1Beta1.MCADHelmConfigArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Mcad.V1Beta1.MCADHelmConfigArgs();
            args.ApiVersion = "mcad.ibm.com/v1beta1";
            args.Kind = "MCADHelmConfig";
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
        /// Get an existing MCADHelmConfig resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MCADHelmConfig Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new MCADHelmConfig(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Mcad.V1Beta1
{

    public class MCADHelmConfigArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        public MCADHelmConfigArgs()
        {
        }
    }
}