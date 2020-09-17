// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1
{

    public class BackupScheduleSpecBackupTemplateBrArgs : Pulumi.ResourceArgs
    {
        [Input("checksum")]
        public Input<bool>? Checksum { get; set; }

        [Input("cluster", required: true)]
        public Input<string> Cluster { get; set; } = null!;

        [Input("clusterNamespace")]
        public Input<string>? ClusterNamespace { get; set; }

        [Input("concurrency")]
        public Input<int>? Concurrency { get; set; }

        [Input("db")]
        public Input<string>? Db { get; set; }

        [Input("logLevel")]
        public Input<string>? LogLevel { get; set; }

        [Input("onLine")]
        public Input<bool>? OnLine { get; set; }

        [Input("rateLimit")]
        public Input<int>? RateLimit { get; set; }

        [Input("sendCredToTikv")]
        public Input<bool>? SendCredToTikv { get; set; }

        [Input("statusAddr")]
        public Input<string>? StatusAddr { get; set; }

        [Input("table")]
        public Input<string>? Table { get; set; }

        [Input("timeAgo")]
        public Input<string>? TimeAgo { get; set; }

        public BackupScheduleSpecBackupTemplateBrArgs()
        {
        }
    }
}
