// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Maistra.V2
{

    [OutputType]
    public sealed class ServiceMeshControlPlaneSpecTelemetryMixerBatching
    {
        public readonly int MaxEntries;
        public readonly string MaxTime;

        [OutputConstructor]
        private ServiceMeshControlPlaneSpecTelemetryMixerBatching(
            int maxEntries,

            string maxTime)
        {
            MaxEntries = maxEntries;
            MaxTime = maxTime;
        }
    }
}
