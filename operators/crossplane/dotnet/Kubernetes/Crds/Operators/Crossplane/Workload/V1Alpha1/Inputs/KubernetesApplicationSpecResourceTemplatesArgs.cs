// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Workload.V1Alpha1
{

    /// <summary>
    /// A KubernetesApplicationResourceTemplate is used to instantiate new KubernetesApplicationResources.
    /// </summary>
    public class KubernetesApplicationSpecResourceTemplatesArgs : Pulumi.ResourceArgs
    {
        [Input("metadata")]
        private InputMap<object>? _metadata;
        public InputMap<object> Metadata
        {
            get => _metadata ?? (_metadata = new InputMap<object>());
            set => _metadata = value;
        }

        /// <summary>
        /// KubernetesApplicationResourceSpec specifies the desired state of a KubernetesApplicationResource.
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Workload.V1Alpha1.KubernetesApplicationSpecResourceTemplatesSpecArgs>? Spec { get; set; }

        public KubernetesApplicationSpecResourceTemplatesArgs()
        {
        }
    }
}
