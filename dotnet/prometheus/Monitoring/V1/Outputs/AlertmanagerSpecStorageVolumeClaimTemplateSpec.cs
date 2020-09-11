// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1
{

    [OutputType]
    public sealed class AlertmanagerSpecStorageVolumeClaimTemplateSpec
    {
        /// <summary>
        /// AccessModes contains the desired access modes the volume should have. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes-1
        /// </summary>
        public readonly ImmutableArray<string> AccessModes;
        /// <summary>
        /// This field requires the VolumeSnapshotDataSource alpha feature gate to be enabled and currently VolumeSnapshot is the only supported data source. If the provisioner can support VolumeSnapshot data source, it will create a new volume and data will be restored to the volume at the same time. If the provisioner does not support VolumeSnapshot data source, volume will not be created and the failure will be reported as an event. In the future, we plan to support more data source types and the behavior of the provisioner may change.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.AlertmanagerSpecStorageVolumeClaimTemplateSpecDataSource DataSource;
        /// <summary>
        /// Resources represents the minimum resources the volume should have. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.AlertmanagerSpecStorageVolumeClaimTemplateSpecResources Resources;
        /// <summary>
        /// A label query over volumes to consider for binding.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.AlertmanagerSpecStorageVolumeClaimTemplateSpecSelector Selector;
        /// <summary>
        /// Name of the StorageClass required by the claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#class-1
        /// </summary>
        public readonly string StorageClassName;
        /// <summary>
        /// volumeMode defines what type of volume is required by the claim. Value of Filesystem is implied when not included in claim spec. This is a beta feature.
        /// </summary>
        public readonly string VolumeMode;
        /// <summary>
        /// VolumeName is the binding reference to the PersistentVolume backing this claim.
        /// </summary>
        public readonly string VolumeName;

        [OutputConstructor]
        private AlertmanagerSpecStorageVolumeClaimTemplateSpec(
            ImmutableArray<string> accessModes,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.AlertmanagerSpecStorageVolumeClaimTemplateSpecDataSource dataSource,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.AlertmanagerSpecStorageVolumeClaimTemplateSpecResources resources,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.AlertmanagerSpecStorageVolumeClaimTemplateSpecSelector selector,

            string storageClassName,

            string volumeMode,

            string volumeName)
        {
            AccessModes = accessModes;
            DataSource = dataSource;
            Resources = resources;
            Selector = selector;
            StorageClassName = storageClassName;
            VolumeMode = volumeMode;
            VolumeName = volumeName;
        }
    }
}
