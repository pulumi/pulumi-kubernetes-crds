// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1
{

    /// <summary>
    /// ComposableSpec defines the desired state of Composable
    /// </summary>
    public class ComposableSpecArgs : Pulumi.ResourceArgs
    {
        [Input("template", required: true)]
        private InputMap<object>? _template;

        /// <summary>
        /// Template defines the underlying object
        /// </summary>
        public InputMap<object> Template
        {
            get => _template ?? (_template = new InputMap<object>());
            set => _template = value;
        }

        public ComposableSpecArgs()
        {
        }
    }
}