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
    /// Define NetworkPolicy for this address space.
    /// </summary>
    public class AddressSpaceSpecNetworkPolicyArgs : Pulumi.ResourceArgs
    {
        [Input("egress")]
        private InputList<ImmutableDictionary<string, object>>? _egress;
        public InputList<ImmutableDictionary<string, object>> Egress
        {
            get => _egress ?? (_egress = new InputList<ImmutableDictionary<string, object>>());
            set => _egress = value;
        }

        [Input("ingress")]
        private InputList<ImmutableDictionary<string, object>>? _ingress;
        public InputList<ImmutableDictionary<string, object>> Ingress
        {
            get => _ingress ?? (_ingress = new InputList<ImmutableDictionary<string, object>>());
            set => _ingress = value;
        }

        public AddressSpaceSpecNetworkPolicyArgs()
        {
        }
    }
}
