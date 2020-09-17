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
    public sealed class TidbClusterAutoScalerSpecTikvExternalEndpoint
    {
        public readonly string Host;
        public readonly string Path;
        public readonly int Port;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterAutoScalerSpecTikvExternalEndpointTlsSecret TlsSecret;

        [OutputConstructor]
        private TidbClusterAutoScalerSpecTikvExternalEndpoint(
            string host,

            string path,

            int port,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterAutoScalerSpecTikvExternalEndpointTlsSecret tlsSecret)
        {
            Host = host;
            Path = path;
            Port = port;
            TlsSecret = tlsSecret;
        }
    }
}
