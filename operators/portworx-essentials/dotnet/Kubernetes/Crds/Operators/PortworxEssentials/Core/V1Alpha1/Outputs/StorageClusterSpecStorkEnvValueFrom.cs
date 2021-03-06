// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1
{

    [OutputType]
    public sealed class StorageClusterSpecStorkEnvValueFrom
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecStorkEnvValueFromConfigMapKeyRef ConfigMapKeyRef;
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecStorkEnvValueFromFieldRef FieldRef;
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecStorkEnvValueFromResourceFieldRef ResourceFieldRef;
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecStorkEnvValueFromSecretKeyRef SecretKeyRef;

        [OutputConstructor]
        private StorageClusterSpecStorkEnvValueFrom(
            Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecStorkEnvValueFromConfigMapKeyRef configMapKeyRef,

            Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecStorkEnvValueFromFieldRef fieldRef,

            Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecStorkEnvValueFromResourceFieldRef resourceFieldRef,

            Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecStorkEnvValueFromSecretKeyRef secretKeyRef)
        {
            ConfigMapKeyRef = configMapKeyRef;
            FieldRef = fieldRef;
            ResourceFieldRef = resourceFieldRef;
            SecretKeyRef = secretKeyRef;
        }
    }
}
