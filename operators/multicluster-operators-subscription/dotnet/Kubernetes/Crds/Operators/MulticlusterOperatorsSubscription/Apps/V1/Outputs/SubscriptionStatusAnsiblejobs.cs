// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Apps.V1
{

    [OutputType]
    public sealed class SubscriptionStatusAnsiblejobs
    {
        public readonly string Lastposthookjob;
        public readonly string Lastprehookjob;
        public readonly ImmutableArray<string> Posthookjobshistory;
        public readonly ImmutableArray<string> Prehookjobshistory;

        [OutputConstructor]
        private SubscriptionStatusAnsiblejobs(
            string lastposthookjob,

            string lastprehookjob,

            ImmutableArray<string> posthookjobshistory,

            ImmutableArray<string> prehookjobshistory)
        {
            Lastposthookjob = lastposthookjob;
            Lastprehookjob = lastprehookjob;
            Posthookjobshistory = posthookjobshistory;
            Prehookjobshistory = prehookjobshistory;
        }
    }
}