// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Csi.V1
{

    public class CSIScaleOperatorStatusConditionsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indicates that the plugin is running.
        /// </summary>
        [Input("Ready")]
        public Input<bool>? Ready { get; set; }

        public CSIScaleOperatorStatusConditionsArgs()
        {
        }
    }
}
