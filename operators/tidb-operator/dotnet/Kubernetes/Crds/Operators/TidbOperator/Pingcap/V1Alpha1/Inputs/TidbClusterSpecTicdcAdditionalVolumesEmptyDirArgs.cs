// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1
{

    public class TidbClusterSpecTicdcAdditionalVolumesEmptyDirArgs : Pulumi.ResourceArgs
    {
        [Input("medium")]
        public Input<string>? Medium { get; set; }

        [Input("sizeLimit")]
        public Input<object>? SizeLimit { get; set; }

        public TidbClusterSpecTicdcAdditionalVolumesEmptyDirArgs()
        {
        }
    }
}
