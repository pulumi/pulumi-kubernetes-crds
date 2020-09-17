// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.Kubefed.Multiclusterdns.V1Alpha1
{
    public partial class Domain : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        /// <summary>
        /// Domain is the DNS zone associated with the KubeFed control plane
        /// </summary>
        [Output("domain")]
        public Output<string> Domain { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// NameServer is the authoritative DNS name server for the KubeFed domain
        /// </summary>
        [Output("nameServer")]
        public Output<string> NameServer { get; private set; } = null!;


        /// <summary>
        /// Create a Domain resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Domain(string name, Pulumi.Kubernetes.Types.Inputs.Multiclusterdns.V1Alpha1.DomainArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:multiclusterdns.kubefed.io/v1alpha1:Domain", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal Domain(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:multiclusterdns.kubefed.io/v1alpha1:Domain", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private Domain(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:multiclusterdns.kubefed.io/v1alpha1:Domain", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Multiclusterdns.V1Alpha1.DomainArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Multiclusterdns.V1Alpha1.DomainArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Multiclusterdns.V1Alpha1.DomainArgs();
            args.ApiVersion = "multiclusterdns.kubefed.io/v1alpha1";
            args.Kind = "Domain";
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
        /// Get an existing Domain resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Domain Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Domain(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Multiclusterdns.V1Alpha1
{

    public class DomainArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        /// <summary>
        /// Domain is the DNS zone associated with the KubeFed control plane
        /// </summary>
        [Input("domain")]
        public Input<string>? Domain { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// NameServer is the authoritative DNS name server for the KubeFed domain
        /// </summary>
        [Input("nameServer")]
        public Input<string>? NameServer { get; set; }

        public DomainArgs()
        {
        }
    }
}