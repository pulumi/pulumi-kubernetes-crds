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
    /// target specifies the target value for the given metric
    /// </summary>
    public class SeldonDeploymentSpecPredictorsComponentSpecsKedaSpecAdvancedHorizontalPodAutoscalerConfigResourceMetricsTargetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// averageUtilization is the target value of the average of the resource metric across all relevant pods, represented as a percentage of the requested value of the resource for the pods. Currently only valid for Resource metric source type
        /// </summary>
        [Input("averageUtilization")]
        public Input<int>? AverageUtilization { get; set; }

        /// <summary>
        /// averageValue is the target value of the average of the metric across all relevant pods (as a quantity)
        /// </summary>
        [Input("averageValue")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsKedaSpecAdvancedHorizontalPodAutoscalerConfigResourceMetricsTargetAverageValueArgs>? AverageValue { get; set; }

        /// <summary>
        /// type represents whether the metric type is Utilization, Value, or AverageValue
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// value is the target value of the metric (as a quantity).
        /// </summary>
        [Input("value")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsKedaSpecAdvancedHorizontalPodAutoscalerConfigResourceMetricsTargetValueArgs>? Value { get; set; }

        public SeldonDeploymentSpecPredictorsComponentSpecsKedaSpecAdvancedHorizontalPodAutoscalerConfigResourceMetricsTargetArgs()
        {
        }
    }
}
