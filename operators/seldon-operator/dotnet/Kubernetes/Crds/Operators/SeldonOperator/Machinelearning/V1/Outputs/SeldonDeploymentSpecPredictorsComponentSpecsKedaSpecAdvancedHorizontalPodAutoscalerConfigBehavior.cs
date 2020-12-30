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
    public sealed class SeldonDeploymentSpecPredictorsComponentSpecsKedaSpecAdvancedHorizontalPodAutoscalerConfigBehavior
    {
        /// <summary>
        /// scaleDown is scaling policy for scaling Down. If not set, the default value is to allow to scale down to minReplicas pods, with a 300 second stabilization window (i.e., the highest recommendation for the last 300sec is used).
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsKedaSpecAdvancedHorizontalPodAutoscalerConfigBehaviorScaleDown ScaleDown;
        /// <summary>
        /// scaleUp is scaling policy for scaling Up. If not set, the default value is the higher of:   * increase no more than 4 pods per 60 seconds   * double the number of pods per 60 seconds No stabilization is used.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsKedaSpecAdvancedHorizontalPodAutoscalerConfigBehaviorScaleUp ScaleUp;

        [OutputConstructor]
        private SeldonDeploymentSpecPredictorsComponentSpecsKedaSpecAdvancedHorizontalPodAutoscalerConfigBehavior(
            Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsKedaSpecAdvancedHorizontalPodAutoscalerConfigBehaviorScaleDown scaleDown,

            Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsKedaSpecAdvancedHorizontalPodAutoscalerConfigBehaviorScaleUp scaleUp)
        {
            ScaleDown = scaleDown;
            ScaleUp = scaleUp;
        }
    }
}