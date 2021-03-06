// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Enmasse.V1Beta1
{

    public class AddressStatusForwardersArgs : Pulumi.ResourceArgs
    {
        [Input("isReady")]
        public Input<bool>? IsReady { get; set; }

        [Input("messages")]
        private InputList<string>? _messages;
        public InputList<string> Messages
        {
            get => _messages ?? (_messages = new InputList<string>());
            set => _messages = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        public AddressStatusForwardersArgs()
        {
        }
    }
}
