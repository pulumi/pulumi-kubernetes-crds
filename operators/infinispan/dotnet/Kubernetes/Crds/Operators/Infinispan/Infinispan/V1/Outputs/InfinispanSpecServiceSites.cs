// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Infinispan.V1
{

    [OutputType]
    public sealed class InfinispanSpecServiceSites
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Infinispan.V1.InfinispanSpecServiceSitesLocal Local;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Infinispan.V1.InfinispanSpecServiceSitesLocations> Locations;

        [OutputConstructor]
        private InfinispanSpecServiceSites(
            Pulumi.Kubernetes.Types.Outputs.Infinispan.V1.InfinispanSpecServiceSitesLocal local,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Infinispan.V1.InfinispanSpecServiceSitesLocations> locations)
        {
            Local = local;
            Locations = locations;
        }
    }
}