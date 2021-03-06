// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1
{

    public class StorageClusterSpecCloudStorageCapacitySpecsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Maximum capacity for this storage cluster. The total capacity of devices created by this capacity spec should not be greater than this number for the entire cluster.
        /// </summary>
        [Input("maxCapacityInGiB")]
        public Input<int>? MaxCapacityInGiB { get; set; }

        /// <summary>
        /// Minimum capacity for this storage cluster. The total capacity of devices created by this capacity spec should not be less than this number for the entire cluster.
        /// </summary>
        [Input("minCapacityInGiB")]
        public Input<int>? MinCapacityInGiB { get; set; }

        /// <summary>
        /// Minimum IOPS expected from the cloud drive.
        /// </summary>
        [Input("minIOPS")]
        public Input<int>? MinIOPS { get; set; }

        [Input("options")]
        private InputMap<object>? _options;

        /// <summary>
        /// Additional options required to provision the drive in cloud.
        /// </summary>
        public InputMap<object> Options
        {
            get => _options ?? (_options = new InputMap<object>());
            set => _options = value;
        }

        public StorageClusterSpecCloudStorageCapacitySpecsArgs()
        {
        }
    }
}
