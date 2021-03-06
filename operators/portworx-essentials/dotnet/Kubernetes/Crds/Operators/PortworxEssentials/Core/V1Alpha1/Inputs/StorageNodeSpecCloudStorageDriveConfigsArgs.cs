// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha1
{

    public class StorageNodeSpecCloudStorageDriveConfigsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// IOPS required from the cloud drive.
        /// </summary>
        [Input("iops")]
        public Input<int>? Iops { get; set; }

        [Input("options")]
        private InputMap<object>? _options;

        /// <summary>
        /// Additional options for the cloud drive.
        /// </summary>
        public InputMap<object> Options
        {
            get => _options ?? (_options = new InputMap<object>());
            set => _options = value;
        }

        /// <summary>
        /// Size of cloud drive in GiB.
        /// </summary>
        [Input("sizeInGiB")]
        public Input<int>? SizeInGiB { get; set; }

        /// <summary>
        /// Type of cloud drive.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public StorageNodeSpecCloudStorageDriveConfigsArgs()
        {
        }
    }
}
