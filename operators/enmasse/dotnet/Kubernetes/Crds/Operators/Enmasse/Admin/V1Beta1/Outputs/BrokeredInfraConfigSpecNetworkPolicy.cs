// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1
{

    [OutputType]
    public sealed class BrokeredInfraConfigSpecNetworkPolicy
    {
        public readonly ImmutableArray<object> Egress;
        public readonly ImmutableArray<object> Ingress;

        [OutputConstructor]
        private BrokeredInfraConfigSpecNetworkPolicy(
            ImmutableArray<object> egress,

            ImmutableArray<object> ingress)
        {
            Egress = egress;
            Ingress = ingress;
        }
    }
}
