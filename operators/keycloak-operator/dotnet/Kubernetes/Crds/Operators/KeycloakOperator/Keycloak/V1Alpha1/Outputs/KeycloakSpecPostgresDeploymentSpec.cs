// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Keycloak.V1Alpha1
{

    [OutputType]
    public sealed class KeycloakSpecPostgresDeploymentSpec
    {
        /// <summary>
        /// Resources (Requests and Limits) for the Pods.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Keycloak.V1Alpha1.KeycloakSpecPostgresDeploymentSpecResources Resources;

        [OutputConstructor]
        private KeycloakSpecPostgresDeploymentSpec(Pulumi.Kubernetes.Types.Outputs.Keycloak.V1Alpha1.KeycloakSpecPostgresDeploymentSpecResources resources)
        {
            Resources = resources;
        }
    }
}