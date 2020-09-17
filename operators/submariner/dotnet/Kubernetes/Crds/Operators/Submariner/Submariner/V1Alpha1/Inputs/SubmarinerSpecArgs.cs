// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Submariner.V1Alpha1
{

    /// <summary>
    /// SubmarinerSpec defines the desired state of Submariner
    /// </summary>
    public class SubmarinerSpecArgs : Pulumi.ResourceArgs
    {
        [Input("broker", required: true)]
        public Input<string> Broker { get; set; } = null!;

        [Input("brokerK8sApiServer", required: true)]
        public Input<string> BrokerK8sApiServer { get; set; } = null!;

        [Input("brokerK8sApiServerToken", required: true)]
        public Input<string> BrokerK8sApiServerToken { get; set; } = null!;

        [Input("brokerK8sCA", required: true)]
        public Input<string> BrokerK8sCA { get; set; } = null!;

        [Input("brokerK8sRemoteNamespace", required: true)]
        public Input<string> BrokerK8sRemoteNamespace { get; set; } = null!;

        [Input("cableDriver")]
        public Input<string>? CableDriver { get; set; }

        [Input("ceIPSecDebug", required: true)]
        public Input<bool> CeIPSecDebug { get; set; } = null!;

        [Input("ceIPSecIKEPort")]
        public Input<int>? CeIPSecIKEPort { get; set; }

        [Input("ceIPSecNATTPort")]
        public Input<int>? CeIPSecNATTPort { get; set; }

        [Input("ceIPSecPSK", required: true)]
        public Input<string> CeIPSecPSK { get; set; } = null!;

        [Input("clusterCIDR", required: true)]
        public Input<string> ClusterCIDR { get; set; } = null!;

        [Input("clusterID", required: true)]
        public Input<string> ClusterID { get; set; } = null!;

        [Input("colorCodes")]
        public Input<string>? ColorCodes { get; set; }

        [Input("debug", required: true)]
        public Input<bool> Debug { get; set; } = null!;

        [Input("globalCIDR")]
        public Input<string>? GlobalCIDR { get; set; }

        [Input("namespace", required: true)]
        public Input<string> Namespace { get; set; } = null!;

        [Input("natEnabled", required: true)]
        public Input<bool> NatEnabled { get; set; } = null!;

        [Input("repository")]
        public Input<string>? Repository { get; set; }

        [Input("serviceCIDR", required: true)]
        public Input<string> ServiceCIDR { get; set; } = null!;

        [Input("serviceDiscoveryEnabled")]
        public Input<bool>? ServiceDiscoveryEnabled { get; set; }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public SubmarinerSpecArgs()
        {
        }
    }
}
