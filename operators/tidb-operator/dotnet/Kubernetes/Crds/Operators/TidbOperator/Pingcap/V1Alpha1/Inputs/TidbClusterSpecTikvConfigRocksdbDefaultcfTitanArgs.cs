// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1
{

    public class TidbClusterSpecTikvConfigRocksdbDefaultcfTitanArgs : Pulumi.ResourceArgs
    {
        [Input("blob-cache-size")]
        public Input<string>? Blob-cache-size { get; set; }

        [Input("blob-file-compression")]
        public Input<string>? Blob-file-compression { get; set; }

        [Input("blob-run-mode")]
        public Input<string>? Blob-run-mode { get; set; }

        [Input("discardable-ratio")]
        public Input<double>? Discardable-ratio { get; set; }

        [Input("gc-merge-rewrite")]
        public Input<bool>? Gc-merge-rewrite { get; set; }

        [Input("level_merge")]
        public Input<bool>? Level_merge { get; set; }

        [Input("max-gc-batch-size")]
        public Input<string>? Max-gc-batch-size { get; set; }

        [Input("merge-small-file-threshold")]
        public Input<string>? Merge-small-file-threshold { get; set; }

        [Input("min-blob-size")]
        public Input<string>? Min-blob-size { get; set; }

        [Input("min-gc-batch-size")]
        public Input<string>? Min-gc-batch-size { get; set; }

        [Input("sample-ratio")]
        public Input<double>? Sample-ratio { get; set; }

        public TidbClusterSpecTikvConfigRocksdbDefaultcfTitanArgs()
        {
        }
    }
}
