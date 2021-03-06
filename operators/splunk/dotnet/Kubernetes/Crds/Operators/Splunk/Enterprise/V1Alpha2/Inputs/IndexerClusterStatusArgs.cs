// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2
{

    /// <summary>
    /// IndexerClusterStatus defines the observed state of a Splunk Enterprise indexer cluster
    /// </summary>
    public class IndexerClusterStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// current phase of the cluster master
        /// </summary>
        [Input("clusterMasterPhase")]
        public Input<string>? ClusterMasterPhase { get; set; }

        /// <summary>
        /// Indicates if the cluster is ready for indexing.
        /// </summary>
        [Input("indexing_ready_flag")]
        public Input<bool>? Indexing_ready_flag { get; set; }

        /// <summary>
        /// Indicates if the cluster is initialized.
        /// </summary>
        [Input("initialized_flag")]
        public Input<bool>? Initialized_flag { get; set; }

        /// <summary>
        /// Indicates if the cluster is in maintenance mode.
        /// </summary>
        [Input("maintenance_mode")]
        public Input<bool>? Maintenance_mode { get; set; }

        [Input("peers")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.IndexerClusterStatusPeersArgs>? _peers;

        /// <summary>
        /// status of each indexer cluster peer
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.IndexerClusterStatusPeersArgs> Peers
        {
            get => _peers ?? (_peers = new InputList<Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.IndexerClusterStatusPeersArgs>());
            set => _peers = value;
        }

        /// <summary>
        /// current phase of the indexer cluster
        /// </summary>
        [Input("phase")]
        public Input<string>? Phase { get; set; }

        /// <summary>
        /// current number of ready indexer peers
        /// </summary>
        [Input("readyReplicas")]
        public Input<int>? ReadyReplicas { get; set; }

        /// <summary>
        /// desired number of indexer peers
        /// </summary>
        [Input("replicas")]
        public Input<int>? Replicas { get; set; }

        /// <summary>
        /// selector for pods, used by HorizontalPodAutoscaler
        /// </summary>
        [Input("selector")]
        public Input<string>? Selector { get; set; }

        /// <summary>
        /// Indicates whether the master is ready to begin servicing, based on whether it is initialized.
        /// </summary>
        [Input("service_ready_flag")]
        public Input<bool>? Service_ready_flag { get; set; }

        public IndexerClusterStatusArgs()
        {
        }
    }
}
