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
    public sealed class TidbClusterSpecTidbConfigStatus
    {
        public readonly string Metrics-addr;
        public readonly int Metrics-interval;
        public readonly bool Record-db-qps;
        public readonly bool Report-status;

        [OutputConstructor]
        private TidbClusterSpecTidbConfigStatus(
            string metrics-addr,

            int metrics-interval,

            bool record-db-qps,

            bool report-status)
        {
            Metrics-addr = metrics-addr;
            Metrics-interval = metrics-interval;
            Record-db-qps = record-db-qps;
            Report-status = report-status;
        }
    }
}