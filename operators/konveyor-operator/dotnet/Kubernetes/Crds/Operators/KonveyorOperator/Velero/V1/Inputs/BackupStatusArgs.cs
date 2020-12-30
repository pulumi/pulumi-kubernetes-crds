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
    /// BackupStatus captures the current status of a Velero backup.
    /// </summary>
    public class BackupStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// CompletionTimestamp records the time a backup was completed. Completion time is recorded even on failed backups. Completion time is recorded before uploading the backup object. The server's time is used for CompletionTimestamps
        /// </summary>
        [Input("completionTimestamp")]
        public Input<string>? CompletionTimestamp { get; set; }

        /// <summary>
        /// Errors is a count of all error messages that were generated during execution of the backup.  The actual errors are in the backup's log file in object storage.
        /// </summary>
        [Input("errors")]
        public Input<int>? Errors { get; set; }

        /// <summary>
        /// Expiration is when this Backup is eligible for garbage-collection.
        /// </summary>
        [Input("expiration")]
        public Input<string>? Expiration { get; set; }

        /// <summary>
        /// FormatVersion is the backup format version, including major, minor, and patch version.
        /// </summary>
        [Input("formatVersion")]
        public Input<string>? FormatVersion { get; set; }

        /// <summary>
        /// Phase is the current state of the Backup.
        /// </summary>
        [Input("phase")]
        public Input<string>? Phase { get; set; }

        /// <summary>
        /// Progress contains information about the backup's execution progress. Note that this information is best-effort only -- if Velero fails to update it during a backup for any reason, it may be inaccurate/stale.
        /// </summary>
        [Input("progress")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Velero.V1.BackupStatusProgressArgs>? Progress { get; set; }

        /// <summary>
        /// StartTimestamp records the time a backup was started. Separate from CreationTimestamp, since that value changes on restores. The server's time is used for StartTimestamps
        /// </summary>
        [Input("startTimestamp")]
        public Input<string>? StartTimestamp { get; set; }

        [Input("validationErrors")]
        private InputList<string>? _validationErrors;

        /// <summary>
        /// ValidationErrors is a slice of all validation errors (if applicable).
        /// </summary>
        public InputList<string> ValidationErrors
        {
            get => _validationErrors ?? (_validationErrors = new InputList<string>());
            set => _validationErrors = value;
        }

        /// <summary>
        /// Version is the backup format major version. Deprecated: Please see FormatVersion
        /// </summary>
        [Input("version")]
        public Input<int>? Version { get; set; }

        /// <summary>
        /// VolumeSnapshotsAttempted is the total number of attempted volume snapshots for this backup.
        /// </summary>
        [Input("volumeSnapshotsAttempted")]
        public Input<int>? VolumeSnapshotsAttempted { get; set; }

        /// <summary>
        /// VolumeSnapshotsCompleted is the total number of successfully completed volume snapshots for this backup.
        /// </summary>
        [Input("volumeSnapshotsCompleted")]
        public Input<int>? VolumeSnapshotsCompleted { get; set; }

        /// <summary>
        /// Warnings is a count of all warning messages that were generated during execution of the backup. The actual warnings are in the backup's log file in object storage.
        /// </summary>
        [Input("warnings")]
        public Input<int>? Warnings { get; set; }

        public BackupStatusArgs()
        {
        }
    }
}
