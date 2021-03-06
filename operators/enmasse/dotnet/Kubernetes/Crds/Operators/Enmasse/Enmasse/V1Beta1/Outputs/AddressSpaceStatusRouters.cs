// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1
{

    [OutputType]
    public sealed class AddressSpaceStatusRouters
    {
        public readonly string Id;
        public readonly ImmutableArray<string> Neighbors;
        public readonly int Undelivered;

        [OutputConstructor]
        private AddressSpaceStatusRouters(
            string id,

            ImmutableArray<string> neighbors,

            int undelivered)
        {
            Id = id;
            Neighbors = neighbors;
            Undelivered = undelivered;
        }
    }
}
