// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1
{

    [OutputType]
    public sealed class DatadogAgentSpecClusterChecksRunnerConfigVolumesHostPath
    {
        /// <summary>
        /// Path of the directory on the host. If the path is a symlink, it will follow the link to the real path. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath
        /// </summary>
        public readonly string Path;
        /// <summary>
        /// Type for HostPath Volume Defaults to "" More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private DatadogAgentSpecClusterChecksRunnerConfigVolumesHostPath(
            string path,

            string type)
        {
            Path = path;
            Type = type;
        }
    }
}
