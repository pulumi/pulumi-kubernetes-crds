// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Csi.V1
{

    public class CSIScaleOperatorSpecNodeMappingArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// K8s node name.
        /// </summary>
        [Input("k8sNode")]
        public Input<string>? K8sNode { get; set; }

        /// <summary>
        /// SpectrumScale node name.
        /// </summary>
        [Input("spectrumscaleNode")]
        public Input<string>? SpectrumscaleNode { get; set; }

        public CSIScaleOperatorSpecNodeMappingArgs()
        {
        }
    }
}
