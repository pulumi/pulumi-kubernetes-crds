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
    public sealed class ServiceMeshControlPlaneSpecRuntimeDefaultsDeploymentPodDisruption
    {
        public readonly bool Enabled;
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecRuntimeDefaultsDeploymentPodDisruptionMaxUnavailable MaxUnavailable;
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecRuntimeDefaultsDeploymentPodDisruptionMinAvailable MinAvailable;

        [OutputConstructor]
        private ServiceMeshControlPlaneSpecRuntimeDefaultsDeploymentPodDisruption(
            bool enabled,

            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecRuntimeDefaultsDeploymentPodDisruptionMaxUnavailable maxUnavailable,

            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecRuntimeDefaultsDeploymentPodDisruptionMinAvailable minAvailable)
        {
            Enabled = enabled;
            MaxUnavailable = maxUnavailable;
            MinAvailable = minAvailable;
        }
    }
}
