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
    public sealed class ClusterProvisionSpecPodSpecInitContainersLifecyclePreStop
    {
        /// <summary>
        /// One and only one of the following should be specified. Exec specifies the action to take.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecPodSpecInitContainersLifecyclePreStopExec Exec;
        /// <summary>
        /// HTTPGet specifies the http request to perform.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecPodSpecInitContainersLifecyclePreStopHttpGet HttpGet;
        /// <summary>
        /// TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported TODO: implement a realistic TCP lifecycle hook
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecPodSpecInitContainersLifecyclePreStopTcpSocket TcpSocket;

        [OutputConstructor]
        private ClusterProvisionSpecPodSpecInitContainersLifecyclePreStop(
            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecPodSpecInitContainersLifecyclePreStopExec exec,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecPodSpecInitContainersLifecyclePreStopHttpGet httpGet,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecPodSpecInitContainersLifecyclePreStopTcpSocket tcpSocket)
        {
            Exec = exec;
            HttpGet = httpGet;
            TcpSocket = tcpSocket;
        }
    }
}
