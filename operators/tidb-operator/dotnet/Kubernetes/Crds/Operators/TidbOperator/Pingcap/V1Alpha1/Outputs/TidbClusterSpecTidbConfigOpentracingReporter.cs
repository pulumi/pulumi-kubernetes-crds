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
    public sealed class TidbClusterSpecTidbConfigOpentracingReporter
    {
        public readonly int Buffer-flush-interval;
        public readonly string Local-agent-host-port;
        public readonly bool Log-spans;
        public readonly int Queue-size;

        [OutputConstructor]
        private TidbClusterSpecTidbConfigOpentracingReporter(
            int buffer-flush-interval,

            string local-agent-host-port,

            bool log-spans,

            int queue-size)
        {
            Buffer-flush-interval = buffer-flush-interval;
            Local-agent-host-port = local-agent-host-port;
            Log-spans = log-spans;
            Queue-size = queue-size;
        }
    }
}