// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Infinispan.V2Alpha1
{

    [OutputType]
    public sealed class BackupStatus
    {
        /// <summary>
        /// State indicates the current state of the backup operation
        /// </summary>
        public readonly string Phase;
        /// <summary>
        /// The name of the created PersistentVolumeClaim used to store the backup
        /// </summary>
        public readonly string Pvc;
        /// <summary>
        /// Reason indicates the reason for any backup related failures.
        /// </summary>
        public readonly string Reason;

        [OutputConstructor]
        private BackupStatus(
            string phase,

            string pvc,

            string reason)
        {
            Phase = phase;
            Pvc = pvc;
            Reason = reason;
        }
    }
}
