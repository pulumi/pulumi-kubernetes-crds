// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1
{

    [OutputType]
    public sealed class AddressSpaceSpec
    {
        /// <summary>
        /// The authentication service to use for authenticating messaging clients.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1.AddressSpaceSpecAuthenticationService AuthenticationService;
        /// <summary>
        /// External AMQP connections.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1.AddressSpaceSpecConnectors> Connectors;
        /// <summary>
        /// Endpoints configured for this address space.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1.AddressSpaceSpecEndpoints> Endpoints;
        /// <summary>
        /// Define NetworkPolicy for this address space.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1.AddressSpaceSpecNetworkPolicy NetworkPolicy;
        /// <summary>
        /// The name of the address space plan to apply.
        /// </summary>
        public readonly string Plan;
        /// <summary>
        /// The type of address space.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private AddressSpaceSpec(
            Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1.AddressSpaceSpecAuthenticationService authenticationService,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1.AddressSpaceSpecConnectors> connectors,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1.AddressSpaceSpecEndpoints> endpoints,

            Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1.AddressSpaceSpecNetworkPolicy networkPolicy,

            string plan,

            string type)
        {
            AuthenticationService = authenticationService;
            Connectors = connectors;
            Endpoints = endpoints;
            NetworkPolicy = networkPolicy;
            Plan = plan;
            Type = type;
        }
    }
}
