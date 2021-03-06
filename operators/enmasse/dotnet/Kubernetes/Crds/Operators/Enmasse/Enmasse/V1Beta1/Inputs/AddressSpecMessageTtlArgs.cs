// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1
{

    /// <summary>
    /// Further restricts message time-to-live (TTL). Applies to address types queue and topic only. The maximum and minimum values must fall with the minimum/maximum range described by the plan's TTL settings.
    /// </summary>
    public class AddressSpecMessageTtlArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Imposes a maximum TTL value (in milliseconds) for messages arriving at the address.  Messages arriving with TTL values greater than this value (or no TTL value) will have their expiration adjusted.
        /// </summary>
        [Input("maximum")]
        public Input<int>? Maximum { get; set; }

        /// <summary>
        /// Imposes a minimum TTL value (in milliseconds) for messages arriving at the address.  Messages arriving with TTL values less than this value will have their expiration adjusted.
        /// </summary>
        [Input("minimum")]
        public Input<int>? Minimum { get; set; }

        public AddressSpecMessageTtlArgs()
        {
        }
    }
}
