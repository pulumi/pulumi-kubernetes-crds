// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1
{

    public class TidbClusterSpecTikvConfigPessimistic-TxnArgs : Pulumi.ResourceArgs
    {
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("pipelined")]
        public Input<bool>? Pipelined { get; set; }

        [Input("wait-for-lock-timeout")]
        public Input<string>? Wait-for-lock-timeout { get; set; }

        [Input("wake-up-delay-duration")]
        public Input<string>? Wake-up-delay-duration { get; set; }

        public TidbClusterSpecTikvConfigPessimistic-TxnArgs()
        {
        }
    }
}