// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1
{

    /// <summary>
    /// Rule describes an alerting or recording rule.
    /// </summary>
    public class PrometheusRuleSpecGroupsRulesArgs : Pulumi.ResourceArgs
    {
        [Input("alert")]
        public Input<string>? Alert { get; set; }

        [Input("annotations")]
        private InputMap<string>? _annotations;
        public InputMap<string> Annotations
        {
            get => _annotations ?? (_annotations = new InputMap<string>());
            set => _annotations = value;
        }

        [Input("expr", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.PrometheusRuleSpecGroupsRulesExprArgs> Expr { get; set; } = null!;

        [Input("for")]
        public Input<string>? For { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("record")]
        public Input<string>? Record { get; set; }

        public PrometheusRuleSpecGroupsRulesArgs()
        {
        }
    }
}
