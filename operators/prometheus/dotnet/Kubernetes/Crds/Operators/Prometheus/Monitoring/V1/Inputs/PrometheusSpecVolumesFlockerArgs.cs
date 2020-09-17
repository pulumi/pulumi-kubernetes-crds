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
    /// Flocker represents a Flocker volume attached to a kubelet's host machine. This depends on the Flocker control service being running
    /// </summary>
    public class PrometheusSpecVolumesFlockerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the dataset stored as metadata -&gt; name on the dataset for Flocker should be considered as deprecated
        /// </summary>
        [Input("datasetName")]
        public Input<string>? DatasetName { get; set; }

        /// <summary>
        /// UUID of the dataset. This is unique identifier of a Flocker dataset
        /// </summary>
        [Input("datasetUUID")]
        public Input<string>? DatasetUUID { get; set; }

        public PrometheusSpecVolumesFlockerArgs()
        {
        }
    }
}
