// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1Beta1
{

    [OutputType]
    public sealed class KubeFedConfigSpecClusterHealthCheck
    {
        /// <summary>
        /// Minimum consecutive failures for the cluster health to be considered failed after having succeeded.
        /// </summary>
        public readonly int FailureThreshold;
        /// <summary>
        /// How often to monitor the cluster health.
        /// </summary>
        public readonly string Period;
        /// <summary>
        /// Minimum consecutive successes for the cluster health to be considered successful after having failed.
        /// </summary>
        public readonly int SuccessThreshold;
        /// <summary>
        /// Duration after which the cluster health check times out.
        /// </summary>
        public readonly string Timeout;

        [OutputConstructor]
        private KubeFedConfigSpecClusterHealthCheck(
            int failureThreshold,

            string period,

            int successThreshold,

            string timeout)
        {
            FailureThreshold = failureThreshold;
            Period = period;
            SuccessThreshold = successThreshold;
            Timeout = timeout;
        }
    }
}
