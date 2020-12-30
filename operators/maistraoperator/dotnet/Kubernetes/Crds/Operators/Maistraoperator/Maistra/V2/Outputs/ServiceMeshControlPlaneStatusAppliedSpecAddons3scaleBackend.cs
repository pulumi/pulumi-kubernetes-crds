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
    public sealed class ServiceMeshControlPlaneStatusAppliedSpecAddons3scaleBackend
    {
        public readonly int Cache_flush_interval;
        public readonly bool Enable_cache;
        public readonly bool Policy_fail_closed;

        [OutputConstructor]
        private ServiceMeshControlPlaneStatusAppliedSpecAddons3scaleBackend(
            int cache_flush_interval,

            bool enable_cache,

            bool policy_fail_closed)
        {
            Cache_flush_interval = cache_flush_interval;
            Enable_cache = enable_cache;
            Policy_fail_closed = policy_fail_closed;
        }
    }
}
