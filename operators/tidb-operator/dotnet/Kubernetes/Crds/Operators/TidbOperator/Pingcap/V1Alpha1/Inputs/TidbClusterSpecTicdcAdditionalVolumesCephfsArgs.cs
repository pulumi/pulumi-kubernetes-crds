// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1
{

    public class TidbClusterSpecTicdcAdditionalVolumesCephfsArgs : Pulumi.ResourceArgs
    {
        [Input("monitors", required: true)]
        private InputList<string>? _monitors;
        public InputList<string> Monitors
        {
            get => _monitors ?? (_monitors = new InputList<string>());
            set => _monitors = value;
        }

        [Input("path")]
        public Input<string>? Path { get; set; }

        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        [Input("secretFile")]
        public Input<string>? SecretFile { get; set; }

        [Input("secretRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTicdcAdditionalVolumesCephfsSecretRefArgs>? SecretRef { get; set; }

        [Input("user")]
        public Input<string>? User { get; set; }

        public TidbClusterSpecTicdcAdditionalVolumesCephfsArgs()
        {
        }
    }
}
