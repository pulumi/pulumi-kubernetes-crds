// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Charts.V1
{

    public class XlSpecMediation-AixArgs : Pulumi.ResourceArgs
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
        /// component debug
        /// </summary>
        [Input("debug")]
        public Input<bool>? Debug { get; set; }

        /// <summary>
        /// component specific image options
        /// </summary>
        [Input("image")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-AixImageArgs>? Image { get; set; }

        /// <summary>
        /// component additional java options
        /// </summary>
        [Input("javaComponentOptions")]
        public Input<string>? JavaComponentOptions { get; set; }

        /// <summary>
        /// component resource configuration
        /// </summary>
        [Input("resources")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-AixResourcesArgs>? Resources { get; set; }

        public XlSpecMediation-AixArgs()
        {
        }
    }
}
