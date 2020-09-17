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
    /// FC represents a Fibre Channel resource that is attached to a kubelet's host machine and then exposed to the pod.
    /// </summary>
    public class StandaloneSpecVolumesFcArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. TODO: how do we prevent errors in the filesystem from compromising the machine
        /// </summary>
        [Input("fsType")]
        public Input<string>? FsType { get; set; }

        /// <summary>
        /// Optional: FC target lun number
        /// </summary>
        [Input("lun")]
        public Input<int>? Lun { get; set; }

        /// <summary>
        /// Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
        /// </summary>
        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        [Input("targetWWNs")]
        private InputList<string>? _targetWWNs;

        /// <summary>
        /// Optional: FC target worldwide names (WWNs)
        /// </summary>
        public InputList<string> TargetWWNs
        {
            get => _targetWWNs ?? (_targetWWNs = new InputList<string>());
            set => _targetWWNs = value;
        }

        [Input("wwids")]
        private InputList<string>? _wwids;

        /// <summary>
        /// Optional: FC volume world wide identifiers (wwids) Either wwids or combination of targetWWNs and lun must be set, but not both simultaneously.
        /// </summary>
        public InputList<string> Wwids
        {
            get => _wwids ?? (_wwids = new InputList<string>());
            set => _wwids = value;
        }

        public StandaloneSpecVolumesFcArgs()
        {
        }
    }
}
