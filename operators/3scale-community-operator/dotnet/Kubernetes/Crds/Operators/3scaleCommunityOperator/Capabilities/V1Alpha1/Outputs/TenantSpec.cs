// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Capabilities.V1Alpha1
{

    [OutputType]
    public sealed class TenantSpec
    {
        public readonly string Email;
        /// <summary>
        /// SecretReference represents a Secret Reference. It has enough information to retrieve secret in any namespace
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Capabilities.V1Alpha1.TenantSpecMasterCredentialsRef MasterCredentialsRef;
        public readonly string OrganizationName;
        /// <summary>
        /// SecretReference represents a Secret Reference. It has enough information to retrieve secret in any namespace
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Capabilities.V1Alpha1.TenantSpecPasswordCredentialsRef PasswordCredentialsRef;
        public readonly string SystemMasterUrl;
        /// <summary>
        /// SecretReference represents a Secret Reference. It has enough information to retrieve secret in any namespace
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Capabilities.V1Alpha1.TenantSpecTenantSecretRef TenantSecretRef;
        public readonly string Username;

        [OutputConstructor]
        private TenantSpec(
            string email,

            Pulumi.Kubernetes.Types.Outputs.Capabilities.V1Alpha1.TenantSpecMasterCredentialsRef masterCredentialsRef,

            string organizationName,

            Pulumi.Kubernetes.Types.Outputs.Capabilities.V1Alpha1.TenantSpecPasswordCredentialsRef passwordCredentialsRef,

            string systemMasterUrl,

            Pulumi.Kubernetes.Types.Outputs.Capabilities.V1Alpha1.TenantSpecTenantSecretRef tenantSecretRef,

            string username)
        {
            Email = email;
            MasterCredentialsRef = masterCredentialsRef;
            OrganizationName = organizationName;
            PasswordCredentialsRef = passwordCredentialsRef;
            SystemMasterUrl = systemMasterUrl;
            TenantSecretRef = tenantSecretRef;
            Username = username;
        }
    }
}
