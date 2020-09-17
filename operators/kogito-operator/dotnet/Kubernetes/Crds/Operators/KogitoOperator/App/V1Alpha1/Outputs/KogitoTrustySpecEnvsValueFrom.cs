// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1
{

    [OutputType]
    public sealed class KogitoTrustySpecEnvsValueFrom
    {
        /// <summary>
        /// Selects a key of a ConfigMap.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoTrustySpecEnvsValueFromConfigMapKeyRef ConfigMapKeyRef;
        /// <summary>
        /// Selects a field of the pod: supports metadata.name, metadata.namespace, metadata.labels, metadata.annotations, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP, status.podIPs.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoTrustySpecEnvsValueFromFieldRef FieldRef;
        /// <summary>
        /// Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoTrustySpecEnvsValueFromResourceFieldRef ResourceFieldRef;
        /// <summary>
        /// Selects a key of a secret in the pod's namespace
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoTrustySpecEnvsValueFromSecretKeyRef SecretKeyRef;

        [OutputConstructor]
        private KogitoTrustySpecEnvsValueFrom(
            Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoTrustySpecEnvsValueFromConfigMapKeyRef configMapKeyRef,

            Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoTrustySpecEnvsValueFromFieldRef fieldRef,

            Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoTrustySpecEnvsValueFromResourceFieldRef resourceFieldRef,

            Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoTrustySpecEnvsValueFromSecretKeyRef secretKeyRef)
        {
            ConfigMapKeyRef = configMapKeyRef;
            FieldRef = fieldRef;
            ResourceFieldRef = resourceFieldRef;
            SecretKeyRef = secretKeyRef;
        }
    }
}