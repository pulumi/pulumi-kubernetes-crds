// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1
{

    public class JaegerSpecIngressVolumesConfigMapArgs : Pulumi.ResourceArgs
    {
        [Input("defaultMode")]
        public Input<int>? DefaultMode { get; set; }

        [Input("items")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecIngressVolumesConfigMapItemsArgs>? _items;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecIngressVolumesConfigMapItemsArgs> Items
        {
            get => _items ?? (_items = new InputList<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecIngressVolumesConfigMapItemsArgs>());
            set => _items = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("optional")]
        public Input<bool>? Optional { get; set; }

        public JaegerSpecIngressVolumesConfigMapArgs()
        {
        }
    }
}
