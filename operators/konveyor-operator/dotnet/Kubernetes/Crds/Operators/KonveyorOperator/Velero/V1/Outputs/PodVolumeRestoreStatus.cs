// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Velero.V1
{

    [OutputType]
    public sealed class PodVolumeRestoreStatus
    {
        /// <summary>
        /// CompletionTimestamp records the time a restore was completed. Completion time is recorded even on failed restores. The server's time is used for CompletionTimestamps
        /// </summary>
        public readonly string CompletionTimestamp;
        /// <summary>
        /// Errors is a count of all error messages that were generated during execution of the pod volume restore. The actual errors are in the restic log
        /// </summary>
        public readonly int Errors;
        /// <summary>
        /// Message is a message about the pod volume restore's status.
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// Phase is the current state of the PodVolumeRestore.
        /// </summary>
        public readonly string Phase;
        /// <summary>
        /// Progress holds the total number of bytes of the snapshot and the current number of restored bytes. This can be used to display progress information about the restore operation.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Velero.V1.PodVolumeRestoreStatusProgress Progress;
        /// <summary>
        /// ResticPod is the name of the restic pod which processed the restore. Any errors referenced in Errors or VerifyErrors will be logged in this pod's log.
        /// </summary>
        public readonly string ResticPod;
        /// <summary>
        /// StartTimestamp records the time a restore was started. The server's time is used for StartTimestamps
        /// </summary>
        public readonly string StartTimestamp;
        /// <summary>
        /// VerifyErrors is a count of all verification-related error messages that were generated during execution of the pod volume restore. The actual errors are in the restic log
        /// </summary>
        public readonly int VerifyErrors;

        [OutputConstructor]
        private PodVolumeRestoreStatus(
            string completionTimestamp,

            int errors,

            string message,

            string phase,

            Pulumi.Kubernetes.Types.Outputs.Velero.V1.PodVolumeRestoreStatusProgress progress,

            string resticPod,

            string startTimestamp,

            int verifyErrors)
        {
            CompletionTimestamp = completionTimestamp;
            Errors = errors;
            Message = message;
            Phase = phase;
            Progress = progress;
            ResticPod = resticPod;
            StartTimestamp = startTimestamp;
            VerifyErrors = verifyErrors;
        }
    }
}