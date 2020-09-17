// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1
{

    [OutputType]
    public sealed class KafkaMirrorMaker2SpecLivenessProbe
    {
        /// <summary>
        /// Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.
        /// </summary>
        public readonly int FailureThreshold;
        /// <summary>
        /// The initial delay before first the health is first checked.
        /// </summary>
        public readonly int InitialDelaySeconds;
        /// <summary>
        /// How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.
        /// </summary>
        public readonly int PeriodSeconds;
        /// <summary>
        /// Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness. Minimum value is 1.
        /// </summary>
        public readonly int SuccessThreshold;
        /// <summary>
        /// The timeout for each attempted health check.
        /// </summary>
        public readonly int TimeoutSeconds;

        [OutputConstructor]
        private KafkaMirrorMaker2SpecLivenessProbe(
            int failureThreshold,

            int initialDelaySeconds,

            int periodSeconds,

            int successThreshold,

            int timeoutSeconds)
        {
            FailureThreshold = failureThreshold;
            InitialDelaySeconds = initialDelaySeconds;
            PeriodSeconds = periodSeconds;
            SuccessThreshold = successThreshold;
            TimeoutSeconds = timeoutSeconds;
        }
    }
}
