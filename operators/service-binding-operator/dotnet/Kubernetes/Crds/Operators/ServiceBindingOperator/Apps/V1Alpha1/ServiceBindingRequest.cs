// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.ServiceBindingOperator.Apps.V1Alpha1
{
    /// <summary>
    /// ServiceBindingRequest expresses intent to bind an operator-backed service with an application workload.
    /// </summary>
    public partial class ServiceBindingRequest : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// ServiceBindingRequestSpec defines the desired state of ServiceBindingRequest
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.ServiceBindingRequestSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// ServiceBindingRequestStatus defines the observed state of ServiceBindingRequest
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.ServiceBindingRequestStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a ServiceBindingRequest resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ServiceBindingRequest(string name, Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.ServiceBindingRequestArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:apps.openshift.io/v1alpha1:ServiceBindingRequest", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal ServiceBindingRequest(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:apps.openshift.io/v1alpha1:ServiceBindingRequest", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private ServiceBindingRequest(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:apps.openshift.io/v1alpha1:ServiceBindingRequest", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.ServiceBindingRequestArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.ServiceBindingRequestArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.ServiceBindingRequestArgs();
            args.ApiVersion = "apps.openshift.io/v1alpha1";
            args.Kind = "ServiceBindingRequest";
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
        /// Get an existing ServiceBindingRequest resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ServiceBindingRequest Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ServiceBindingRequest(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1
{

    public class ServiceBindingRequestArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// ServiceBindingRequestSpec defines the desired state of ServiceBindingRequest
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.ServiceBindingRequestSpecArgs>? Spec { get; set; }

        /// <summary>
        /// ServiceBindingRequestStatus defines the observed state of ServiceBindingRequest
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.ServiceBindingRequestStatusArgs>? Status { get; set; }

        public ServiceBindingRequestArgs()
        {
        }
    }
}