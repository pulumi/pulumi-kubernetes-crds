// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1
{

    [OutputType]
    public sealed class PrometheusSpecContainersLifecyclePreStop
    {
        /// <summary>
        /// One and only one of the following should be specified. Exec specifies the action to take.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecContainersLifecyclePreStopExec Exec;
        /// <summary>
        /// HTTPGet specifies the http request to perform.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecContainersLifecyclePreStopHttpGet HttpGet;
        /// <summary>
        /// TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported TODO: implement a realistic TCP lifecycle hook
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecContainersLifecyclePreStopTcpSocket TcpSocket;

        [OutputConstructor]
        private PrometheusSpecContainersLifecyclePreStop(
            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecContainersLifecyclePreStopExec exec,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecContainersLifecyclePreStopHttpGet httpGet,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecContainersLifecyclePreStopTcpSocket tcpSocket)
        {
            Exec = exec;
            HttpGet = httpGet;
            TcpSocket = tcpSocket;
        }
    }
}
