// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Snapscheduler.V1
{

    [OutputType]
    public sealed class SnapshotScheduleSpecRetention
    {
        /// <summary>
        /// Expires is the length of time (time.Duration) after which a given Snapshot will be deleted.
        /// </summary>
        public readonly string Expires;
        public readonly int MaxCount;

        [OutputConstructor]
        private SnapshotScheduleSpecRetention(
            string expires,

            int maxCount)
        {
            Expires = expires;
            MaxCount = maxCount;
        }
    }
}
