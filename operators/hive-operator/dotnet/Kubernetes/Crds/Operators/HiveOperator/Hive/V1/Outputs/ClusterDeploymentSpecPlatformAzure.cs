// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Hive.V1
{

    [OutputType]
    public sealed class ClusterDeploymentSpecPlatformAzure
    {
        /// <summary>
        /// BaseDomainResourceGroupName specifies the resource group where the azure DNS zone for the base domain is found
        /// </summary>
        public readonly string BaseDomainResourceGroupName;
        /// <summary>
        /// CredentialsSecretRef refers to a secret that contains the Azure account access credentials.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterDeploymentSpecPlatformAzureCredentialsSecretRef CredentialsSecretRef;
        /// <summary>
        /// Region specifies the Azure region where the cluster will be created.
        /// </summary>
        public readonly string Region;

        [OutputConstructor]
        private ClusterDeploymentSpecPlatformAzure(
            string baseDomainResourceGroupName,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterDeploymentSpecPlatformAzureCredentialsSecretRef credentialsSecretRef,

            string region)
        {
            BaseDomainResourceGroupName = baseDomainResourceGroupName;
            CredentialsSecretRef = credentialsSecretRef;
            Region = region;
        }
    }
}
