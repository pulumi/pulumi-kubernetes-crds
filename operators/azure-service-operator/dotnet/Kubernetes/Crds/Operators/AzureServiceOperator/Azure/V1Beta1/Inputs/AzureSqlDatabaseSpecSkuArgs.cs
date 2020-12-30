// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Azure.V1Beta1
{

    public class AzureSqlDatabaseSpecSkuArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Capacity - Capacity of the particular SKU.
        /// </summary>
        [Input("capacity")]
        public Input<int>? Capacity { get; set; }

        /// <summary>
        /// Family - If the service has different generations of hardware, for the same SKU, then that can be captured here.
        /// </summary>
        [Input("family")]
        public Input<string>? Family { get; set; }

        /// <summary>
        /// Name - The name of the SKU, typically, a letter + Number code, e.g. P3.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Size - Size of the particular SKU
        /// </summary>
        [Input("size")]
        public Input<string>? Size { get; set; }

        /// <summary>
        /// optional Tier - The tier or edition of the particular SKU, e.g. Basic, Premium.
        /// </summary>
        [Input("tier")]
        public Input<string>? Tier { get; set; }

        public AzureSqlDatabaseSpecSkuArgs()
        {
        }
    }
}
