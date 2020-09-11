// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Camel.V1
{

    [OutputType]
    public sealed class BuildSpecTasksBuilderVolumesNfs
    {
        /// <summary>
        /// Path that is exported by the NFS server. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs
        /// </summary>
        public readonly string Path;
        /// <summary>
        /// ReadOnly here will force the NFS export to be mounted with read-only permissions. Defaults to false. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs
        /// </summary>
        public readonly bool ReadOnly;
        /// <summary>
        /// Server is the hostname or IP address of the NFS server. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs
        /// </summary>
        public readonly string Server;

        [OutputConstructor]
        private BuildSpecTasksBuilderVolumesNfs(
            string path,

            bool readOnly,

            string server)
        {
            Path = path;
            ReadOnly = readOnly;
            Server = server;
        }
    }
}
