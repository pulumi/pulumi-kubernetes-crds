// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Storage.V1
{

    [OutputType]
    public sealed class CSIUnityStatusControllerStatus
    {
        public readonly ImmutableArray<string> Available;
        public readonly ImmutableArray<string> Ready;
        public readonly ImmutableArray<string> Starting;
        public readonly ImmutableArray<string> Stopped;

        [OutputConstructor]
        private CSIUnityStatusControllerStatus(
            ImmutableArray<string> available,

            ImmutableArray<string> ready,

            ImmutableArray<string> starting,

            ImmutableArray<string> stopped)
        {
            Available = available;
            Ready = ready;
            Starting = starting;
            Stopped = stopped;
        }
    }
}
