// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1
{

    [OutputType]
    public sealed class KafkaRebalanceSpec
    {
        /// <summary>
        /// The upper bound of ongoing partition replica movements between disks within each broker. Default is 2.
        /// </summary>
        public readonly int ConcurrentIntraBrokerPartitionMovements;
        /// <summary>
        /// The upper bound of ongoing partition leadership movements. Default is 1000.
        /// </summary>
        public readonly int ConcurrentLeaderMovements;
        /// <summary>
        /// The upper bound of ongoing partition replica movements going into/out of each broker. Default is 5.
        /// </summary>
        public readonly int ConcurrentPartitionMovementsPerBroker;
        /// <summary>
        /// A regular expression where any matching topics will be excluded from the calculation of optimization proposals. This expression will be parsed by the java.util.regex.Pattern class; for more information on the supported formar consult the documentation for that class.
        /// </summary>
        public readonly string ExcludedTopics;
        /// <summary>
        /// A list of goals, ordered by decreasing priority, to use for generating and executing the rebalance proposal. The supported goals are available at https://github.com/linkedin/cruise-control#goals. If an empty goals list is provided, the goals declared in the default.goals Cruise Control configuration parameter are used.
        /// </summary>
        public readonly ImmutableArray<string> Goals;
        /// <summary>
        /// A list of strategy class names used to determine the execution order for the replica movements in the generated optimization proposal. By default BaseReplicaMovementStrategy is used, which will execute the replica movements in the order that they were generated.
        /// </summary>
        public readonly ImmutableArray<string> ReplicaMovementStrategies;
        /// <summary>
        /// The upper bound, in bytes per second, on the bandwidth used to move replicas. There is no limit by default.
        /// </summary>
        public readonly int ReplicationThrottle;
        /// <summary>
        /// Whether to allow the hard goals specified in the Kafka CR to be skipped in optimization proposal generation. This can be useful when some of those hard goals are preventing a balance solution being found. Default is false.
        /// </summary>
        public readonly bool SkipHardGoalCheck;

        [OutputConstructor]
        private KafkaRebalanceSpec(
            int concurrentIntraBrokerPartitionMovements,

            int concurrentLeaderMovements,

            int concurrentPartitionMovementsPerBroker,

            string excludedTopics,

            ImmutableArray<string> goals,

            ImmutableArray<string> replicaMovementStrategies,

            int replicationThrottle,

            bool skipHardGoalCheck)
        {
            ConcurrentIntraBrokerPartitionMovements = concurrentIntraBrokerPartitionMovements;
            ConcurrentLeaderMovements = concurrentLeaderMovements;
            ConcurrentPartitionMovementsPerBroker = concurrentPartitionMovementsPerBroker;
            ExcludedTopics = excludedTopics;
            Goals = goals;
            ReplicaMovementStrategies = replicaMovementStrategies;
            ReplicationThrottle = replicationThrottle;
            SkipHardGoalCheck = skipHardGoalCheck;
        }
    }
}
