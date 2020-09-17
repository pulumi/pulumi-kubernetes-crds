// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Velero.V1
{

    [OutputType]
    public sealed class BackupStorageLocationSpecObjectStorage
    {
        /// <summary>
        /// Bucket is the bucket to use for object storage.
        /// </summary>
        public readonly string Bucket;
        /// <summary>
        /// Prefix is the path inside a bucket to use for Velero storage. Optional.
        /// </summary>
        public readonly string Prefix;

        [OutputConstructor]
        private BackupStorageLocationSpecObjectStorage(
            string bucket,

            string prefix)
        {
            Bucket = bucket;
            Prefix = prefix;
        }
    }
}
