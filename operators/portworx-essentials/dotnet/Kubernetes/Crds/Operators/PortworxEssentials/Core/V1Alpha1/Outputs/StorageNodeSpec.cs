// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1
{

    [OutputType]
    public sealed class StorageNodeSpec
    {
        /// <summary>
        /// Details of storage on the node for cloud environments.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageNodeSpecCloudStorage CloudStorage;
        /// <summary>
        /// Version of the storage driver on the node.
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private StorageNodeSpec(
            Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageNodeSpecCloudStorage cloudStorage,

            string version)
        {
            CloudStorage = cloudStorage;
            Version = version;
        }
    }
}
