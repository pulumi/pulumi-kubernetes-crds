// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.Splunk.Enterprise.V1Alpha2
{
    /// <summary>
    /// Standalone is the Schema for a Splunk Enterprise standalone instances.
    /// </summary>
    public partial class Standalone : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// StandaloneSpec defines the desired state of a Splunk Enterprise standalone instances.
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.StandaloneSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// StandaloneStatus defines the observed state of a Splunk Enterprise standalone instances.
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.StandaloneStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a Standalone resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Standalone(string name, Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.StandaloneArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:enterprise.splunk.com/v1alpha2:Standalone", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal Standalone(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:enterprise.splunk.com/v1alpha2:Standalone", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private Standalone(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:enterprise.splunk.com/v1alpha2:Standalone", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.StandaloneArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.StandaloneArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.StandaloneArgs();
            args.ApiVersion = "enterprise.splunk.com/v1alpha2";
            args.Kind = "Standalone";
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
        /// Get an existing Standalone resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Standalone Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Standalone(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2
{

    public class StandaloneArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// StandaloneSpec defines the desired state of a Splunk Enterprise standalone instances.
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.StandaloneSpecArgs>? Spec { get; set; }

        /// <summary>
        /// StandaloneStatus defines the observed state of a Splunk Enterprise standalone instances.
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.StandaloneStatusArgs>? Status { get; set; }

        public StandaloneArgs()
        {
        }
    }
}