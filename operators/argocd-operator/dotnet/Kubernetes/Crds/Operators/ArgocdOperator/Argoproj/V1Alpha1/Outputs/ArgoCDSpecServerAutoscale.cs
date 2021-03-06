// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1
{

    [OutputType]
    public sealed class ArgoCDSpecServerAutoscale
    {
        /// <summary>
        /// Enabled will toggle autoscaling support for the Argo CD Server component.
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// HPA defines the HorizontalPodAutoscaler options for the Argo CD Server component.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecServerAutoscaleHpa Hpa;

        [OutputConstructor]
        private ArgoCDSpecServerAutoscale(
            bool enabled,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecServerAutoscaleHpa hpa)
        {
            Enabled = enabled;
            Hpa = hpa;
        }
    }
}
