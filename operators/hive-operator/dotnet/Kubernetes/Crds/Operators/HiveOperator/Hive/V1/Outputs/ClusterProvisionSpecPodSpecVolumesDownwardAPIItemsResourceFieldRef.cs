// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Hive.V1
{

    [OutputType]
    public sealed class ClusterProvisionSpecPodSpecVolumesDownwardAPIItemsResourceFieldRef
    {
        /// <summary>
        /// Container name: required for volumes, optional for env vars
        /// </summary>
        public readonly string ContainerName;
        /// <summary>
        /// Specifies the output format of the exposed resources, defaults to "1"
        /// </summary>
        public readonly string Divisor;
        /// <summary>
        /// Required: resource to select
        /// </summary>
        public readonly string Resource;

        [OutputConstructor]
        private ClusterProvisionSpecPodSpecVolumesDownwardAPIItemsResourceFieldRef(
            string containerName,

            string divisor,

            string resource)
        {
            ContainerName = containerName;
            Divisor = divisor;
            Resource = resource;
        }
    }
}
