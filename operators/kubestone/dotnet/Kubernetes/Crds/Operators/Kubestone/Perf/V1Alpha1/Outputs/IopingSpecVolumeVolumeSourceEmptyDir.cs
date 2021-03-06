// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1
{

    [OutputType]
    public sealed class IopingSpecVolumeVolumeSourceEmptyDir
    {
        /// <summary>
        /// What type of storage medium should back this directory. The default is "" which means to use the node's default medium. Must be an empty string (default) or Memory. More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir
        /// </summary>
        public readonly string Medium;
        /// <summary>
        /// Total amount of local storage required for this EmptyDir volume. The size limit is also applicable for memory medium. The maximum usage on memory medium EmptyDir would be the minimum value between the SizeLimit specified here and the sum of memory limits of all containers in a pod. The default is nil which means that the limit is undefined. More info: http://kubernetes.io/docs/user-guide/volumes#emptydir
        /// </summary>
        public readonly string SizeLimit;

        [OutputConstructor]
        private IopingSpecVolumeVolumeSourceEmptyDir(
            string medium,

            string sizeLimit)
        {
            Medium = medium;
            SizeLimit = sizeLimit;
        }
    }
}
