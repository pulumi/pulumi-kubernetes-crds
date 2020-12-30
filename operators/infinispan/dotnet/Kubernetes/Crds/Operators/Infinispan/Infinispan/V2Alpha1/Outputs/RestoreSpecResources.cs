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
    public sealed class RestoreSpecResources
    {
        public readonly ImmutableArray<string> CacheConfigs;
        public readonly ImmutableArray<string> Caches;
        public readonly ImmutableArray<string> Counters;
        public readonly ImmutableArray<string> ProtoSchemas;
        public readonly ImmutableArray<string> Scripts;

        [OutputConstructor]
        private RestoreSpecResources(
            ImmutableArray<string> cacheConfigs,

            ImmutableArray<string> caches,

            ImmutableArray<string> counters,

            ImmutableArray<string> protoSchemas,

            ImmutableArray<string> scripts)
        {
            CacheConfigs = cacheConfigs;
            Caches = caches;
            Counters = counters;
            ProtoSchemas = protoSchemas;
            Scripts = scripts;
        }
    }
}
