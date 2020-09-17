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
    public sealed class MigStorageSpecVolumeSnapshotConfig
    {
        public readonly string AwsRegion;
        public readonly string AzureApiTimeout;
        public readonly string AzureResourceGroup;
        public readonly ImmutableDictionary<string, object> CredsSecretRef;
        public readonly string SnapshotCreationTimeout;

        [OutputConstructor]
        private MigStorageSpecVolumeSnapshotConfig(
            string awsRegion,

            string azureApiTimeout,

            string azureResourceGroup,

            ImmutableDictionary<string, object> credsSecretRef,

            string snapshotCreationTimeout)
        {
            AwsRegion = awsRegion;
            AzureApiTimeout = azureApiTimeout;
            AzureResourceGroup = azureResourceGroup;
            CredsSecretRef = credsSecretRef;
            SnapshotCreationTimeout = snapshotCreationTimeout;
        }
    }
}