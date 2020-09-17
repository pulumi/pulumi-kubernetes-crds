// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1
{

    public class JaegerSpecAgentVolumesRbdArgs : Pulumi.ResourceArgs
    {
        [Input("fsType")]
        public Input<string>? FsType { get; set; }

        [Input("image", required: true)]
        public Input<string> Image { get; set; } = null!;

        [Input("keyring")]
        public Input<string>? Keyring { get; set; }

        [Input("monitors", required: true)]
        private InputList<string>? _monitors;
        public InputList<string> Monitors
        {
            get => _monitors ?? (_monitors = new InputList<string>());
            set => _monitors = value;
        }

        [Input("pool")]
        public Input<string>? Pool { get; set; }

        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        [Input("secretRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAgentVolumesRbdSecretRefArgs>? SecretRef { get; set; }

        [Input("user")]
        public Input<string>? User { get; set; }

        public JaegerSpecAgentVolumesRbdArgs()
        {
        }
    }
}
