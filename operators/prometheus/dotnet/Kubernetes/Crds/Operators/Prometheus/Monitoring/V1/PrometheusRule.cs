// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.Prometheus.Monitoring.V1
{
    /// <summary>
    /// PrometheusRule defines alerting rules for a Prometheus instance
    /// </summary>
    public partial class PrometheusRule : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// Specification of desired alerting rule definitions for Prometheus.
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusRuleSpec> Spec { get; private set; } = null!;


        /// <summary>
        /// Create a PrometheusRule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public PrometheusRule(string name, Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.PrometheusRuleArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:monitoring.coreos.com/v1:PrometheusRule", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal PrometheusRule(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:monitoring.coreos.com/v1:PrometheusRule", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private PrometheusRule(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:monitoring.coreos.com/v1:PrometheusRule", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.PrometheusRuleArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.PrometheusRuleArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.PrometheusRuleArgs();
            args.ApiVersion = "monitoring.coreos.com/v1";
            args.Kind = "PrometheusRule";
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
        /// Get an existing PrometheusRule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static PrometheusRule Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new PrometheusRule(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1
{

    public class PrometheusRuleArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// Specification of desired alerting rule definitions for Prometheus.
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.PrometheusRuleSpecArgs>? Spec { get; set; }

        public PrometheusRuleArgs()
        {
        }
    }
}
