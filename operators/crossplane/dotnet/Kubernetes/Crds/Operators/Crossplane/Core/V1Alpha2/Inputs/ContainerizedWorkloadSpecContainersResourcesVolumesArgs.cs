// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2
{

    /// <summary>
    /// VolumeResource required by a container.
    /// </summary>
    public class ContainerizedWorkloadSpecContainersResourcesVolumesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// AccessMode of this volume; RO (read only) or RW (read and write).
        /// </summary>
        [Input("accessMode")]
        public Input<string>? AccessMode { get; set; }

        /// <summary>
        /// Disk requirements of this volume.
        /// </summary>
        [Input("disk")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersResourcesVolumesDiskArgs>? Disk { get; set; }

        /// <summary>
        /// MouthPath at which this volume will be mounted within its container.
        /// </summary>
        [Input("mountPath", required: true)]
        public Input<string> MountPath { get; set; } = null!;

        /// <summary>
        /// Name of this volume. Must be unique within its container.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// SharingPolicy of this volume; Exclusive or Shared.
        /// </summary>
        [Input("sharingPolicy")]
        public Input<string>? SharingPolicy { get; set; }

        public ContainerizedWorkloadSpecContainersResourcesVolumesArgs()
        {
        }
    }
}
