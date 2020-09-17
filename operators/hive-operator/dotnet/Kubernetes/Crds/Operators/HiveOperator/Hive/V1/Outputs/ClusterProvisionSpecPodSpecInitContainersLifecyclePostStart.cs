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
    public sealed class ClusterProvisionSpecPodSpecInitContainersLifecyclePostStart
    {
        /// <summary>
        /// One and only one of the following should be specified. Exec specifies the action to take.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecPodSpecInitContainersLifecyclePostStartExec Exec;
        /// <summary>
        /// HTTPGet specifies the http request to perform.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecPodSpecInitContainersLifecyclePostStartHttpGet HttpGet;
        /// <summary>
        /// TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported TODO: implement a realistic TCP lifecycle hook
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecPodSpecInitContainersLifecyclePostStartTcpSocket TcpSocket;

        [OutputConstructor]
        private ClusterProvisionSpecPodSpecInitContainersLifecyclePostStart(
            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecPodSpecInitContainersLifecyclePostStartExec exec,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecPodSpecInitContainersLifecyclePostStartHttpGet httpGet,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecPodSpecInitContainersLifecyclePostStartTcpSocket tcpSocket)
        {
            Exec = exec;
            HttpGet = httpGet;
            TcpSocket = tcpSocket;
        }
    }
}
