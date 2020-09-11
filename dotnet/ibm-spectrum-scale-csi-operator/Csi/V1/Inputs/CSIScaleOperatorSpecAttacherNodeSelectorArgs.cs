// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Csi.V1
{

    public class CSIScaleOperatorSpecAttacherNodeSelectorArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Key for node selector.
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        /// <summary>
        /// Value for key.
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public CSIScaleOperatorSpecAttacherNodeSelectorArgs()
        {
        }
    }
}
