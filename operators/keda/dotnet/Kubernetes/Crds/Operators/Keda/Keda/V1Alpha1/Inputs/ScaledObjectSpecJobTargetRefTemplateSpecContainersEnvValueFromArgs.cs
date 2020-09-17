// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Keda.V1Alpha1
{

    /// <summary>
    /// Source for the environment variable's value. Cannot be used if value is not empty.
    /// </summary>
    public class ScaledObjectSpecJobTargetRefTemplateSpecContainersEnvValueFromArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Selects a key of a ConfigMap.
        /// </summary>
        [Input("configMapKeyRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Keda.V1Alpha1.ScaledObjectSpecJobTargetRefTemplateSpecContainersEnvValueFromConfigMapKeyRefArgs>? ConfigMapKeyRef { get; set; }

        /// <summary>
        /// Selects a field of the pod: supports metadata.name, metadata.namespace, metadata.labels, metadata.annotations, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP.
        /// </summary>
        [Input("fieldRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Keda.V1Alpha1.ScaledObjectSpecJobTargetRefTemplateSpecContainersEnvValueFromFieldRefArgs>? FieldRef { get; set; }

        /// <summary>
        /// Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.
        /// </summary>
        [Input("resourceFieldRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Keda.V1Alpha1.ScaledObjectSpecJobTargetRefTemplateSpecContainersEnvValueFromResourceFieldRefArgs>? ResourceFieldRef { get; set; }

        /// <summary>
        /// Selects a key of a secret in the pod's namespace
        /// </summary>
        [Input("secretKeyRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Keda.V1Alpha1.ScaledObjectSpecJobTargetRefTemplateSpecContainersEnvValueFromSecretKeyRefArgs>? SecretKeyRef { get; set; }

        public ScaledObjectSpecJobTargetRefTemplateSpecContainersEnvValueFromArgs()
        {
        }
    }
}
