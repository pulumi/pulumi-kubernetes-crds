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
    /// ResticRepositorySpec is the specification for a ResticRepository.
    /// </summary>
    public class ResticRepositorySpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// BackupStorageLocation is the name of the BackupStorageLocation that should contain this repository.
        /// </summary>
        [Input("backupStorageLocation", required: true)]
        public Input<string> BackupStorageLocation { get; set; } = null!;

        /// <summary>
        /// MaintenanceFrequency is how often maintenance should be run.
        /// </summary>
        [Input("maintenanceFrequency", required: true)]
        public Input<string> MaintenanceFrequency { get; set; } = null!;

        /// <summary>
        /// ResticIdentifier is the full restic-compatible string for identifying this repository.
        /// </summary>
        [Input("resticIdentifier", required: true)]
        public Input<string> ResticIdentifier { get; set; } = null!;

        /// <summary>
        /// VolumeNamespace is the namespace this restic repository contains pod volume backups for.
        /// </summary>
        [Input("volumeNamespace", required: true)]
        public Input<string> VolumeNamespace { get; set; } = null!;

        public ResticRepositorySpecArgs()
        {
        }
    }
}
