// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2
{

    /// <summary>
    /// Disk requirements of this volume.
    /// </summary>
    public class ContainerizedWorkloadSpecContainersResourcesVolumesDiskArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Ephemeral specifies whether an external disk needs to be mounted.
        /// </summary>
        [Input("ephemeral")]
        public Input<bool>? Ephemeral { get; set; }

        /// <summary>
        /// Required disk space.
        /// </summary>
        [Input("required", required: true)]
        public Input<string> Required { get; set; } = null!;

        public ContainerizedWorkloadSpecContainersResourcesVolumesDiskArgs()
        {
        }
    }
}
