// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1
{

    public class TidbClusterSpecTiflashAdditionalContainersLivenessProbeTcpSocketArgs : Pulumi.ResourceArgs
    {
        [Input("host")]
        public Input<string>? Host { get; set; }

        [Input("port", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashAdditionalContainersLivenessProbeTcpSocketPortArgs> Port { get; set; } = null!;

        public TidbClusterSpecTiflashAdditionalContainersLivenessProbeTcpSocketArgs()
        {
        }
    }
}
