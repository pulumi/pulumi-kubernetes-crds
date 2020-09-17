// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Multiclusterdns.V1Alpha1
{

    [OutputType]
    public sealed class DNSEndpointStatus
    {
        /// <summary>
        /// ObservedGeneration is the generation as observed by the controller consuming the DNSEndpoint.
        /// </summary>
        public readonly int ObservedGeneration;

        [OutputConstructor]
        private DNSEndpointStatus(int observedGeneration)
        {
            ObservedGeneration = observedGeneration;
        }
    }
}