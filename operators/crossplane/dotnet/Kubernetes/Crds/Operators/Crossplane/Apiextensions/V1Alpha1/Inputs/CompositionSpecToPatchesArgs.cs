// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apiextensions.V1Alpha1
{

    /// <summary>
    /// Patch is used to patch the field on the base resource at ToFieldPath after piping the value that is at FromFieldPath of the target resource through transformers.
    /// </summary>
    public class CompositionSpecToPatchesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// FromFieldPath is the path of the field on the upstream resource whose value to be used as input.
        /// </summary>
        [Input("fromFieldPath", required: true)]
        public Input<string> FromFieldPath { get; set; } = null!;

        /// <summary>
        /// ToFieldPath is the path of the field on the base resource whose value will be changed with the result of transforms. Leave empty if you'd like to propagate to the same path on the target resource.
        /// </summary>
        [Input("toFieldPath")]
        public Input<string>? ToFieldPath { get; set; }

        [Input("transforms")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Apiextensions.V1Alpha1.CompositionSpecToPatchesTransformsArgs>? _transforms;

        /// <summary>
        /// Transforms are the list of functions that are used as a FIFO pipe for the input to be transformed.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Apiextensions.V1Alpha1.CompositionSpecToPatchesTransformsArgs> Transforms
        {
            get => _transforms ?? (_transforms = new InputList<Pulumi.Kubernetes.Types.Inputs.Apiextensions.V1Alpha1.CompositionSpecToPatchesTransformsArgs>());
            set => _transforms = value;
        }

        public CompositionSpecToPatchesArgs()
        {
        }
    }
}
