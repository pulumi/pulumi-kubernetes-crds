// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1
{

    public class JaegerSpecAllInOneVolumesProjectedSourcesDownwardAPIArgs : Pulumi.ResourceArgs
    {
        [Input("items")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesProjectedSourcesDownwardAPIItemsArgs>? _items;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesProjectedSourcesDownwardAPIItemsArgs> Items
        {
            get => _items ?? (_items = new InputList<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesProjectedSourcesDownwardAPIItemsArgs>());
            set => _items = value;
        }

        public JaegerSpecAllInOneVolumesProjectedSourcesDownwardAPIArgs()
        {
        }
    }
}
