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
    public sealed class TidbClusterSpecTidbLifecyclePostStart
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbLifecyclePostStartExec Exec;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbLifecyclePostStartHttpGet HttpGet;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbLifecyclePostStartTcpSocket TcpSocket;

        [OutputConstructor]
        private TidbClusterSpecTidbLifecyclePostStart(
            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbLifecyclePostStartExec exec,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbLifecyclePostStartHttpGet httpGet,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbLifecyclePostStartTcpSocket tcpSocket)
        {
            Exec = exec;
            HttpGet = httpGet;
            TcpSocket = tcpSocket;
        }
    }
}