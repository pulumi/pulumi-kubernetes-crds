// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2
{

    [OutputType]
    public sealed class IndexerClusterStatus
    {
        /// <summary>
        /// current phase of the cluster master
        /// </summary>
        public readonly string ClusterMasterPhase;
        /// <summary>
        /// Indicates if the cluster is ready for indexing.
        /// </summary>
        public readonly bool Indexing_ready_flag;
        /// <summary>
        /// Indicates if the cluster is initialized.
        /// </summary>
        public readonly bool Initialized_flag;
        /// <summary>
        /// Indicates if the cluster is in maintenance mode.
        /// </summary>
        public readonly bool Maintenance_mode;
        /// <summary>
        /// status of each indexer cluster peer
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.IndexerClusterStatusPeers> Peers;
        /// <summary>
        /// current phase of the indexer cluster
        /// </summary>
        public readonly string Phase;
        /// <summary>
        /// current number of ready indexer peers
        /// </summary>
        public readonly int ReadyReplicas;
        /// <summary>
        /// desired number of indexer peers
        /// </summary>
        public readonly int Replicas;
        /// <summary>
        /// selector for pods, used by HorizontalPodAutoscaler
        /// </summary>
        public readonly string Selector;
        /// <summary>
        /// Indicates whether the master is ready to begin servicing, based on whether it is initialized.
        /// </summary>
        public readonly bool Service_ready_flag;

        [OutputConstructor]
        private IndexerClusterStatus(
            string clusterMasterPhase,

            bool indexing_ready_flag,

            bool initialized_flag,

            bool maintenance_mode,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.IndexerClusterStatusPeers> peers,

            string phase,

            int readyReplicas,

            int replicas,

            string selector,

            bool service_ready_flag)
        {
            ClusterMasterPhase = clusterMasterPhase;
            Indexing_ready_flag = indexing_ready_flag;
            Initialized_flag = initialized_flag;
            Maintenance_mode = maintenance_mode;
            Peers = peers;
            Phase = phase;
            ReadyReplicas = readyReplicas;
            Replicas = replicas;
            Selector = selector;
            Service_ready_flag = service_ready_flag;
        }
    }
}