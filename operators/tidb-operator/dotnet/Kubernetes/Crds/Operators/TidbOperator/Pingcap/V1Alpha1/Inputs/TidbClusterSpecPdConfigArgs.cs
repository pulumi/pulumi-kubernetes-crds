// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1
{

    public class TidbClusterSpecPdConfigArgs : Pulumi.ResourceArgs
    {
        [Input("auto-compaction-mode")]
        public Input<string>? Auto-compaction-mode { get; set; }

        [Input("auto-compaction-retention-v2")]
        public Input<string>? Auto-compaction-retention-v2 { get; set; }

        [Input("cluster-version")]
        public Input<string>? Cluster-version { get; set; }

        [Input("dashboard")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPdConfigDashboardArgs>? Dashboard { get; set; }

        [Input("election-interval")]
        public Input<string>? Election-interval { get; set; }

        [Input("enable-grpc-gateway")]
        public Input<bool>? Enable-grpc-gateway { get; set; }

        [Input("enable-prevote")]
        public Input<bool>? Enable-prevote { get; set; }

        [Input("force-new-cluster")]
        public Input<bool>? Force-new-cluster { get; set; }

        [Input("label-property")]
        private InputMap<object>? _label-property;
        public InputMap<object> Label-property
        {
            get => _label-property ?? (_label-property = new InputMap<object>());
            set => _label-property = value;
        }

        [Input("lease")]
        public Input<int>? Lease { get; set; }

        [Input("log")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPdConfigLogArgs>? Log { get; set; }

        [Input("log-file")]
        public Input<string>? Log-file { get; set; }

        [Input("log-level")]
        public Input<string>? Log-level { get; set; }

        [Input("metric")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPdConfigMetricArgs>? Metric { get; set; }

        [Input("namespace")]
        private InputMap<object>? _namespace;
        public InputMap<object> Namespace
        {
            get => _namespace ?? (_namespace = new InputMap<object>());
            set => _namespace = value;
        }

        [Input("namespace-classifier")]
        public Input<string>? Namespace-classifier { get; set; }

        [Input("pd-server")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPdConfigPd-ServerArgs>? Pd-server { get; set; }

        [Input("quota-backend-bytes")]
        public Input<string>? Quota-backend-bytes { get; set; }

        [Input("replication")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPdConfigReplicationArgs>? Replication { get; set; }

        [Input("schedule")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPdConfigScheduleArgs>? Schedule { get; set; }

        [Input("security")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPdConfigSecurityArgs>? Security { get; set; }

        [Input("tikv-interval")]
        public Input<string>? Tikv-interval { get; set; }

        [Input("tso-save-interval")]
        public Input<string>? Tso-save-interval { get; set; }

        public TidbClusterSpecPdConfigArgs()
        {
        }
    }
}