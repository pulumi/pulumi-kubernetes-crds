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
    public sealed class ServiceMeshControlPlaneStatusAppliedSpecAddonsGrafanaInstallPersistence
    {
        public readonly string AccessMode;
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecAddonsGrafanaInstallPersistenceCapacity Capacity;
        public readonly bool Enabled;
        public readonly string StorageClassName;

        [OutputConstructor]
        private ServiceMeshControlPlaneStatusAppliedSpecAddonsGrafanaInstallPersistence(
            string accessMode,

            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecAddonsGrafanaInstallPersistenceCapacity capacity,

            bool enabled,

            string storageClassName)
        {
            AccessMode = accessMode;
            Capacity = capacity;
            Enabled = enabled;
            StorageClassName = storageClassName;
        }
    }
}
