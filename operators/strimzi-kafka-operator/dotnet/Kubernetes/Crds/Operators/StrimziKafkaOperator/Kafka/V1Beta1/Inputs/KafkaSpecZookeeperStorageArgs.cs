// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1
{

    /// <summary>
    /// Storage configuration (disk). Cannot be updated.
    /// </summary>
    public class KafkaSpecZookeeperStorageArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The storage class to use for dynamic volume allocation.
        /// </summary>
        [Input("class")]
        public Input<string>? Class { get; set; }

        /// <summary>
        /// Specifies if the persistent volume claim has to be deleted when the cluster is un-deployed.
        /// </summary>
        [Input("deleteClaim")]
        public Input<bool>? DeleteClaim { get; set; }

        /// <summary>
        /// Storage identification number. It is mandatory only for storage volumes defined in a storage of type 'jbod'.
        /// </summary>
        [Input("id")]
        public Input<int>? Id { get; set; }

        [Input("overrides")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecZookeeperStorageOverridesArgs>? _overrides;

        /// <summary>
        /// Overrides for individual brokers. The `overrides` field allows to specify a different configuration for different brokers.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecZookeeperStorageOverridesArgs> Overrides
        {
            get => _overrides ?? (_overrides = new InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecZookeeperStorageOverridesArgs>());
            set => _overrides = value;
        }

        [Input("selector")]
        private InputMap<object>? _selector;

        /// <summary>
        /// Specifies a specific persistent volume to use. It contains key:value pairs representing labels for selecting such a volume.
        /// </summary>
        public InputMap<object> Selector
        {
            get => _selector ?? (_selector = new InputMap<object>());
            set => _selector = value;
        }

        /// <summary>
        /// When type=persistent-claim, defines the size of the persistent volume claim (i.e 1Gi). Mandatory when type=persistent-claim.
        /// </summary>
        [Input("size")]
        public Input<string>? Size { get; set; }

        /// <summary>
        /// When type=ephemeral, defines the total amount of local storage required for this EmptyDir volume (for example 1Gi).
        /// </summary>
        [Input("sizeLimit")]
        public Input<string>? SizeLimit { get; set; }

        /// <summary>
        /// Storage type, must be either 'ephemeral' or 'persistent-claim'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public KafkaSpecZookeeperStorageArgs()
        {
        }
    }
}