// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Ibmcloud.V1Alpha1
{

    [OutputType]
    public sealed class ServiceSpecParametersValueFrom
    {
        /// <summary>
        /// Selects a key of a ConfigMap.
        /// </summary>
        public readonly ImmutableDictionary<string, object> ConfigMapKeyRef;
        /// <summary>
        /// Selects a key of a secret in the resource namespace
        /// </summary>
        public readonly ImmutableDictionary<string, object> SecretKeyRef;

        [OutputConstructor]
        private ServiceSpecParametersValueFrom(
            ImmutableDictionary<string, object> configMapKeyRef,

            ImmutableDictionary<string, object> secretKeyRef)
        {
            ConfigMapKeyRef = configMapKeyRef;
            SecretKeyRef = secretKeyRef;
        }
    }
}
