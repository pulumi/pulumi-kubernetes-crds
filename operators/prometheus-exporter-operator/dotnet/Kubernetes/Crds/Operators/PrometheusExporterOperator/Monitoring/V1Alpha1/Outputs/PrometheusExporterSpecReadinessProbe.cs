// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1Alpha1
{

    [OutputType]
    public sealed class PrometheusExporterSpecReadinessProbe
    {
        /// <summary>
        /// Override readiness probe failure threshold
        /// </summary>
        public readonly int FailureThreshold;
        /// <summary>
        /// Override readiness probe period (seconds)
        /// </summary>
        public readonly int PeriodSeconds;
        /// <summary>
        /// Override readiness probe success threshold
        /// </summary>
        public readonly int SuccessThreshold;
        /// <summary>
        /// Override readiness probe timeout (seconds)
        /// </summary>
        public readonly int TimeoutSeconds;

        [OutputConstructor]
        private PrometheusExporterSpecReadinessProbe(
            int failureThreshold,

            int periodSeconds,

            int successThreshold,

            int timeoutSeconds)
        {
            FailureThreshold = failureThreshold;
            PeriodSeconds = periodSeconds;
            SuccessThreshold = successThreshold;
            TimeoutSeconds = timeoutSeconds;
        }
    }
}
