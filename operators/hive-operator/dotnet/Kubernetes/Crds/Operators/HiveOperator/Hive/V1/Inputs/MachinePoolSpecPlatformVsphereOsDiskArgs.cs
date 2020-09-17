// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Hive.V1
{

    /// <summary>
    /// OSDisk defines the storage for instance.
    /// </summary>
    public class MachinePoolSpecPlatformVsphereOsDiskArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// DiskSizeGB defines the size of disk in GB.
        /// </summary>
        [Input("diskSizeGB", required: true)]
        public Input<int> DiskSizeGB { get; set; } = null!;

        public MachinePoolSpecPlatformVsphereOsDiskArgs()
        {
        }
    }
}
