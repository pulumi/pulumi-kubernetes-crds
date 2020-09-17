// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1
{

    public class TidbClusterSpecTikvConfigRocksdbArgs : Pulumi.ResourceArgs
    {
        [Input("auto-tuned")]
        public Input<bool>? Auto-tuned { get; set; }

        [Input("bytes-per-sync")]
        public Input<string>? Bytes-per-sync { get; set; }

        [Input("compaction-readahead-size")]
        public Input<string>? Compaction-readahead-size { get; set; }

        [Input("create-if-missing")]
        public Input<bool>? Create-if-missing { get; set; }

        [Input("defaultcf")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTikvConfigRocksdbDefaultcfArgs>? Defaultcf { get; set; }

        [Input("enable-pipelined-write")]
        public Input<bool>? Enable-pipelined-write { get; set; }

        [Input("enable-statistics")]
        public Input<bool>? Enable-statistics { get; set; }

        [Input("info-log-dir")]
        public Input<string>? Info-log-dir { get; set; }

        [Input("info-log-keep-log-file-num")]
        public Input<int>? Info-log-keep-log-file-num { get; set; }

        [Input("info-log-max-size")]
        public Input<string>? Info-log-max-size { get; set; }

        [Input("info-log-roll-time")]
        public Input<string>? Info-log-roll-time { get; set; }

        [Input("lockcf")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTikvConfigRocksdbLockcfArgs>? Lockcf { get; set; }

        [Input("max-background-jobs")]
        public Input<int>? Max-background-jobs { get; set; }

        [Input("max-manifest-file-size")]
        public Input<string>? Max-manifest-file-size { get; set; }

        [Input("max-open-files")]
        public Input<int>? Max-open-files { get; set; }

        [Input("max-sub-compactions")]
        public Input<int>? Max-sub-compactions { get; set; }

        [Input("max-total-wal-size")]
        public Input<string>? Max-total-wal-size { get; set; }

        [Input("raftcf")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTikvConfigRocksdbRaftcfArgs>? Raftcf { get; set; }

        [Input("rate-bytes-per-sec")]
        public Input<string>? Rate-bytes-per-sec { get; set; }

        [Input("rate-limiter-mode")]
        public Input<int>? Rate-limiter-mode { get; set; }

        [Input("stats-dump-period")]
        public Input<string>? Stats-dump-period { get; set; }

        [Input("titan")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTikvConfigRocksdbTitanArgs>? Titan { get; set; }

        [Input("use-direct-io-for-flush-and-compaction")]
        public Input<bool>? Use-direct-io-for-flush-and-compaction { get; set; }

        [Input("wal-bytes-per-sync")]
        public Input<string>? Wal-bytes-per-sync { get; set; }

        [Input("wal-recovery-mode")]
        public Input<int>? Wal-recovery-mode { get; set; }

        [Input("wal-size-limit")]
        public Input<string>? Wal-size-limit { get; set; }

        [Input("wal-ttl-seconds")]
        public Input<int>? Wal-ttl-seconds { get; set; }

        [Input("writable-file-max-buffer-size")]
        public Input<string>? Writable-file-max-buffer-size { get; set; }

        [Input("writecf")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTikvConfigRocksdbWritecfArgs>? Writecf { get; set; }

        public TidbClusterSpecTikvConfigRocksdbArgs()
        {
        }
    }
}