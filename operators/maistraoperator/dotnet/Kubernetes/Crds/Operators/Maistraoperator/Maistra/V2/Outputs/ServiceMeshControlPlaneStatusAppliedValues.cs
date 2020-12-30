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
    public sealed class ServiceMeshControlPlaneStatusAppliedValues
    {
        public readonly ImmutableDictionary<string, object> Istio;
        public readonly string NetworkType;
        public readonly ImmutableArray<string> Profiles;
        public readonly string Template;
        public readonly ImmutableDictionary<string, object> ThreeScale;
        public readonly string Version;

        [OutputConstructor]
        private ServiceMeshControlPlaneStatusAppliedValues(
            ImmutableDictionary<string, object> istio,

            string networkType,

            ImmutableArray<string> profiles,

            string template,

            ImmutableDictionary<string, object> threeScale,

            string version)
        {
            Istio = istio;
            NetworkType = networkType;
            Profiles = profiles;
            Template = template;
            ThreeScale = threeScale;
            Version = version;
        }
    }
}
