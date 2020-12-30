// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1
{

    /// <summary>
    /// EventhubNamespaceSku defines the sku
    /// </summary>
    public class EventhubNamespaceSpecSkuArgs : Pulumi.ResourceArgs
    {
        [Input("capacity")]
        public Input<int>? Capacity { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("tier")]
        public Input<string>? Tier { get; set; }

        public EventhubNamespaceSpecSkuArgs()
        {
        }
    }
}