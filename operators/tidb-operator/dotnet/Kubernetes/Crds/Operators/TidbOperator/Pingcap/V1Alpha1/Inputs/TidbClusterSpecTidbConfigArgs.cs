// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1
{

    public class TidbClusterSpecTidbConfigArgs : Pulumi.ResourceArgs
    {
        [Input("alter-primary-key")]
        public Input<bool>? Alter-primary-key { get; set; }

        [Input("binlog")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTidbConfigBinlogArgs>? Binlog { get; set; }

        [Input("check-mb4-value-in-utf8")]
        public Input<bool>? Check-mb4-value-in-utf8 { get; set; }

        [Input("compatible-kill-query")]
        public Input<bool>? Compatible-kill-query { get; set; }

        [Input("cors")]
        public Input<string>? Cors { get; set; }

        [Input("delay-clean-table-lock")]
        public Input<int>? Delay-clean-table-lock { get; set; }

        [Input("enable-batch-dml")]
        public Input<bool>? Enable-batch-dml { get; set; }

        [Input("enable-dynamic-config")]
        public Input<bool>? Enable-dynamic-config { get; set; }

        [Input("enable-streaming")]
        public Input<bool>? Enable-streaming { get; set; }

        [Input("enable-table-lock")]
        public Input<bool>? Enable-table-lock { get; set; }

        [Input("enable-telemetry")]
        public Input<bool>? Enable-telemetry { get; set; }

        [Input("experimental")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTidbConfigExperimentalArgs>? Experimental { get; set; }

        [Input("isolation-read")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTidbConfigIsolation-ReadArgs>? Isolation-read { get; set; }

        [Input("lease")]
        public Input<string>? Lease { get; set; }

        [Input("log")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTidbConfigLogArgs>? Log { get; set; }

        [Input("lower-case-table-names")]
        public Input<int>? Lower-case-table-names { get; set; }

        [Input("max-server-connections")]
        public Input<int>? Max-server-connections { get; set; }

        [Input("mem-quota-query")]
        public Input<int>? Mem-quota-query { get; set; }

        [Input("new_collations_enabled_on_first_bootstrap")]
        public Input<bool>? New_collations_enabled_on_first_bootstrap { get; set; }

        [Input("oom-action")]
        public Input<string>? Oom-action { get; set; }

        [Input("oom-use-tmp-storage")]
        public Input<bool>? Oom-use-tmp-storage { get; set; }

        [Input("opentracing")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTidbConfigOpentracingArgs>? Opentracing { get; set; }

        [Input("performance")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTidbConfigPerformanceArgs>? Performance { get; set; }

        [Input("pessimistic-txn")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTidbConfigPessimistic-TxnArgs>? Pessimistic-txn { get; set; }

        [Input("plugin")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTidbConfigPluginArgs>? Plugin { get; set; }

        [Input("prepared-plan-cache")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTidbConfigPrepared-Plan-CacheArgs>? Prepared-plan-cache { get; set; }

        [Input("proxy-protocol")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTidbConfigProxy-ProtocolArgs>? Proxy-protocol { get; set; }

        [Input("repair-mode")]
        public Input<bool>? Repair-mode { get; set; }

        [Input("repair-table-list")]
        private InputList<string>? _repair-table-list;
        public InputList<string> Repair-table-list
        {
            get => _repair-table-list ?? (_repair-table-list = new InputList<string>());
            set => _repair-table-list = value;
        }

        [Input("run-ddl")]
        public Input<bool>? Run-ddl { get; set; }

        [Input("security")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTidbConfigSecurityArgs>? Security { get; set; }

        [Input("socket")]
        public Input<string>? Socket { get; set; }

        [Input("split-region-max-num")]
        public Input<int>? Split-region-max-num { get; set; }

        [Input("split-table")]
        public Input<bool>? Split-table { get; set; }

        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTidbConfigStatusArgs>? Status { get; set; }

        [Input("stmt-summary")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTidbConfigStmt-SummaryArgs>? Stmt-summary { get; set; }

        [Input("tikv-client")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTidbConfigTikv-ClientArgs>? Tikv-client { get; set; }

        [Input("tmp-storage-path")]
        public Input<string>? Tmp-storage-path { get; set; }

        [Input("tmp-storage-quota")]
        public Input<int>? Tmp-storage-quota { get; set; }

        [Input("token-limit")]
        public Input<int>? Token-limit { get; set; }

        [Input("treat-old-version-utf8-as-utf8mb4")]
        public Input<bool>? Treat-old-version-utf8-as-utf8mb4 { get; set; }

        [Input("txn-local-latches")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTidbConfigTxn-Local-LatchesArgs>? Txn-local-latches { get; set; }

        public TidbClusterSpecTidbConfigArgs()
        {
        }
    }
}