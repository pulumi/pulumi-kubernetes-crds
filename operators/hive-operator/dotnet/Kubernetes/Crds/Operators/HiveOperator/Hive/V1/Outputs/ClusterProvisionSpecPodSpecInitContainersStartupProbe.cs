// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Hive.V1
{

    [OutputType]
    public sealed class ClusterProvisionSpecPodSpecInitContainersStartupProbe
    {
        /// <summary>
        /// One and only one of the following should be specified. Exec specifies the action to take.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecPodSpecInitContainersStartupProbeExec Exec;
        /// <summary>
        /// Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.
        /// </summary>
        public readonly int FailureThreshold;
        /// <summary>
        /// HTTPGet specifies the http request to perform.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecPodSpecInitContainersStartupProbeHttpGet HttpGet;
        /// <summary>
        /// Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        /// </summary>
        public readonly int InitialDelaySeconds;
        /// <summary>
        /// How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.
        /// </summary>
        public readonly int PeriodSeconds;
        /// <summary>
        /// Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1.
        /// </summary>
        public readonly int SuccessThreshold;
        /// <summary>
        /// TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported TODO: implement a realistic TCP lifecycle hook
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecPodSpecInitContainersStartupProbeTcpSocket TcpSocket;
        /// <summary>
        /// Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        /// </summary>
        public readonly int TimeoutSeconds;

        [OutputConstructor]
        private ClusterProvisionSpecPodSpecInitContainersStartupProbe(
            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecPodSpecInitContainersStartupProbeExec exec,

            int failureThreshold,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecPodSpecInitContainersStartupProbeHttpGet httpGet,

            int initialDelaySeconds,

            int periodSeconds,

            int successThreshold,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecPodSpecInitContainersStartupProbeTcpSocket tcpSocket,

            int timeoutSeconds)
        {
            Exec = exec;
            FailureThreshold = failureThreshold;
            HttpGet = httpGet;
            InitialDelaySeconds = initialDelaySeconds;
            PeriodSeconds = periodSeconds;
            SuccessThreshold = successThreshold;
            TcpSocket = tcpSocket;
            TimeoutSeconds = timeoutSeconds;
        }
    }
}
