// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Camel.V1
{

    [OutputType]
    public sealed class IntegrationPlatformSpecBuildMavenSettings
    {
        /// <summary>
        /// Selects a key of a ConfigMap.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Camel.V1.IntegrationPlatformSpecBuildMavenSettingsConfigMapKeyRef ConfigMapKeyRef;
        /// <summary>
        /// Selects a key of a secret.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Camel.V1.IntegrationPlatformSpecBuildMavenSettingsSecretKeyRef SecretKeyRef;

        [OutputConstructor]
        private IntegrationPlatformSpecBuildMavenSettings(
            Pulumi.Kubernetes.Types.Outputs.Camel.V1.IntegrationPlatformSpecBuildMavenSettingsConfigMapKeyRef configMapKeyRef,

            Pulumi.Kubernetes.Types.Outputs.Camel.V1.IntegrationPlatformSpecBuildMavenSettingsSecretKeyRef secretKeyRef)
        {
            ConfigMapKeyRef = configMapKeyRef;
            SecretKeyRef = secretKeyRef;
        }
    }
}
