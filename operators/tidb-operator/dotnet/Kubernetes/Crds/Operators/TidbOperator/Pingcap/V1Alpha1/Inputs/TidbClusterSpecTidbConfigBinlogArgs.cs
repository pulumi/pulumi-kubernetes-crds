// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1
{

    public class TidbClusterSpecTidbConfigBinlogArgs : Pulumi.ResourceArgs
    {
        [Input("binlog-socket")]
        public Input<string>? Binlog-socket { get; set; }

        [Input("enable")]
        public Input<bool>? Enable { get; set; }

        [Input("ignore-error")]
        public Input<bool>? Ignore-error { get; set; }

        [Input("strategy")]
        public Input<string>? Strategy { get; set; }

        [Input("write-timeout")]
        public Input<string>? Write-timeout { get; set; }

        public TidbClusterSpecTidbConfigBinlogArgs()
        {
        }
    }
}
