// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1
{

    [OutputType]
    public sealed class GlobalRouteDiscoverySpec
    {
        /// <summary>
        /// Cluster is an arrays with the list of clusters in which global routes will be discovered
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GlobalRouteDiscoverySpecClusters> Clusters;
        /// <summary>
        /// DefaultLoadBalancingPolicy defines the load balancing policy to be used by default. This can be overridden with a route annotation TODO which? -kubebuilder:default:="Multivalue"
        /// </summary>
        public readonly string DefaultLoadBalancingPolicy;
        /// <summary>
        /// Dfeault TTL is the TTL for this dns record -kubebuilder:default:60
        /// </summary>
        public readonly int DefaultTTL;
        /// <summary>
        /// GlobalZoneRef represents the global zone that will be used to host this record
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GlobalRouteDiscoverySpecGlobalZoneRef GlobalZoneRef;
        /// <summary>
        /// RouteSelector is the selector that selects the global routes, this allows you to define also local routes.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GlobalRouteDiscoverySpecRouteSelector RouteSelector;

        [OutputConstructor]
        private GlobalRouteDiscoverySpec(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GlobalRouteDiscoverySpecClusters> clusters,

            string defaultLoadBalancingPolicy,

            int defaultTTL,

            Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GlobalRouteDiscoverySpecGlobalZoneRef globalZoneRef,

            Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GlobalRouteDiscoverySpecRouteSelector routeSelector)
        {
            Clusters = clusters;
            DefaultLoadBalancingPolicy = defaultLoadBalancingPolicy;
            DefaultTTL = defaultTTL;
            GlobalZoneRef = globalZoneRef;
            RouteSelector = routeSelector;
        }
    }
}
