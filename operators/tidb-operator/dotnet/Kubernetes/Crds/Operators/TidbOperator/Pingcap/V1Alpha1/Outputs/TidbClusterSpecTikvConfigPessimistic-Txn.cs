// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1
{

    [OutputType]
    public sealed class TidbClusterSpecTikvConfigPessimistic-Txn
    {
        public readonly bool Enabled;
        public readonly bool Pipelined;
        public readonly string Wait-for-lock-timeout;
        public readonly string Wake-up-delay-duration;

        [OutputConstructor]
        private TidbClusterSpecTikvConfigPessimistic-Txn(
            bool enabled,

            bool pipelined,

            string wait-for-lock-timeout,

            string wake-up-delay-duration)
        {
            Enabled = enabled;
            Pipelined = pipelined;
            Wait-for-lock-timeout = wait-for-lock-timeout;
            Wake-up-delay-duration = wake-up-delay-duration;
        }
    }
}