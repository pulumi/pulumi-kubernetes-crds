// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1
{

    public class TidbClusterSpecTikvAdditionalVolumesFlockerArgs : Pulumi.ResourceArgs
    {
        [Input("datasetName")]
        public Input<string>? DatasetName { get; set; }

        [Input("datasetUUID")]
        public Input<string>? DatasetUUID { get; set; }

        public TidbClusterSpecTikvAdditionalVolumesFlockerArgs()
        {
        }
    }
}