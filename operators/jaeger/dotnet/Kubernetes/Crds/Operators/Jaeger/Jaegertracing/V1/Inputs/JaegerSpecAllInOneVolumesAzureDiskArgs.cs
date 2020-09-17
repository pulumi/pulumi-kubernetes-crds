// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1
{

    public class JaegerSpecAllInOneVolumesAzureDiskArgs : Pulumi.ResourceArgs
    {
        [Input("cachingMode")]
        public Input<string>? CachingMode { get; set; }

        [Input("diskName", required: true)]
        public Input<string> DiskName { get; set; } = null!;

        [Input("diskURI", required: true)]
        public Input<string> DiskURI { get; set; } = null!;

        [Input("fsType")]
        public Input<string>? FsType { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        public JaegerSpecAllInOneVolumesAzureDiskArgs()
        {
        }
    }
}
