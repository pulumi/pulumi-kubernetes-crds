// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1
{

    [OutputType]
    public sealed class TidbMonitorSpecAdditionalContainersLifecyclePostStart
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbMonitorSpecAdditionalContainersLifecyclePostStartExec Exec;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbMonitorSpecAdditionalContainersLifecyclePostStartHttpGet HttpGet;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbMonitorSpecAdditionalContainersLifecyclePostStartTcpSocket TcpSocket;

        [OutputConstructor]
        private TidbMonitorSpecAdditionalContainersLifecyclePostStart(
            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbMonitorSpecAdditionalContainersLifecyclePostStartExec exec,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbMonitorSpecAdditionalContainersLifecyclePostStartHttpGet httpGet,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbMonitorSpecAdditionalContainersLifecyclePostStartTcpSocket tcpSocket)
        {
            Exec = exec;
            HttpGet = httpGet;
            TcpSocket = tcpSocket;
        }
    }
}
