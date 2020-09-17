// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1
{

    [OutputType]
    public sealed class DatadogAgentSpecAgentConfigEnvValueFrom
    {
        /// <summary>
        /// Selects a key of a ConfigMap.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigEnvValueFromConfigMapKeyRef ConfigMapKeyRef;
        /// <summary>
        /// Selects a field of the pod: supports metadata.name, metadata.namespace, metadata.labels, metadata.annotations, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP, status.podIPs.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigEnvValueFromFieldRef FieldRef;
        /// <summary>
        /// Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigEnvValueFromResourceFieldRef ResourceFieldRef;
        /// <summary>
        /// Selects a key of a secret in the pod's namespace
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigEnvValueFromSecretKeyRef SecretKeyRef;

        [OutputConstructor]
        private DatadogAgentSpecAgentConfigEnvValueFrom(
            Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigEnvValueFromConfigMapKeyRef configMapKeyRef,

            Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigEnvValueFromFieldRef fieldRef,

            Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigEnvValueFromResourceFieldRef resourceFieldRef,

            Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigEnvValueFromSecretKeyRef secretKeyRef)
        {
            ConfigMapKeyRef = configMapKeyRef;
            FieldRef = fieldRef;
            ResourceFieldRef = resourceFieldRef;
            SecretKeyRef = secretKeyRef;
        }
    }
}
