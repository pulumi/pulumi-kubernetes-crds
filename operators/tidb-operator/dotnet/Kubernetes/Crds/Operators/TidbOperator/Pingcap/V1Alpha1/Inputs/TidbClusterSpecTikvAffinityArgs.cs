// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1
{

    public class TidbClusterSpecTikvAffinityArgs : Pulumi.ResourceArgs
    {
        [Input("nodeAffinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTikvAffinityNodeAffinityArgs>? NodeAffinity { get; set; }

        [Input("podAffinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTikvAffinityPodAffinityArgs>? PodAffinity { get; set; }

        [Input("podAntiAffinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTikvAffinityPodAntiAffinityArgs>? PodAntiAffinity { get; set; }

        public TidbClusterSpecTikvAffinityArgs()
        {
        }
    }
}
