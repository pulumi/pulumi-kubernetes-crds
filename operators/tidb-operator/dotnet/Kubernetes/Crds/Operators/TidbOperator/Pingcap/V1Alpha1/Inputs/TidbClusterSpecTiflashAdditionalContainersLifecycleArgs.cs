// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1
{

    public class TidbClusterSpecTiflashAdditionalContainersLifecycleArgs : Pulumi.ResourceArgs
    {
        [Input("postStart")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashAdditionalContainersLifecyclePostStartArgs>? PostStart { get; set; }

        [Input("preStop")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashAdditionalContainersLifecyclePreStopArgs>? PreStop { get; set; }

        public TidbClusterSpecTiflashAdditionalContainersLifecycleArgs()
        {
        }
    }
}
