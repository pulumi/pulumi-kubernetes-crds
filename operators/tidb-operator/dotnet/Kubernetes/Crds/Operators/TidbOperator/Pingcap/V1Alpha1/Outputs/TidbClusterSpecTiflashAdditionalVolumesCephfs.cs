// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1
{

    [OutputType]
    public sealed class TidbClusterSpecTiflashAdditionalVolumesCephfs
    {
        public readonly ImmutableArray<string> Monitors;
        public readonly string Path;
        public readonly bool ReadOnly;
        public readonly string SecretFile;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashAdditionalVolumesCephfsSecretRef SecretRef;
        public readonly string User;

        [OutputConstructor]
        private TidbClusterSpecTiflashAdditionalVolumesCephfs(
            ImmutableArray<string> monitors,

            string path,

            bool readOnly,

            string secretFile,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashAdditionalVolumesCephfsSecretRef secretRef,

            string user)
        {
            Monitors = monitors;
            Path = path;
            ReadOnly = readOnly;
            SecretFile = secretFile;
            SecretRef = secretRef;
            User = user;
        }
    }
}