// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.PrometheusExporterOperator.Monitoring.V1Alpha1
{
    /// <summary>
    /// PrometheusExporter is the Schema for the prometheus exporters
    /// </summary>
    public partial class PrometheusExporter : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// PrometheusExporterSpec defines the desired state of PrometheusExporter
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Monitoring.V1Alpha1.PrometheusExporterSpec> Spec { get; private set; } = null!;


        /// <summary>
        /// Create a PrometheusExporter resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public PrometheusExporter(string name, Pulumi.Kubernetes.Types.Inputs.Monitoring.V1Alpha1.PrometheusExporterArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:monitoring.3scale.net/v1alpha1:PrometheusExporter", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal PrometheusExporter(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:monitoring.3scale.net/v1alpha1:PrometheusExporter", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private PrometheusExporter(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:monitoring.3scale.net/v1alpha1:PrometheusExporter", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Monitoring.V1Alpha1.PrometheusExporterArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Monitoring.V1Alpha1.PrometheusExporterArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Monitoring.V1Alpha1.PrometheusExporterArgs();
            args.ApiVersion = "monitoring.3scale.net/v1alpha1";
            args.Kind = "PrometheusExporter";
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
        /// Get an existing PrometheusExporter resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static PrometheusExporter Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new PrometheusExporter(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1Alpha1
{

    public class PrometheusExporterArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// PrometheusExporterSpec defines the desired state of PrometheusExporter
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1Alpha1.PrometheusExporterSpecArgs>? Spec { get; set; }

        public PrometheusExporterArgs()
        {
        }
    }
}
