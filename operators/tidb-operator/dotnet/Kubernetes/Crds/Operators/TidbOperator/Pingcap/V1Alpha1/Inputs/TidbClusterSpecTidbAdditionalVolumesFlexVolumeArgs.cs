// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1
{

    public class TidbClusterSpecTidbAdditionalVolumesFlexVolumeArgs : Pulumi.ResourceArgs
    {
        [Input("driver", required: true)]
        public Input<string> Driver { get; set; } = null!;

        [Input("fsType")]
        public Input<string>? FsType { get; set; }

        [Input("options")]
        private InputMap<object>? _options;
        public InputMap<object> Options
        {
            get => _options ?? (_options = new InputMap<object>());
            set => _options = value;
        }

        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        [Input("secretRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecTidbAdditionalVolumesFlexVolumeSecretRefArgs>? SecretRef { get; set; }

        public TidbClusterSpecTidbAdditionalVolumesFlexVolumeArgs()
        {
        }
    }
}
