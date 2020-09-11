// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Csi.V1
{

    /// <summary>
    /// IBMBlockCSIStatus defines the observed state of IBMBlockCSI
    /// </summary>
    public class IBMBlockCSIStatusArgs : Pulumi.ResourceArgs
    {
        [Input("controllerReady", required: true)]
        public Input<bool> ControllerReady { get; set; } = null!;

        [Input("nodeReady", required: true)]
        public Input<bool> NodeReady { get; set; } = null!;

        /// <summary>
        /// Phase is the driver running phase
        /// </summary>
        [Input("phase", required: true)]
        public Input<string> Phase { get; set; } = null!;

        /// <summary>
        /// Version is the current driver version
        /// </summary>
        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        public IBMBlockCSIStatusArgs()
        {
        }
    }
}
