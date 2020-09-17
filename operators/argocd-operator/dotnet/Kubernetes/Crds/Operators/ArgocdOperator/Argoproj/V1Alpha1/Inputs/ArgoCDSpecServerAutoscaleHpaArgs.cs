// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    /// <summary>
    /// HPA defines the HorizontalPodAutoscaler options for the Argo CD Server component.
    /// </summary>
    public class ArgoCDSpecServerAutoscaleHpaArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// upper limit for the number of pods that can be set by the autoscaler; cannot be smaller than MinReplicas.
        /// </summary>
        [Input("maxReplicas", required: true)]
        public Input<int> MaxReplicas { get; set; } = null!;

        /// <summary>
        /// minReplicas is the lower limit for the number of replicas to which the autoscaler can scale down.  It defaults to 1 pod.  minReplicas is allowed to be 0 if the alpha feature gate HPAScaleToZero is enabled and at least one Object or External metric is configured.  Scaling is active as long as at least one metric value is available.
        /// </summary>
        [Input("minReplicas")]
        public Input<int>? MinReplicas { get; set; }

        /// <summary>
        /// reference to scaled resource; horizontal pod autoscaler will learn the current resource consumption and will set the desired number of pods by using its Scale subresource.
        /// </summary>
        [Input("scaleTargetRef", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ArgoCDSpecServerAutoscaleHpaScaleTargetRefArgs> ScaleTargetRef { get; set; } = null!;

        /// <summary>
        /// target average CPU utilization (represented as a percentage of requested CPU) over all the pods; if not specified the default autoscaling policy will be used.
        /// </summary>
        [Input("targetCPUUtilizationPercentage")]
        public Input<int>? TargetCPUUtilizationPercentage { get; set; }

        public ArgoCDSpecServerAutoscaleHpaArgs()
        {
        }
    }
}