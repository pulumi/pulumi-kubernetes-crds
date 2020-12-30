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
    public sealed class MigMigrationStatus
    {
        public readonly ImmutableArray<string> Errors;
        public readonly string Itinerary;
        public readonly string ObservedDigest;
        public readonly string Phase;
        public readonly string StartTimestamp;

        [OutputConstructor]
        private MigMigrationStatus(
            ImmutableArray<string> errors,

            string itinerary,

            string observedDigest,

            string phase,

            string startTimestamp)
        {
            Errors = errors;
            Itinerary = itinerary;
            ObservedDigest = observedDigest;
            Phase = phase;
            StartTimestamp = startTimestamp;
        }
    }
}
