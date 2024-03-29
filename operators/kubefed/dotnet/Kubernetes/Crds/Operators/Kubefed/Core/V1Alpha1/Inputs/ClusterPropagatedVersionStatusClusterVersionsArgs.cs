// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha1
{

    public class ClusterPropagatedVersionStatusClusterVersionsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the cluster the version is for.
        /// </summary>
        [Input("clusterName", required: true)]
        public Input<string> ClusterName { get; set; } = null!;

        /// <summary>
        /// The last version produced for the resource by a KubeFed operation.
        /// </summary>
        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        public ClusterPropagatedVersionStatusClusterVersionsArgs()
        {
        }
    }
}
