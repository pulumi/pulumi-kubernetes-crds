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
    /// HPAScalingPolicy is a single policy which must hold true for a specified past interval.
    /// </summary>
    public class SeldonDeploymentSpecPredictorsComponentSpecsKedaSpecAdvancedHorizontalPodAutoscalerConfigBehaviorScaleUpPoliciesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// PeriodSeconds specifies the window of time for which the policy should hold true. PeriodSeconds must be greater than zero and less than or equal to 1800 (30 min).
        /// </summary>
        [Input("periodSeconds", required: true)]
        public Input<int> PeriodSeconds { get; set; } = null!;

        /// <summary>
        /// Type is used to specify the scaling policy.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// Value contains the amount of change which is permitted by the policy. It must be greater than zero
        /// </summary>
        [Input("value", required: true)]
        public Input<int> Value { get; set; } = null!;

        public SeldonDeploymentSpecPredictorsComponentSpecsKedaSpecAdvancedHorizontalPodAutoscalerConfigBehaviorScaleUpPoliciesArgs()
        {
        }
    }
}
