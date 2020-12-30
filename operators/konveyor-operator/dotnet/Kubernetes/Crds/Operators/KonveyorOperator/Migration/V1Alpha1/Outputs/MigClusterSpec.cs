// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Migration.V1Alpha1
{

    [OutputType]
    public sealed class MigClusterSpec
    {
        public readonly string AzureResourceGroup;
        public readonly string CaBundle;
        public readonly bool Insecure;
        public readonly bool IsHostCluster;
        public readonly bool RestartRestic;
        public readonly ImmutableDictionary<string, object> ServiceAccountSecretRef;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Migration.V1Alpha1.MigClusterSpecStorageClasses> StorageClasses;
        public readonly string Url;

        [OutputConstructor]
        private MigClusterSpec(
            string azureResourceGroup,

            string caBundle,

            bool insecure,

            bool isHostCluster,

            bool restartRestic,

            ImmutableDictionary<string, object> serviceAccountSecretRef,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Migration.V1Alpha1.MigClusterSpecStorageClasses> storageClasses,

            string url)
        {
            AzureResourceGroup = azureResourceGroup;
            CaBundle = caBundle;
            Insecure = insecure;
            IsHostCluster = isHostCluster;
            RestartRestic = restartRestic;
            ServiceAccountSecretRef = serviceAccountSecretRef;
            StorageClasses = storageClasses;
            Url = url;
        }
    }
}
