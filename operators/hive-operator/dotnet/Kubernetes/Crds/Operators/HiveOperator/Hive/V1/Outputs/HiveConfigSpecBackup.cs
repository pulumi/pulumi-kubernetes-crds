// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Hive.V1
{

    [OutputType]
    public sealed class HiveConfigSpecBackup
    {
        /// <summary>
        /// MinBackupPeriodSeconds specifies that a minimum of MinBackupPeriodSeconds will occur in between each backup. This is used to rate limit backups. This potentially batches together multiple changes into 1 backup. No backups will be lost as changes that happen during this interval are queued up and will result in a backup happening once the interval has been completed.
        /// </summary>
        public readonly int MinBackupPeriodSeconds;
        /// <summary>
        /// Velero specifies configuration for the Velero backup integration.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.HiveConfigSpecBackupVelero Velero;

        [OutputConstructor]
        private HiveConfigSpecBackup(
            int minBackupPeriodSeconds,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.HiveConfigSpecBackupVelero velero)
        {
            MinBackupPeriodSeconds = minBackupPeriodSeconds;
            Velero = velero;
        }
    }
}
