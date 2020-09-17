// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1
{

    /// <summary>
    /// object refers to a metric describing a single kubernetes object (for example, hits-per-second on an Ingress object).
    /// </summary>
    public class SeldonDeploymentSpecPredictorsComponentSpecsHpaSpecMetricsObjectArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// averageValue is the target value of the average of the metric across all relevant pods (as a quantity)
        /// </summary>
        [Input("averageValue")]
        public Input<string>? AverageValue { get; set; }

        /// <summary>
        /// metricName is the name of the metric in question.
        /// </summary>
        [Input("metricName", required: true)]
        public Input<string> MetricName { get; set; } = null!;

        /// <summary>
        /// selector is the string-encoded form of a standard kubernetes label selector for the given metric When set, it is passed as an additional parameter to the metrics server for more specific metrics scoping When unset, just the metricName will be used to gather metrics.
        /// </summary>
        [Input("selector")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsHpaSpecMetricsObjectSelectorArgs>? Selector { get; set; }

        /// <summary>
        /// target is the described Kubernetes object.
        /// </summary>
        [Input("target", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsHpaSpecMetricsObjectTargetArgs> Target { get; set; } = null!;

        /// <summary>
        /// targetValue is the target value of the metric (as a quantity).
        /// </summary>
        [Input("targetValue", required: true)]
        public Input<string> TargetValue { get; set; } = null!;

        public SeldonDeploymentSpecPredictorsComponentSpecsHpaSpecMetricsObjectArgs()
        {
        }
    }
}
