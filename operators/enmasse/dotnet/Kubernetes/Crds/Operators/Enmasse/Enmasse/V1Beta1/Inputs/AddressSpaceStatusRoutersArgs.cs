// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1
{

    public class AddressSpaceStatusRoutersArgs : Pulumi.ResourceArgs
    {
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        [Input("neighbors")]
        private InputList<string>? _neighbors;
        public InputList<string> Neighbors
        {
            get => _neighbors ?? (_neighbors = new InputList<string>());
            set => _neighbors = value;
        }

        [Input("undelivered")]
        public Input<int>? Undelivered { get; set; }

        public AddressSpaceStatusRoutersArgs()
        {
        }
    }
}
