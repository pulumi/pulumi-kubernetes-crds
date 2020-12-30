// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Charts.V1
{

    public class XlSpecArangodbArgs : Pulumi.ResourceArgs
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
        /// component specific image options
        /// </summary>
        [Input("image")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecArangodbImageArgs>? Image { get; set; }

        /// <summary>
        /// arangodb persistence options
        /// </summary>
        [Input("persistence")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecArangodbPersistenceArgs>? Persistence { get; set; }

        public XlSpecArangodbArgs()
        {
        }
    }
}
