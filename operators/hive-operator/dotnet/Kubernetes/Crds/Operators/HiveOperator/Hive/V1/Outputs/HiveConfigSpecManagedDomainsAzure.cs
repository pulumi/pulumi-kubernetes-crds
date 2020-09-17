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
    public sealed class HiveConfigSpecManagedDomainsAzure
    {
        /// <summary>
        /// CredentialsSecretRef references a secret in the TargetNamespace that will be used to authenticate with Azure DNS. It wil need permission to manage entries in each of the managed domains listed in the parent ManageDNSConfig object. Secret should have a key named 'osServicePrincipal.json'
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.HiveConfigSpecManagedDomainsAzureCredentialsSecretRef CredentialsSecretRef;
        /// <summary>
        /// ResourceGroupName specifies the Azure resource group containing the DNS zones for the domains being managed.
        /// </summary>
        public readonly string ResourceGroupName;

        [OutputConstructor]
        private HiveConfigSpecManagedDomainsAzure(
            Pulumi.Kubernetes.Types.Outputs.Hive.V1.HiveConfigSpecManagedDomainsAzureCredentialsSecretRef credentialsSecretRef,

            string resourceGroupName)
        {
            CredentialsSecretRef = credentialsSecretRef;
            ResourceGroupName = resourceGroupName;
        }
    }
}
