// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Velero.V1
{

    /// <summary>
    /// VolumeSnapshotLocationSpec defines the specification for a Velero VolumeSnapshotLocation.
    /// </summary>
    public class VolumeSnapshotLocationSpecArgs : Pulumi.ResourceArgs
    {
        [Input("config")]
        private InputMap<string>? _config;

        /// <summary>
        /// Config is for provider-specific configuration fields.
        /// </summary>
        public InputMap<string> Config
        {
            get => _config ?? (_config = new InputMap<string>());
            set => _config = value;
        }

        /// <summary>
        /// Provider is the provider of the volume storage.
        /// </summary>
        [Input("provider", required: true)]
        public Input<string> Provider { get; set; } = null!;

        public VolumeSnapshotLocationSpecArgs()
        {
        }
    }
}