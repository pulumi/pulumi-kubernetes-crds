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
    public sealed class ServiceMeshControlPlaneStatusAppliedSpecProxyInjection
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecProxyInjectionAlwaysInjectSelector> AlwaysInjectSelector;
        public readonly bool AutoInject;
        public readonly ImmutableDictionary<string, string> InjectedAnnotations;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecProxyInjectionNeverInjectSelector> NeverInjectSelector;

        [OutputConstructor]
        private ServiceMeshControlPlaneStatusAppliedSpecProxyInjection(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecProxyInjectionAlwaysInjectSelector> alwaysInjectSelector,

            bool autoInject,

            ImmutableDictionary<string, string> injectedAnnotations,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecProxyInjectionNeverInjectSelector> neverInjectSelector)
        {
            AlwaysInjectSelector = alwaysInjectSelector;
            AutoInject = autoInject;
            InjectedAnnotations = injectedAnnotations;
            NeverInjectSelector = neverInjectSelector;
        }
    }
}
