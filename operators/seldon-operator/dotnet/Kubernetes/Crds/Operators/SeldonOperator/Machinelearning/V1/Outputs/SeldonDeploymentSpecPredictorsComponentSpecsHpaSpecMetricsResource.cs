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
    public sealed class SeldonDeploymentSpecPredictorsComponentSpecsHpaSpecMetricsResource
    {
        /// <summary>
        /// name is the name of the resource in question.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// targetAverageUtilization is the target value of the average of the resource metric across all relevant pods, represented as a percentage of the requested value of the resource for the pods.
        /// </summary>
        public readonly int TargetAverageUtilization;
        /// <summary>
        /// targetAverageValue is the target value of the average of the resource metric across all relevant pods, as a raw value (instead of as a percentage of the request), similar to the "pods" metric source type.
        /// </summary>
        public readonly string TargetAverageValue;

        [OutputConstructor]
        private SeldonDeploymentSpecPredictorsComponentSpecsHpaSpecMetricsResource(
            string name,

            int targetAverageUtilization,

            string targetAverageValue)
        {
            Name = name;
            TargetAverageUtilization = targetAverageUtilization;
            TargetAverageValue = targetAverageValue;
        }
    }
}
