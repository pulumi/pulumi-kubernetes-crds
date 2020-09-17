// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.ArgocdOperator.Argoproj.V1Alpha1
{
    /// <summary>
    /// AppProject provides a logical grouping of applications, providing controls for: * where the apps may deploy to (cluster whitelist) * what may be deployed (repository whitelist, resource whitelist/blacklist) * who can access these applications (roles, OIDC group claims bindings) * and what they can do (RBAC policies) * automation access to these roles (JWT tokens)
    /// </summary>
    public partial class AppProject : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// AppProjectSpec is the specification of an AppProject
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.AppProjectSpec> Spec { get; private set; } = null!;


        /// <summary>
        /// Create a AppProject resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AppProject(string name, Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.AppProjectArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:argoproj.io/v1alpha1:AppProject", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal AppProject(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:argoproj.io/v1alpha1:AppProject", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private AppProject(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:argoproj.io/v1alpha1:AppProject", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.AppProjectArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.AppProjectArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.AppProjectArgs();
            args.ApiVersion = "argoproj.io/v1alpha1";
            args.Kind = "AppProject";
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
        /// Get an existing AppProject resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AppProject Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new AppProject(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class AppProjectArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// AppProjectSpec is the specification of an AppProject
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.AppProjectSpecArgs>? Spec { get; set; }

        public AppProjectArgs()
        {
        }
    }
}
