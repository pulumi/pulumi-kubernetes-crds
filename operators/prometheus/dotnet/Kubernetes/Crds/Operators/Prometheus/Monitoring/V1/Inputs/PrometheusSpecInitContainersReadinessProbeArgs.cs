// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1
{

    /// <summary>
    /// Periodic probe of container service readiness. Container will be removed from service endpoints if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
    /// </summary>
    public class PrometheusSpecInitContainersReadinessProbeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// One and only one of the following should be specified. Exec specifies the action to take.
        /// </summary>
        [Input("exec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.PrometheusSpecInitContainersReadinessProbeExecArgs>? Exec { get; set; }

        /// <summary>
        /// Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.
        /// </summary>
        [Input("failureThreshold")]
        public Input<int>? FailureThreshold { get; set; }

        /// <summary>
        /// HTTPGet specifies the http request to perform.
        /// </summary>
        [Input("httpGet")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.PrometheusSpecInitContainersReadinessProbeHttpGetArgs>? HttpGet { get; set; }

        /// <summary>
        /// Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        /// </summary>
        [Input("initialDelaySeconds")]
        public Input<int>? InitialDelaySeconds { get; set; }

        /// <summary>
        /// How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.
        /// </summary>
        [Input("periodSeconds")]
        public Input<int>? PeriodSeconds { get; set; }

        /// <summary>
        /// Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1.
        /// </summary>
        [Input("successThreshold")]
        public Input<int>? SuccessThreshold { get; set; }

        /// <summary>
        /// TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported TODO: implement a realistic TCP lifecycle hook
        /// </summary>
        [Input("tcpSocket")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.PrometheusSpecInitContainersReadinessProbeTcpSocketArgs>? TcpSocket { get; set; }

        /// <summary>
        /// Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        /// </summary>
        [Input("timeoutSeconds")]
        public Input<int>? TimeoutSeconds { get; set; }

        public PrometheusSpecInitContainersReadinessProbeArgs()
        {
        }
    }
}
