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
    public sealed class ServiceMeshControlPlaneStatusAppliedSpecClusterMeshExpansionIlbGatewayRuntimeDeployment
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecClusterMeshExpansionIlbGatewayRuntimeDeploymentAutoScaling AutoScaling;
        public readonly int Replicas;
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecClusterMeshExpansionIlbGatewayRuntimeDeploymentStrategy Strategy;

        [OutputConstructor]
        private ServiceMeshControlPlaneStatusAppliedSpecClusterMeshExpansionIlbGatewayRuntimeDeployment(
            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecClusterMeshExpansionIlbGatewayRuntimeDeploymentAutoScaling autoScaling,

            int replicas,

            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecClusterMeshExpansionIlbGatewayRuntimeDeploymentStrategy strategy)
        {
            AutoScaling = autoScaling;
            Replicas = replicas;
            Strategy = strategy;
        }
    }
}
