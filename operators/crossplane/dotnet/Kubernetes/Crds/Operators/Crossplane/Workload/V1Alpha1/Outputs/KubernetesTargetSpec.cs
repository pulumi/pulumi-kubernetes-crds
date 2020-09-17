// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Workload.V1Alpha1
{

    [OutputType]
    public sealed class KubernetesTargetSpec
    {
        /// <summary>
        /// A ResourceReference specifies an existing managed resource, in any namespace, which this target should attempt to propagate a connection secret from.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Workload.V1Alpha1.KubernetesTargetSpecClusterRef ClusterRef;
        /// <summary>
        /// WriteConnectionSecretToReference specifies the name of a Secret, in the same namespace as this target, to which any connection details for this target should be written or already exist. Connection secrets referenced by a target should contain information for connecting to a resource that allows for scheduling of workloads.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Workload.V1Alpha1.KubernetesTargetSpecConnectionSecretRef ConnectionSecretRef;

        [OutputConstructor]
        private KubernetesTargetSpec(
            Pulumi.Kubernetes.Types.Outputs.Workload.V1Alpha1.KubernetesTargetSpecClusterRef clusterRef,

            Pulumi.Kubernetes.Types.Outputs.Workload.V1Alpha1.KubernetesTargetSpecConnectionSecretRef connectionSecretRef)
        {
            ClusterRef = clusterRef;
            ConnectionSecretRef = connectionSecretRef;
        }
    }
}