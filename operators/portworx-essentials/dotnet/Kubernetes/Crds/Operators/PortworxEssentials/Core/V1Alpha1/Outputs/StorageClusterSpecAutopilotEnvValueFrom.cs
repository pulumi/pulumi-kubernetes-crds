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
    public sealed class StorageClusterSpecAutopilotEnvValueFrom
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecAutopilotEnvValueFromConfigMapKeyRef ConfigMapKeyRef;
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecAutopilotEnvValueFromFieldRef FieldRef;
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecAutopilotEnvValueFromResourceFieldRef ResourceFieldRef;
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecAutopilotEnvValueFromSecretKeyRef SecretKeyRef;

        [OutputConstructor]
        private StorageClusterSpecAutopilotEnvValueFrom(
            Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecAutopilotEnvValueFromConfigMapKeyRef configMapKeyRef,

            Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecAutopilotEnvValueFromFieldRef fieldRef,

            Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecAutopilotEnvValueFromResourceFieldRef resourceFieldRef,

            Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecAutopilotEnvValueFromSecretKeyRef secretKeyRef)
        {
            ConfigMapKeyRef = configMapKeyRef;
            FieldRef = fieldRef;
            ResourceFieldRef = resourceFieldRef;
            SecretKeyRef = secretKeyRef;
        }
    }
}
