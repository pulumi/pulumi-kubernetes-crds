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
    public sealed class RestoreSpecBr
    {
        public readonly bool Checksum;
        public readonly string Cluster;
        public readonly string ClusterNamespace;
        public readonly int Concurrency;
        public readonly string Db;
        public readonly string LogLevel;
        public readonly bool OnLine;
        public readonly ImmutableArray<string> Options;
        public readonly int RateLimit;
        public readonly bool SendCredToTikv;
        public readonly string StatusAddr;
        public readonly string Table;
        public readonly string TimeAgo;

        [OutputConstructor]
        private RestoreSpecBr(
            bool checksum,

            string cluster,

            string clusterNamespace,

            int concurrency,

            string db,

            string logLevel,

            bool onLine,

            ImmutableArray<string> options,

            int rateLimit,

            bool sendCredToTikv,

            string statusAddr,

            string table,

            string timeAgo)
        {
            Checksum = checksum;
            Cluster = cluster;
            ClusterNamespace = clusterNamespace;
            Concurrency = concurrency;
            Db = db;
            LogLevel = logLevel;
            OnLine = onLine;
            Options = options;
            RateLimit = rateLimit;
            SendCredToTikv = sendCredToTikv;
            StatusAddr = statusAddr;
            Table = table;
            TimeAgo = timeAgo;
        }
    }
}
