// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1
{

    [OutputType]
    public sealed class JaegerSpecStorageEsIndexCleanerVolumesSecretItems
    {
        public readonly string Key;
        public readonly int Mode;
        public readonly string Path;

        [OutputConstructor]
        private JaegerSpecStorageEsIndexCleanerVolumesSecretItems(
            string key,

            int mode,

            string path)
        {
            Key = key;
            Mode = mode;
            Path = path;
        }
    }
}
