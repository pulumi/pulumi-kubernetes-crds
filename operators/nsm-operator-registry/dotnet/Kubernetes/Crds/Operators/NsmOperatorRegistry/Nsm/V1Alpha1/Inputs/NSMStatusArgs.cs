// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Nsm.V1Alpha1
{

    /// <summary>
    /// NSMStatus defines the observed state of NSM
    /// </summary>
    public class NSMStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Operator phases during deployment
        /// </summary>
        [Input("phase", required: true)]
        public Input<string> Phase { get; set; } = null!;

        public NSMStatusArgs()
        {
        }
    }
}
