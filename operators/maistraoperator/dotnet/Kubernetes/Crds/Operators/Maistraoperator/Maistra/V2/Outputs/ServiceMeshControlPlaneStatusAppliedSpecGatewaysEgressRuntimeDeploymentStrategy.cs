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
    public sealed class ServiceMeshControlPlaneStatusAppliedSpecGatewaysEgressRuntimeDeploymentStrategy
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysEgressRuntimeDeploymentStrategyRollingUpdate RollingUpdate;
        public readonly string Type;

        [OutputConstructor]
        private ServiceMeshControlPlaneStatusAppliedSpecGatewaysEgressRuntimeDeploymentStrategy(
            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysEgressRuntimeDeploymentStrategyRollingUpdate rollingUpdate,

            string type)
        {
            RollingUpdate = rollingUpdate;
            Type = type;
        }
    }
}
