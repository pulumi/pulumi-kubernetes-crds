// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1
{

    /// <summary>
    /// GroupConfigSpec defines the desired state of GroupConfig There are two selectors: "labelSelector", "annotationSelector". Selectors are considered in AND, so if multiple are defined they must all be true for a Group to be selected.
    /// </summary>
    public class GroupConfigSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// AnnotationSelector selects Groups by annotation.
        /// </summary>
        [Input("annotationSelector")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.GroupConfigSpecAnnotationSelectorArgs>? AnnotationSelector { get; set; }

        /// <summary>
        /// LabelSelector selects Groups by label.
        /// </summary>
        [Input("labelSelector")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.GroupConfigSpecLabelSelectorArgs>? LabelSelector { get; set; }

        [Input("templates")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.GroupConfigSpecTemplatesArgs>? _templates;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.GroupConfigSpecTemplatesArgs> Templates
        {
            get => _templates ?? (_templates = new InputList<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.GroupConfigSpecTemplatesArgs>());
            set => _templates = value;
        }

        public GroupConfigSpecArgs()
        {
        }
    }
}