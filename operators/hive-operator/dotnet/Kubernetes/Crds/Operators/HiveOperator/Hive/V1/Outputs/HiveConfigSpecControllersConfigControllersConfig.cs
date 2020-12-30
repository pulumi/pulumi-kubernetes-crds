// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Hive.V1
{

    [OutputType]
    public sealed class HiveConfigSpecControllersConfigControllersConfig
    {
        /// <summary>
        /// ClientBurst specifies client rate limiter burst for a controller
        /// </summary>
        public readonly int ClientBurst;
        /// <summary>
        /// ClientQPS specifies client rate limiter QPS for a controller
        /// </summary>
        public readonly int ClientQPS;
        /// <summary>
        /// ConcurrentReconciles specifies number of concurrent reconciles for a controller
        /// </summary>
        public readonly int ConcurrentReconciles;
        /// <summary>
        /// QueueBurst specifies workqueue rate limiter burst for a controller
        /// </summary>
        public readonly int QueueBurst;
        /// <summary>
        /// QueueQPS specifies workqueue rate limiter QPS for a controller
        /// </summary>
        public readonly int QueueQPS;
        /// <summary>
        /// Replicas specifies the number of replicas the specific controller pod should use. This is ONLY for controllers that have been split out into their own pods. This is ignored for all others.
        /// </summary>
        public readonly int Replicas;

        [OutputConstructor]
        private HiveConfigSpecControllersConfigControllersConfig(
            int clientBurst,

            int clientQPS,

            int concurrentReconciles,

            int queueBurst,

            int queueQPS,

            int replicas)
        {
            ClientBurst = clientBurst;
            ClientQPS = clientQPS;
            ConcurrentReconciles = concurrentReconciles;
            QueueBurst = queueBurst;
            QueueQPS = queueQPS;
            Replicas = replicas;
        }
    }
}
