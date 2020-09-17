// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Camel.V1
{

    /// <summary>
    /// ValueSource --
    /// </summary>
    public class IntegrationPlatformStatusBuildMavenSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Selects a key of a ConfigMap.
        /// </summary>
        [Input("configMapKeyRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.IntegrationPlatformStatusBuildMavenSettingsConfigMapKeyRefArgs>? ConfigMapKeyRef { get; set; }

        /// <summary>
        /// Selects a key of a secret.
        /// </summary>
        [Input("secretKeyRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.IntegrationPlatformStatusBuildMavenSettingsSecretKeyRefArgs>? SecretKeyRef { get; set; }

        public IntegrationPlatformStatusBuildMavenSettingsArgs()
        {
        }
    }
}