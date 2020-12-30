// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Charts.V1
{

    public class XlSpecDatacloudArgs : Pulumi.ResourceArgs
    {
        [Input("annotations")]
        private InputMap<object>? _annotations;

        /// <summary>
        /// component specific pod annotations list
        /// </summary>
        public InputMap<object> Annotations
        {
            get => _annotations ?? (_annotations = new InputMap<object>());
            set => _annotations = value;
        }

        /// <summary>
        /// Enable datacloud collector
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// component specific image options
        /// </summary>
        [Input("image")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecDatacloudImageArgs>? Image { get; set; }

        [Input("sevone")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecDatacloudSevoneArgs>? Sevone { get; set; }

        public XlSpecDatacloudArgs()
        {
        }
    }
}
