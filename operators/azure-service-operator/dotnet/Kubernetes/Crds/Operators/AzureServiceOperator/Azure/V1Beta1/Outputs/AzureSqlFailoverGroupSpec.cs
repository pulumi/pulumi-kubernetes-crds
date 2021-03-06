// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Azure.V1Beta1
{

    [OutputType]
    public sealed class AzureSqlFailoverGroupSpec
    {
        public readonly ImmutableArray<string> DatabaseList;
        public readonly int FailoverGracePeriod;
        /// <summary>
        /// NOTE: json tags are required.  Any new fields you add must have json tags for the fields to be serialized.
        /// </summary>
        public readonly string FailoverPolicy;
        public readonly string KeyVaultToStoreSecrets;
        /// <summary>
        /// Important: Run "make" to regenerate code after modifying this file
        /// </summary>
        public readonly string Location;
        public readonly string ResourceGroup;
        public readonly string SecondaryServer;
        public readonly string SecondaryServerResourceGroup;
        public readonly string Server;

        [OutputConstructor]
        private AzureSqlFailoverGroupSpec(
            ImmutableArray<string> databaseList,

            int failoverGracePeriod,

            string failoverPolicy,

            string keyVaultToStoreSecrets,

            string location,

            string resourceGroup,

            string secondaryServer,

            string secondaryServerResourceGroup,

            string server)
        {
            DatabaseList = databaseList;
            FailoverGracePeriod = failoverGracePeriod;
            FailoverPolicy = failoverPolicy;
            KeyVaultToStoreSecrets = keyVaultToStoreSecrets;
            Location = location;
            ResourceGroup = resourceGroup;
            SecondaryServer = secondaryServer;
            SecondaryServerResourceGroup = secondaryServerResourceGroup;
            Server = server;
        }
    }
}
