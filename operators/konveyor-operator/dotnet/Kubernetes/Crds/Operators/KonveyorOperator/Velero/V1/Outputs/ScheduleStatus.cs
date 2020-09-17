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
    public sealed class ScheduleStatus
    {
        /// <summary>
        /// LastBackup is the last time a Backup was run for this Schedule schedule
        /// </summary>
        public readonly string LastBackup;
        /// <summary>
        /// Phase is the current phase of the Schedule
        /// </summary>
        public readonly string Phase;
        /// <summary>
        /// ValidationErrors is a slice of all validation errors (if applicable)
        /// </summary>
        public readonly ImmutableArray<string> ValidationErrors;

        [OutputConstructor]
        private ScheduleStatus(
            string lastBackup,

            string phase,

            ImmutableArray<string> validationErrors)
        {
            LastBackup = lastBackup;
            Phase = phase;
            ValidationErrors = validationErrors;
        }
    }
}