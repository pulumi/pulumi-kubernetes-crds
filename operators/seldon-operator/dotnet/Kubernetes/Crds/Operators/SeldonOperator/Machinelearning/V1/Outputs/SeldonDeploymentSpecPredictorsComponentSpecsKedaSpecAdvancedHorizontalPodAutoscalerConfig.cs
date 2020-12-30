// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1
{

    [OutputType]
    public sealed class SeldonDeploymentSpecPredictorsComponentSpecsKedaSpecAdvancedHorizontalPodAutoscalerConfig
    {
        /// <summary>
        /// HorizontalPodAutoscalerBehavior configures the scaling behavior of the target in both Up and Down directions (scaleUp and scaleDown fields respectively).
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsKedaSpecAdvancedHorizontalPodAutoscalerConfigBehavior Behavior;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsKedaSpecAdvancedHorizontalPodAutoscalerConfigResourceMetrics> ResourceMetrics;

        [OutputConstructor]
        private SeldonDeploymentSpecPredictorsComponentSpecsKedaSpecAdvancedHorizontalPodAutoscalerConfig(
            Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsKedaSpecAdvancedHorizontalPodAutoscalerConfigBehavior behavior,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsKedaSpecAdvancedHorizontalPodAutoscalerConfigResourceMetrics> resourceMetrics)
        {
            Behavior = behavior;
            ResourceMetrics = resourceMetrics;
        }
    }
}