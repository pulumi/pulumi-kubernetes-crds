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
    /// A KubernetesApplicationSpec specifies the resources of a Kubernetes application.
    /// </summary>
    public class KubernetesApplicationSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ResourceSelector selects the KubernetesApplicationResources that are managed by this KubernetesApplication. Note that a KubernetesApplication will never adopt orphaned KubernetesApplicationResources, and thus this selector serves only to help match a KubernetesApplication to its KubernetesApplicationResources.
        /// </summary>
        [Input("resourceSelector", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Workload.V1Alpha1.KubernetesApplicationSpecResourceSelectorArgs> ResourceSelector { get; set; } = null!;

        [Input("resourceTemplates", required: true)]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Workload.V1Alpha1.KubernetesApplicationSpecResourceTemplatesArgs>? _resourceTemplates;

        /// <summary>
        /// ResourceTemplates specifies a set of Kubernetes application resources managed by this application.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Workload.V1Alpha1.KubernetesApplicationSpecResourceTemplatesArgs> ResourceTemplates
        {
            get => _resourceTemplates ?? (_resourceTemplates = new InputList<Pulumi.Kubernetes.Types.Inputs.Workload.V1Alpha1.KubernetesApplicationSpecResourceTemplatesArgs>());
            set => _resourceTemplates = value;
        }

        /// <summary>
        /// Target to which this application has been scheduled.
        /// </summary>
        [Input("targetRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Workload.V1Alpha1.KubernetesApplicationSpecTargetRefArgs>? TargetRef { get; set; }

        /// <summary>
        /// TargetSelector selects the targets to which this application may be scheduled. Leave both match labels and expressions empty to match any target.
        /// </summary>
        [Input("targetSelector")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Workload.V1Alpha1.KubernetesApplicationSpecTargetSelectorArgs>? TargetSelector { get; set; }

        public KubernetesApplicationSpecArgs()
        {
        }
    }
}
