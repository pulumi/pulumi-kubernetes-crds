// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1
{

    [OutputType]
    public sealed class ConsoleServiceSpecConsoleServerLivenessProbe
    {
        /// <summary>
        /// Minimum consecutive failures for the probe to be considered failed after having succeeded.
        /// </summary>
        public readonly int FailureThreshold;
        /// <summary>
        /// Number of seconds after the container has started before liveness probes are initiated.
        /// </summary>
        public readonly int InitialDelaySeconds;
        /// <summary>
        /// How often (in seconds) to perform the probe.
        /// </summary>
        public readonly int PeriodSeconds;
        /// <summary>
        /// Minimum consecutive successes for the probe to be considered successful after having failed.
        /// </summary>
        public readonly int SuccessThreshold;
        /// <summary>
        /// Number of seconds after which the probe times out.
        /// </summary>
        public readonly int TimeoutSeconds;

        [OutputConstructor]
        private ConsoleServiceSpecConsoleServerLivenessProbe(
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
