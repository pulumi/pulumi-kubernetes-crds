// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1
{

    /// <summary>
    /// EmptyDir represents a temporary directory that shares a pod's lifetime. More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir
    /// </summary>
    public class PrometheusSpecVolumesEmptyDirArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// What type of storage medium should back this directory. The default is "" which means to use the node's default medium. Must be an empty string (default) or Memory. More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir
        /// </summary>
        [Input("medium")]
        public Input<string>? Medium { get; set; }

        /// <summary>
        /// Total amount of local storage required for this EmptyDir volume. The size limit is also applicable for memory medium. The maximum usage on memory medium EmptyDir would be the minimum value between the SizeLimit specified here and the sum of memory limits of all containers in a pod. The default is nil which means that the limit is undefined. More info: http://kubernetes.io/docs/user-guide/volumes#emptydir
        /// </summary>
        [Input("sizeLimit")]
        public Input<string>? SizeLimit { get; set; }

        public PrometheusSpecVolumesEmptyDirArgs()
        {
        }
    }
}
