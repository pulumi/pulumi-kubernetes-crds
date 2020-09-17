// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1
{

    [OutputType]
    public sealed class KafkaSpecKafkaStorageVolumes
    {
        /// <summary>
        /// The storage class to use for dynamic volume allocation.
        /// </summary>
        public readonly string Class;
        /// <summary>
        /// Specifies if the persistent volume claim has to be deleted when the cluster is un-deployed.
        /// </summary>
        public readonly bool DeleteClaim;
        /// <summary>
        /// Storage identification number. It is mandatory only for storage volumes defined in a storage of type 'jbod'.
        /// </summary>
        public readonly int Id;
        /// <summary>
        /// Overrides for individual brokers. The `overrides` field allows to specify a different configuration for different brokers.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaStorageVolumesOverrides> Overrides;
        /// <summary>
        /// Specifies a specific persistent volume to use. It contains key:value pairs representing labels for selecting such a volume.
        /// </summary>
        public readonly ImmutableDictionary<string, object> Selector;
        /// <summary>
        /// When type=persistent-claim, defines the size of the persistent volume claim (i.e 1Gi). Mandatory when type=persistent-claim.
        /// </summary>
        public readonly string Size;
        /// <summary>
        /// When type=ephemeral, defines the total amount of local storage required for this EmptyDir volume (for example 1Gi).
        /// </summary>
        public readonly string SizeLimit;
        /// <summary>
        /// Storage type, must be either 'ephemeral' or 'persistent-claim'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private KafkaSpecKafkaStorageVolumes(
            string @class,

            bool deleteClaim,

            int id,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaStorageVolumesOverrides> overrides,

            ImmutableDictionary<string, object> selector,

            string size,

            string sizeLimit,

            string type)
        {
            Class = @class;
            DeleteClaim = deleteClaim;
            Id = id;
            Overrides = overrides;
            Selector = selector;
            Size = size;
            SizeLimit = sizeLimit;
            Type = type;
        }
    }
}
