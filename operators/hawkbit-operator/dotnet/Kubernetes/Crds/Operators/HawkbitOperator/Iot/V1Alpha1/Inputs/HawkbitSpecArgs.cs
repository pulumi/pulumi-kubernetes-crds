// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Iot.V1Alpha1
{

    public class HawkbitSpecArgs : Pulumi.ResourceArgs
    {
        [Input("database")]
        public Input<object>? Database { get; set; }

        [Input("imageOverrides")]
        private InputMap<Pulumi.Kubernetes.Types.Inputs.Iot.V1Alpha1.HawkbitSpecImageOverridesArgs>? _imageOverrides;
        public InputMap<Pulumi.Kubernetes.Types.Inputs.Iot.V1Alpha1.HawkbitSpecImageOverridesArgs> ImageOverrides
        {
            get => _imageOverrides ?? (_imageOverrides = new InputMap<Pulumi.Kubernetes.Types.Inputs.Iot.V1Alpha1.HawkbitSpecImageOverridesArgs>());
            set => _imageOverrides = value;
        }

        [Input("rabbit")]
        public Input<object>? Rabbit { get; set; }

        [Input("signOn")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Iot.V1Alpha1.HawkbitSpecSignOnArgs>? SignOn { get; set; }

        public HawkbitSpecArgs()
        {
        }
    }
}
