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
    public sealed class TidbClusterSpecTicdcAdditionalContainersStartupProbeTcpSocket
    {
        public readonly string Host;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTicdcAdditionalContainersStartupProbeTcpSocketPort Port;

        [OutputConstructor]
        private TidbClusterSpecTicdcAdditionalContainersStartupProbeTcpSocket(
            string host,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTicdcAdditionalContainersStartupProbeTcpSocketPort port)
        {
            Host = host;
            Port = port;
        }
    }
}
