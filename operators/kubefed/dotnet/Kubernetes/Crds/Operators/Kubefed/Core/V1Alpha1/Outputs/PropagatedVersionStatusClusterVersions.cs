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
    public sealed class PropagatedVersionStatusClusterVersions
    {
        /// <summary>
        /// The name of the cluster the version is for.
        /// </summary>
        public readonly string ClusterName;
        /// <summary>
        /// The last version produced for the resource by a KubeFed operation.
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private PropagatedVersionStatusClusterVersions(
            string clusterName,

            string version)
        {
            ClusterName = clusterName;
            Version = version;
        }
    }
}
