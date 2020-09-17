// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Migration.V1Alpha1
{

    [OutputType]
    public sealed class MigStorageSpec
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Migration.V1Alpha1.MigStorageSpecBackupStorageConfig BackupStorageConfig;
        public readonly string BackupStorageProvider;
        public readonly Pulumi.Kubernetes.Types.Outputs.Migration.V1Alpha1.MigStorageSpecVolumeSnapshotConfig VolumeSnapshotConfig;
        public readonly string VolumeSnapshotProvider;

        [OutputConstructor]
        private MigStorageSpec(
            Pulumi.Kubernetes.Types.Outputs.Migration.V1Alpha1.MigStorageSpecBackupStorageConfig backupStorageConfig,

            string backupStorageProvider,

            Pulumi.Kubernetes.Types.Outputs.Migration.V1Alpha1.MigStorageSpecVolumeSnapshotConfig volumeSnapshotConfig,

            string volumeSnapshotProvider)
        {
            BackupStorageConfig = backupStorageConfig;
            BackupStorageProvider = backupStorageProvider;
            VolumeSnapshotConfig = volumeSnapshotConfig;
            VolumeSnapshotProvider = volumeSnapshotProvider;
        }
    }
}
