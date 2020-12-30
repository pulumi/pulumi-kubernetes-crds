// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Azure.V1Alpha1
{

    [OutputType]
    public sealed class AzureSqlActionSpec
    {
        public readonly string ActionName;
        public readonly string DbName;
        public readonly string DbUser;
        /// <summary>
        /// INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "make" to regenerate code after modifying this file
        /// </summary>
        public readonly string ResourceGroup;
        public readonly string ServerAdminSecretName;
        public readonly string ServerName;
        public readonly string ServerSecretKeyVault;
        public readonly string UserSecretKeyVault;

        [OutputConstructor]
        private AzureSqlActionSpec(
            string actionName,

            string dbName,

            string dbUser,

            string resourceGroup,

            string serverAdminSecretName,

            string serverName,

            string serverSecretKeyVault,

            string userSecretKeyVault)
        {
            ActionName = actionName;
            DbName = dbName;
            DbUser = dbUser;
            ResourceGroup = resourceGroup;
            ServerAdminSecretName = serverAdminSecretName;
            ServerName = serverName;
            ServerSecretKeyVault = serverSecretKeyVault;
            UserSecretKeyVault = userSecretKeyVault;
        }
    }
}