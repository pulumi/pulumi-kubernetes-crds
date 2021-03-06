// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Mattermost.V1Alpha1
{

    [OutputType]
    public sealed class ClusterInstallationSpecMinio
    {
        /// <summary>
        /// Defines the number of Minio replicas. Supply 1 to run Minio in standalone mode with no redundancy. Supply 4 or more to run Minio in distributed mode. Note that it is not possible to upgrade Minio from standalone to distributed mode. Setting this will override the number of replicas set by 'Size'. More info: https://docs.min.io/docs/distributed-minio-quickstart-guide.html
        /// </summary>
        public readonly int Replicas;
        /// <summary>
        /// Defines the resource requests and limits for the Minio pods.
        /// </summary>
        public readonly ImmutableDictionary<string, object> Resources;
        /// <summary>
        /// Defines the storage size for Minio. ie 50Gi
        /// </summary>
        public readonly string StorageSize;

        [OutputConstructor]
        private ClusterInstallationSpecMinio(
            int replicas,

            ImmutableDictionary<string, object> resources,

            string storageSize)
        {
            Replicas = replicas;
            Resources = resources;
            StorageSize = storageSize;
        }
    }
}
