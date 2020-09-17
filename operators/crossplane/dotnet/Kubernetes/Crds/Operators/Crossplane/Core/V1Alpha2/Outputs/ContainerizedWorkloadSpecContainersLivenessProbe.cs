// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2
{

    [OutputType]
    public sealed class ContainerizedWorkloadSpecContainersLivenessProbe
    {
        /// <summary>
        /// Exec probes a container's health by executing a command.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersLivenessProbeExec Exec;
        /// <summary>
        /// FailureThreshold specifies how many consecutive probes must fail in order for the container to be considered healthy.
        /// </summary>
        public readonly int FailureThreshold;
        /// <summary>
        /// HTTPGet probes a container's health by sending an HTTP GET request.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersLivenessProbeHttpGet HttpGet;
        /// <summary>
        /// InitialDelaySeconds after a container starts before the first probe.
        /// </summary>
        public readonly int InitialDelaySeconds;
        /// <summary>
        /// PeriodSeconds between probes.
        /// </summary>
        public readonly int PeriodSeconds;
        /// <summary>
        /// SuccessThreshold specifies how many consecutive probes must success in order for the container to be considered healthy.
        /// </summary>
        public readonly int SuccessThreshold;
        /// <summary>
        /// TCPSocketProbe probes a container's health by connecting to a TCP socket.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersLivenessProbeTcpSocket TcpSocket;
        /// <summary>
        /// TimeoutSeconds after which the probe times out.
        /// </summary>
        public readonly int TimeoutSeconds;

        [OutputConstructor]
        private ContainerizedWorkloadSpecContainersLivenessProbe(
            Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersLivenessProbeExec exec,

            int failureThreshold,

            Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersLivenessProbeHttpGet httpGet,

            int initialDelaySeconds,

            int periodSeconds,

            int successThreshold,

            Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersLivenessProbeTcpSocket tcpSocket,

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
