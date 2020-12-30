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
    public sealed class ServiceMeshControlPlaneSpecAddons3scaleSystem
    {
        public readonly int Cache_max_size;
        public readonly int Cache_refresh_interval;
        public readonly int Cache_refresh_retries;
        public readonly int Cache_ttl;

        [OutputConstructor]
        private ServiceMeshControlPlaneSpecAddons3scaleSystem(
            int cache_max_size,

            int cache_refresh_interval,

            int cache_refresh_retries,

            int cache_ttl)
        {
            Cache_max_size = cache_max_size;
            Cache_refresh_interval = cache_refresh_interval;
            Cache_refresh_retries = cache_refresh_retries;
            Cache_ttl = cache_ttl;
        }
    }
}
